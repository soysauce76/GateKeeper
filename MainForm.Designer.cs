namespace GameGatekeeper
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.finishedWritingButton = new System.Windows.Forms.Button();
            this.saveDraftButton = new System.Windows.Forms.Button();
            this.firstCancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDraftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamePathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeJournalPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.wordCountLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.titleTextBox = new System.Windows.Forms.RichTextBox();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox.Location = new System.Drawing.Point(12, 121);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(816, 286);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            this.richTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox_KeyDown);
            // 
            // finishedWritingButton
            // 
            this.finishedWritingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.finishedWritingButton.AutoSize = true;
            this.finishedWritingButton.Enabled = false;
            this.finishedWritingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishedWritingButton.Location = new System.Drawing.Point(17, 436);
            this.finishedWritingButton.Name = "finishedWritingButton";
            this.finishedWritingButton.Size = new System.Drawing.Size(221, 43);
            this.finishedWritingButton.TabIndex = 1;
            this.finishedWritingButton.Text = "Ready!";
            this.finishedWritingButton.UseVisualStyleBackColor = true;
            this.finishedWritingButton.Click += new System.EventHandler(this.finishedWritingButton_Click);
            // 
            // saveDraftButton
            // 
            this.saveDraftButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveDraftButton.AutoSize = true;
            this.saveDraftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveDraftButton.Location = new System.Drawing.Point(293, 436);
            this.saveDraftButton.Name = "saveDraftButton";
            this.saveDraftButton.Size = new System.Drawing.Size(242, 43);
            this.saveDraftButton.TabIndex = 2;
            this.saveDraftButton.Text = "Save Draft...";
            this.saveDraftButton.UseVisualStyleBackColor = true;
            this.saveDraftButton.Click += new System.EventHandler(this.saveDraftButton_Click);
            // 
            // firstCancelButton
            // 
            this.firstCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.firstCancelButton.AutoSize = true;
            this.firstCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstCancelButton.Location = new System.Drawing.Point(582, 436);
            this.firstCancelButton.Name = "firstCancelButton";
            this.firstCancelButton.Size = new System.Drawing.Size(234, 43);
            this.firstCancelButton.TabIndex = 3;
            this.firstCancelButton.Text = "Cancel";
            this.firstCancelButton.UseVisualStyleBackColor = true;
            this.firstCancelButton.Click += new System.EventHandler(this.firstCancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Optional: Add Title";
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.Color.Sienna;
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(839, 24);
            this.mainMenuStrip.TabIndex = 6;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveDraftToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveDraftToolStripMenuItem
            // 
            this.saveDraftToolStripMenuItem.Name = "saveDraftToolStripMenuItem";
            this.saveDraftToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.saveDraftToolStripMenuItem.Text = "Save Draft";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gamePathsToolStripMenuItem,
            this.changeToolStripMenuItem,
            this.changeJournalPathToolStripMenuItem});
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // gamePathsToolStripMenuItem
            // 
            this.gamePathsToolStripMenuItem.Name = "gamePathsToolStripMenuItem";
            this.gamePathsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.gamePathsToolStripMenuItem.Text = "Add Game";
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.changeToolStripMenuItem.Text = "Change Game Path";
            // 
            // changeJournalPathToolStripMenuItem
            // 
            this.changeJournalPathToolStripMenuItem.Name = "changeJournalPathToolStripMenuItem";
            this.changeJournalPathToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.changeJournalPathToolStripMenuItem.Text = "Change Journal Path";
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpMenuItem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(24, 20);
            this.helpMenuItem.Text = "?";
            this.helpMenuItem.Click += new System.EventHandler(this.helpMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Whoa there Girlie!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(392, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Whatcha think you\'re doing? Write me  words and I\'ll let you pass!";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Word Count : ";
            // 
            // wordCountLabel
            // 
            this.wordCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.wordCountLabel.AutoSize = true;
            this.wordCountLabel.Location = new System.Drawing.Point(107, 410);
            this.wordCountLabel.Name = "wordCountLabel";
            this.wordCountLabel.Size = new System.Drawing.Size(13, 13);
            this.wordCountLabel.TabIndex = 10;
            this.wordCountLabel.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(146, 86);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(681, 26);
            this.titleTextBox.TabIndex = 11;
            this.titleTextBox.Text = "";
            this.titleTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox_KeyDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(839, 491);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.wordCountLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstCancelButton);
            this.Controls.Add(this.saveDraftButton);
            this.Controls.Add(this.finishedWritingButton);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.mainMenuStrip);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Gatekeeper";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button finishedWritingButton;
        private System.Windows.Forms.Button saveDraftButton;
        private System.Windows.Forms.Button firstCancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label wordCountLabel;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDraftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamePathsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeJournalPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox titleTextBox;
    }
}

