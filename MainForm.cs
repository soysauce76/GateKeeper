using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GameGatekeeper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.label3.Text = "Whatcha think you\'re doing? Write me " + Constants.REQ_WORD_COUNT + " words and I\'ll let you pass!";

        }


        // Handle Mainform shortcuts (e.g. Ctrl S, Ctrl O)
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.ToString() == "S")
            {
                Functions.saveWork(this.titleTextBox.Rtf, this.richTextBox.Rtf, "Draft"); // hey look I added a line!
                //hey look I added another line
                //saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                //saveFileDialog1.FilterIndex = 1;
                //saveFileDialog1.RestoreDirectory = true;
                //if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                //{
                //    // When the user presses both the 'Alt' key and 'F' key,
                //    // KeyPreview is set to False, and a message appears.
                //    // This message is only displayed when KeyPreview is set to False.
                //    if (richTextBox.TextLength == 0)
                //    {
                //        MessageBox.Show("You don't have anything to save!  Save aborted.");
                //        return;
                //    }
                //    // if it correctly got a name
                //    else if (saveFileDialog1.FileName.Length != 0)
                //    {
                //        MessageBox.Show("Saving your file");
                //        System.IO.File.WriteAllText(saveFileDialog1.FileName, richTextBox.Text);
                //    }
                //}
            }
        }

        // Hack to get Tab working (as opposed to scrolling through buttons)
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Tab) return false;
            return base.ProcessDialogKey(keyData);
        }

        // Defines all of my custom keyboard shortcuts for the text
        private void richTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Disable pasting
            if (e.Control && e.KeyCode.ToString() == "V")
            {
                MessageBox.Show("Haha, Cheater!");
            }
            // Handle Toggle Bold
            if (e.Control && e.KeyCode.ToString() == "B")
            {
                if (richTextBox.SelectionFont != null)
                {
                    System.Drawing.Font currentFont = richTextBox.SelectionFont;
                    System.Drawing.FontStyle newFontStyle;

                    if (richTextBox.SelectionFont.Bold == true)
                    {
                        newFontStyle = FontStyle.Regular;
                    }
                    else
                    {
                        newFontStyle = FontStyle.Bold;
                    }
                    richTextBox.SelectionFont = new Font(
                        currentFont.FontFamily,
                        currentFont.Size,
                        newFontStyle
                     );
                }

            }
            // Handle Toggle Italic
            if (e.Control && e.KeyCode.ToString() == "I")
            {
                if (richTextBox.SelectionFont != null)
                {
                    System.Drawing.Font currentFont = richTextBox.SelectionFont;
                    System.Drawing.FontStyle newFontStyle;

                    if (richTextBox.SelectionFont.Italic == true)
                    {
                        newFontStyle = FontStyle.Regular;
                    }
                    else
                    {
                        newFontStyle = FontStyle.Italic;
                    }

                    richTextBox.SelectionFont = new Font(
                       currentFont.FontFamily,
                       currentFont.Size,
                       newFontStyle
                    );
                    // This is used to suppress the build in indent response of RichTextBox
                    e.SuppressKeyPress = true;
                }
            }
            // Handle Toggle Underline
            if (e.Control && e.KeyCode.ToString() == "U")
            {
                if (richTextBox.SelectionFont != null)
                {
                    System.Drawing.Font currentFont = richTextBox.SelectionFont;
                    System.Drawing.FontStyle newFontStyle;

                    if (richTextBox.SelectionFont.Underline == true)
                    {
                        newFontStyle = FontStyle.Regular;
                    }
                    else
                    {
                        newFontStyle = FontStyle.Underline;
                    }

                    richTextBox.SelectionFont = new Font(
                       currentFont.FontFamily,
                       currentFont.Size,
                       newFontStyle
                    );
                }
            }
            // Handle Toggle Red font
            if (e.Control && e.Shift && e.KeyCode.ToString() == "R")
            {
                if (richTextBox.SelectionFont != null)
                {
                    Color currentFont = richTextBox.SelectionColor;

                    if (richTextBox.SelectionColor == Color.Red)
                    {
                        richTextBox.SelectionColor = Color.Black;
                    }
                    else
                    {
                        richTextBox.SelectionColor = Color.Red;
                    }
                }
            }
            // Handle Bulleted List
            if (e.Control && e.KeyCode.ToString() == "Q")
            {
                //if (richTextBox1.SelectionFont != null)
                //{
                if (richTextBox.SelectionBullet == true)
                {
                    richTextBox.SelectionBullet = false;
                    richTextBox.SelectionIndent = 0;
                }
                else
                {
                    richTextBox.SelectionBullet = true;
                }
                //}
            }
            // Handle tab indention
            if (e.KeyCode.ToString() == "\t")
            {
                if (richTextBox.SelectionFont != null)
                {
                    if (richTextBox.SelectionBullet == false)
                    {

                        richTextBox.AppendText("     ");
                    }
                    if (richTextBox.SelectionBullet == true)
                    {
                        MessageBox.Show("Got here");
                        richTextBox.BulletIndent = 8;
                    }
                }
            }

        }

        private void firstCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveDraftButton_Click(object sender, EventArgs e)
        {
            Functions.saveWork(this.titleTextBox.Rtf, this.richTextBox.Rtf, "Draft");
        }

        private void finishedWritingButton_Click(object sender, EventArgs e)
        {
            // save work and finalize writing file
            WantToSaveForm saveForm = new WantToSaveForm();
            if (saveForm.ShowDialog() == DialogResult.Yes)
            {
                Functions.saveWork(this.titleTextBox.Rtf, this.richTextBox.Rtf, "Final");
            }

            // Create games dictionary
            Dictionary<String, String> gamesDict = Functions.initializeGamesDictionary();
            // pop up select games form
            SelectGameForm selectGame = new SelectGameForm();
            if (selectGame.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
 
            // Attempt to start up game based on executable path pulled from select game form
            System.Diagnostics.Process myProc = new System.Diagnostics.Process();
            myProc.StartInfo.FileName = selectGame.outputBox.Text;
            try
            {
                myProc.Start();
            }
            catch (Win32Exception w)
            {
                Console.WriteLine(w.Message);
                Console.WriteLine(w.ErrorCode.ToString());
                Console.WriteLine(w.NativeErrorCode.ToString());
                Console.WriteLine(w.StackTrace);
                Console.WriteLine(w.Source);
                Exception ex = w.GetBaseException();
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
                return;
            }
            // minimize window and sleep for some seconds. 
            // This way, if game is accidentally closed after opening, can restart it without having to go through gatekeeper again
            this.WindowState = FormWindowState.Minimized;
            System.Threading.Thread.Sleep(Constants.SECONDS_UNTIL_EXIT * 1000);
            // Check if the game process has exited. If not, close gatekeeper
            if (!myProc.HasExited)
            {
                this.Close();
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        // check wordcount every 100 ms
        private void timer1_Tick(object sender, EventArgs e)
        {
            int wordcount = Functions.checkWordCount(richTextBox.Text);
            // update word count 
            wordCountLabel.Text = wordcount.ToString();
            // if required word count is reached, enable the Ready! button
            if (wordcount >= Constants.REQ_WORD_COUNT)
            {
                finishedWritingButton.Enabled = true;
            }
        }

        // show help dialogue box
        private void helpMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            if (help.ShowDialog() == DialogResult.OK)
            {
                return;
            }
        }

    }
}
