namespace DegreeCalculator
{
    partial class ChooseLevel
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
            this.level4Button = new System.Windows.Forms.Button();
            this.lvl5Button = new System.Windows.Forms.Button();
            this.lvl6Button = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // level4Button
            // 
            this.level4Button.Location = new System.Drawing.Point(106, 104);
            this.level4Button.Name = "level4Button";
            this.level4Button.Size = new System.Drawing.Size(63, 54);
            this.level4Button.TabIndex = 0;
            this.level4Button.Text = "Level 4";
            this.level4Button.UseVisualStyleBackColor = true;
            this.level4Button.Click += new System.EventHandler(this.level4Button_Click);
            // 
            // lvl5Button
            // 
            this.lvl5Button.Location = new System.Drawing.Point(216, 104);
            this.lvl5Button.Name = "lvl5Button";
            this.lvl5Button.Size = new System.Drawing.Size(63, 54);
            this.lvl5Button.TabIndex = 1;
            this.lvl5Button.Text = "Level 5";
            this.lvl5Button.UseVisualStyleBackColor = true;
            this.lvl5Button.Click += new System.EventHandler(this.lvl5Button_Click);
            // 
            // lvl6Button
            // 
            this.lvl6Button.Location = new System.Drawing.Point(327, 104);
            this.lvl6Button.Name = "lvl6Button";
            this.lvl6Button.Size = new System.Drawing.Size(63, 54);
            this.lvl6Button.TabIndex = 2;
            this.lvl6Button.Text = "Level 6";
            this.lvl6Button.UseVisualStyleBackColor = true;
            this.lvl6Button.Click += new System.EventHandler(this.lvl6Button_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(64, 26);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ChooseLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 286);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.lvl6Button);
            this.Controls.Add(this.lvl5Button);
            this.Controls.Add(this.level4Button);
            this.Name = "ChooseLevel";
            this.Text = "chooseLevel";
            this.Load += new System.EventHandler(this.ChooseLevel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button level4Button;
        private System.Windows.Forms.Button lvl5Button;
        private System.Windows.Forms.Button lvl6Button;
        private System.Windows.Forms.Button backButton;
    }
}