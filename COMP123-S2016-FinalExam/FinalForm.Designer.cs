namespace COMP123_M2020_FinalExam
{
    partial class FinalForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AbilityGroupBox = new System.Windows.Forms.GroupBox();
            this.CharismaTextBox = new System.Windows.Forms.TextBox();
            this.CharismaLabel = new System.Windows.Forms.Label();
            this.WisdomTextBox = new System.Windows.Forms.TextBox();
            this.WisdomLabel = new System.Windows.Forms.Label();
            this.IntelligenceTextBox = new System.Windows.Forms.TextBox();
            this.IntelligenceLabel = new System.Windows.Forms.Label();
            this.ConstitutionTextBox = new System.Windows.Forms.TextBox();
            this.ConstitutionLabel = new System.Windows.Forms.Label();
            this.DexterityTextBox = new System.Windows.Forms.TextBox();
            this.DexterityLabel = new System.Windows.Forms.Label();
            this.StrengthTextBox = new System.Windows.Forms.TextBox();
            this.StrengthLabel = new System.Windows.Forms.Label();
            this.LastNameLabel2 = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RaceLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.AbilityGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(504, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(113, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(12, 429);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(113, 40);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(379, 429);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(113, 40);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // AbilityGroupBox
            // 
            this.AbilityGroupBox.Controls.Add(this.CharismaTextBox);
            this.AbilityGroupBox.Controls.Add(this.CharismaLabel);
            this.AbilityGroupBox.Controls.Add(this.WisdomTextBox);
            this.AbilityGroupBox.Controls.Add(this.WisdomLabel);
            this.AbilityGroupBox.Controls.Add(this.IntelligenceTextBox);
            this.AbilityGroupBox.Controls.Add(this.IntelligenceLabel);
            this.AbilityGroupBox.Controls.Add(this.ConstitutionTextBox);
            this.AbilityGroupBox.Controls.Add(this.ConstitutionLabel);
            this.AbilityGroupBox.Controls.Add(this.DexterityTextBox);
            this.AbilityGroupBox.Controls.Add(this.DexterityLabel);
            this.AbilityGroupBox.Controls.Add(this.StrengthTextBox);
            this.AbilityGroupBox.Controls.Add(this.StrengthLabel);
            this.AbilityGroupBox.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbilityGroupBox.Location = new System.Drawing.Point(12, 27);
            this.AbilityGroupBox.Name = "AbilityGroupBox";
            this.AbilityGroupBox.Size = new System.Drawing.Size(146, 396);
            this.AbilityGroupBox.TabIndex = 7;
            this.AbilityGroupBox.TabStop = false;
            this.AbilityGroupBox.Text = "Abilities";
            // 
            // CharismaTextBox
            // 
            this.CharismaTextBox.BackColor = System.Drawing.Color.White;
            this.CharismaTextBox.Location = new System.Drawing.Point(7, 361);
            this.CharismaTextBox.Name = "CharismaTextBox";
            this.CharismaTextBox.ReadOnly = true;
            this.CharismaTextBox.Size = new System.Drawing.Size(127, 26);
            this.CharismaTextBox.TabIndex = 11;
            this.CharismaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CharismaLabel
            // 
            this.CharismaLabel.AutoSize = true;
            this.CharismaLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharismaLabel.Location = new System.Drawing.Point(7, 335);
            this.CharismaLabel.Name = "CharismaLabel";
            this.CharismaLabel.Size = new System.Drawing.Size(82, 18);
            this.CharismaLabel.TabIndex = 10;
            this.CharismaLabel.Text = "Charisma";
            // 
            // WisdomTextBox
            // 
            this.WisdomTextBox.BackColor = System.Drawing.Color.White;
            this.WisdomTextBox.Location = new System.Drawing.Point(7, 301);
            this.WisdomTextBox.Name = "WisdomTextBox";
            this.WisdomTextBox.ReadOnly = true;
            this.WisdomTextBox.Size = new System.Drawing.Size(127, 26);
            this.WisdomTextBox.TabIndex = 9;
            this.WisdomTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WisdomLabel
            // 
            this.WisdomLabel.AutoSize = true;
            this.WisdomLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WisdomLabel.Location = new System.Drawing.Point(7, 275);
            this.WisdomLabel.Name = "WisdomLabel";
            this.WisdomLabel.Size = new System.Drawing.Size(69, 18);
            this.WisdomLabel.TabIndex = 8;
            this.WisdomLabel.Text = "Wisdom";
            // 
            // IntelligenceTextBox
            // 
            this.IntelligenceTextBox.BackColor = System.Drawing.Color.White;
            this.IntelligenceTextBox.Location = new System.Drawing.Point(7, 241);
            this.IntelligenceTextBox.Name = "IntelligenceTextBox";
            this.IntelligenceTextBox.ReadOnly = true;
            this.IntelligenceTextBox.Size = new System.Drawing.Size(127, 26);
            this.IntelligenceTextBox.TabIndex = 7;
            this.IntelligenceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IntelligenceLabel
            // 
            this.IntelligenceLabel.AutoSize = true;
            this.IntelligenceLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntelligenceLabel.Location = new System.Drawing.Point(7, 215);
            this.IntelligenceLabel.Name = "IntelligenceLabel";
            this.IntelligenceLabel.Size = new System.Drawing.Size(102, 18);
            this.IntelligenceLabel.TabIndex = 6;
            this.IntelligenceLabel.Text = "Intelligence";
            // 
            // ConstitutionTextBox
            // 
            this.ConstitutionTextBox.BackColor = System.Drawing.Color.White;
            this.ConstitutionTextBox.Location = new System.Drawing.Point(7, 181);
            this.ConstitutionTextBox.Name = "ConstitutionTextBox";
            this.ConstitutionTextBox.ReadOnly = true;
            this.ConstitutionTextBox.Size = new System.Drawing.Size(127, 26);
            this.ConstitutionTextBox.TabIndex = 5;
            this.ConstitutionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConstitutionLabel
            // 
            this.ConstitutionLabel.AutoSize = true;
            this.ConstitutionLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConstitutionLabel.Location = new System.Drawing.Point(7, 155);
            this.ConstitutionLabel.Name = "ConstitutionLabel";
            this.ConstitutionLabel.Size = new System.Drawing.Size(109, 18);
            this.ConstitutionLabel.TabIndex = 4;
            this.ConstitutionLabel.Text = "Constitution";
            // 
            // DexterityTextBox
            // 
            this.DexterityTextBox.BackColor = System.Drawing.Color.White;
            this.DexterityTextBox.Location = new System.Drawing.Point(7, 121);
            this.DexterityTextBox.Name = "DexterityTextBox";
            this.DexterityTextBox.ReadOnly = true;
            this.DexterityTextBox.Size = new System.Drawing.Size(127, 26);
            this.DexterityTextBox.TabIndex = 3;
            this.DexterityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DexterityLabel
            // 
            this.DexterityLabel.AutoSize = true;
            this.DexterityLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DexterityLabel.Location = new System.Drawing.Point(7, 95);
            this.DexterityLabel.Name = "DexterityLabel";
            this.DexterityLabel.Size = new System.Drawing.Size(83, 18);
            this.DexterityLabel.TabIndex = 2;
            this.DexterityLabel.Text = "Dexterity";
            // 
            // StrengthTextBox
            // 
            this.StrengthTextBox.BackColor = System.Drawing.Color.White;
            this.StrengthTextBox.Location = new System.Drawing.Point(7, 61);
            this.StrengthTextBox.Name = "StrengthTextBox";
            this.StrengthTextBox.ReadOnly = true;
            this.StrengthTextBox.Size = new System.Drawing.Size(127, 26);
            this.StrengthTextBox.TabIndex = 1;
            this.StrengthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.AutoSize = true;
            this.StrengthLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrengthLabel.Location = new System.Drawing.Point(7, 35);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(78, 18);
            this.StrengthLabel.TabIndex = 0;
            this.StrengthLabel.Text = "Strength";
            // 
            // LastNameLabel2
            // 
            this.LastNameLabel2.AutoSize = true;
            this.LastNameLabel2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel2.Location = new System.Drawing.Point(340, 33);
            this.LastNameLabel2.Name = "LastNameLabel2";
            this.LastNameLabel2.Size = new System.Drawing.Size(88, 18);
            this.LastNameLabel2.TabIndex = 11;
            this.LastNameLabel2.Text = "Last Name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.Location = new System.Drawing.Point(340, 54);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(152, 26);
            this.LastNameTextBox.TabIndex = 10;
            // 
            // FirstNameLabel2
            // 
            this.FirstNameLabel2.AutoSize = true;
            this.FirstNameLabel2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel2.Location = new System.Drawing.Point(168, 33);
            this.FirstNameLabel2.Name = "FirstNameLabel2";
            this.FirstNameLabel2.Size = new System.Drawing.Size(89, 18);
            this.FirstNameLabel2.TabIndex = 9;
            this.FirstNameLabel2.Text = "First Name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(168, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 26);
            this.textBox1.TabIndex = 8;
            // 
            // RaceLabel
            // 
            this.RaceLabel.AutoSize = true;
            this.RaceLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaceLabel.Location = new System.Drawing.Point(168, 127);
            this.RaceLabel.Name = "RaceLabel";
            this.RaceLabel.Size = new System.Drawing.Size(46, 18);
            this.RaceLabel.TabIndex = 13;
            this.RaceLabel.Text = "Race";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(168, 148);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 26);
            this.textBox2.TabIndex = 12;
            // 
            // FinalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(504, 481);
            this.ControlBox = false;
            this.Controls.Add(this.RaceLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LastNameLabel2);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameLabel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AbilityGroupBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FinalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.AbilityGroupBox.ResumeLayout(false);
            this.AbilityGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        protected System.Windows.Forms.Button BackButton;
        protected System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.GroupBox AbilityGroupBox;
        private System.Windows.Forms.TextBox CharismaTextBox;
        private System.Windows.Forms.Label CharismaLabel;
        private System.Windows.Forms.TextBox WisdomTextBox;
        private System.Windows.Forms.Label WisdomLabel;
        private System.Windows.Forms.TextBox IntelligenceTextBox;
        private System.Windows.Forms.Label IntelligenceLabel;
        private System.Windows.Forms.TextBox ConstitutionTextBox;
        private System.Windows.Forms.Label ConstitutionLabel;
        private System.Windows.Forms.TextBox DexterityTextBox;
        private System.Windows.Forms.Label DexterityLabel;
        private System.Windows.Forms.TextBox StrengthTextBox;
        private System.Windows.Forms.Label StrengthLabel;
        private System.Windows.Forms.Label LastNameLabel2;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label FirstNameLabel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label RaceLabel;
        private System.Windows.Forms.TextBox textBox2;
    }
}