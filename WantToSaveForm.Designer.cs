namespace GameGatekeeper
{
    partial class WantToSaveForm
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
            this.yesSaveButton = new System.Windows.Forms.Button();
            this.noSaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yesSaveButton
            // 
            this.yesSaveButton.Location = new System.Drawing.Point(14, 71);
            this.yesSaveButton.Name = "yesSaveButton";
            this.yesSaveButton.Size = new System.Drawing.Size(100, 31);
            this.yesSaveButton.TabIndex = 0;
            this.yesSaveButton.Text = "Yes";
            this.yesSaveButton.UseVisualStyleBackColor = true;
            this.yesSaveButton.Click += new System.EventHandler(this.yesSaveButton_Click);
            // 
            // noSaveButton
            // 
            this.noSaveButton.Location = new System.Drawing.Point(122, 71);
            this.noSaveButton.Name = "noSaveButton";
            this.noSaveButton.Size = new System.Drawing.Size(110, 30);
            this.noSaveButton.TabIndex = 1;
            this.noSaveButton.Text = "No";
            this.noSaveButton.UseVisualStyleBackColor = true;
            this.noSaveButton.Click += new System.EventHandler(this.noSaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Do you want to save your work?";
            // 
            // WantToSaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 113);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noSaveButton);
            this.Controls.Add(this.yesSaveButton);
            this.Name = "WantToSaveForm";
            this.Text = "Save?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yesSaveButton;
        private System.Windows.Forms.Button noSaveButton;
        private System.Windows.Forms.Label label1;
    }
}