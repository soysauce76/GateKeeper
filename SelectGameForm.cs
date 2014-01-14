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
    public partial class SelectGameForm : Form
    {
        public SelectGameForm()
        {
            InitializeComponent();
            InitializeGameButtons();
        }

        private void InitializeGameButtons()
        {
            Dictionary<String, String> gamesDict = Functions.initializeGamesDictionary();
            this.games = gamesDict;
            int numGames = this.games.Count;
            // add all buttons into list (don't know how else to do this)
            List<Button> myList = new List<Button>();
            myList.Add(this.button1);
            myList.Add(this.button2);
            myList.Add(this.button3);
            myList.Add(this.button4);
            myList.Add(this.button5);
            myList.Add(this.button6);
            myList.Add(this.button7);
            myList.Add(this.button8);
            myList.Add(this.button9);
            myList.Add(this.button10);
            myList.Add(this.button11);
            myList.Add(this.button12);
            int iterator = 0;
            // label and make visible the buttons for desired games
            foreach (KeyValuePair<String, String> pair in this.games)
            {
                String gameName = pair.Key;
                String gamePath = pair.Value;
                Button button = myList[iterator++];
                button.Visible = true;
                button.Text = gameName;
            }
 
        }

        // when a button is clicked, match up the name to the path. Return that path.
        private void button_Click(object sender, EventArgs e)
        {
            // find out which button was clicked
            Button clickedButton = sender as Button;
            String game = clickedButton.Text;
            // based on button text, find what the path is, using the game/path dictionary
            if (this.games.ContainsKey(game))
            {
                String path = this.games[game];
                // append the path to the 'outputBox', which is where I am holding the output information
                this.outputBox.Text = path;
            }
            // return DialogResult.OK to exit this form
            this.DialogResult = DialogResult.OK;
        }

        // close form and return to main form.
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
