namespace ProfilesGenerator
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.profileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DisplayName = new System.Windows.Forms.TextBox();
            this.characterRadio = new System.Windows.Forms.RadioButton();
            this.enemyRadio = new System.Windows.Forms.RadioButton();
            this.MeshName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WalkSpeed = new System.Windows.Forms.TextBox();
            this.DisplayNameOffset = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BodyMass = new System.Windows.Forms.TextBox();
            this.BodyScaleFactor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.HeadOffset = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CreateNewButton = new System.Windows.Forms.Button();
            this.DeleteProfileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(184, 326);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(169, 37);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Zapisz profile";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybierz profil";
            // 
            // profileName
            // 
            this.profileName.Location = new System.Drawing.Point(126, 87);
            this.profileName.Name = "profileName";
            this.profileName.Size = new System.Drawing.Size(227, 20);
            this.profileName.TabIndex = 3;
            this.profileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.profileName.TextChanged += new System.EventHandler(this.profileName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ProfileName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "DisplayName";
            // 
            // DisplayName
            // 
            this.DisplayName.Location = new System.Drawing.Point(126, 113);
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.Size = new System.Drawing.Size(227, 20);
            this.DisplayName.TabIndex = 6;
            this.DisplayName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DisplayName.TextChanged += new System.EventHandler(this.DisplayName_TextChanged);
            // 
            // characterRadio
            // 
            this.characterRadio.AutoSize = true;
            this.characterRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.characterRadio.Location = new System.Drawing.Point(161, 12);
            this.characterRadio.Name = "characterRadio";
            this.characterRadio.Size = new System.Drawing.Size(80, 17);
            this.characterRadio.TabIndex = 9;
            this.characterRadio.TabStop = true;
            this.characterRadio.Text = "Character";
            this.characterRadio.UseVisualStyleBackColor = true;
            this.characterRadio.CheckedChanged += new System.EventHandler(this.characterRadio_CheckedChanged);
            // 
            // enemyRadio
            // 
            this.enemyRadio.AutoSize = true;
            this.enemyRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enemyRadio.Location = new System.Drawing.Point(273, 12);
            this.enemyRadio.Name = "enemyRadio";
            this.enemyRadio.Size = new System.Drawing.Size(62, 17);
            this.enemyRadio.TabIndex = 10;
            this.enemyRadio.TabStop = true;
            this.enemyRadio.Text = "Enemy";
            this.enemyRadio.UseVisualStyleBackColor = true;
            this.enemyRadio.CheckedChanged += new System.EventHandler(this.enemyRadio_CheckedChanged);
            // 
            // MeshName
            // 
            this.MeshName.Location = new System.Drawing.Point(126, 139);
            this.MeshName.Name = "MeshName";
            this.MeshName.Size = new System.Drawing.Size(227, 20);
            this.MeshName.TabIndex = 11;
            this.MeshName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MeshName.TextChanged += new System.EventHandler(this.MeshName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "MeshName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "WalkSpeed";
            // 
            // WalkSpeed
            // 
            this.WalkSpeed.Location = new System.Drawing.Point(126, 166);
            this.WalkSpeed.Name = "WalkSpeed";
            this.WalkSpeed.Size = new System.Drawing.Size(227, 20);
            this.WalkSpeed.TabIndex = 14;
            this.WalkSpeed.Text = "1.85";
            this.WalkSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WalkSpeed.TextChanged += new System.EventHandler(this.WalkSpeed_TextChanged);
            // 
            // DisplayNameOffset
            // 
            this.DisplayNameOffset.Location = new System.Drawing.Point(126, 192);
            this.DisplayNameOffset.Name = "DisplayNameOffset";
            this.DisplayNameOffset.Size = new System.Drawing.Size(227, 20);
            this.DisplayNameOffset.TabIndex = 15;
            this.DisplayNameOffset.Text = "x|y|z";
            this.DisplayNameOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DisplayNameOffset.TextChanged += new System.EventHandler(this.DisplayNameOffset_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "DisplayNameOffset";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "BodyMass";
            // 
            // BodyMass
            // 
            this.BodyMass.Location = new System.Drawing.Point(126, 218);
            this.BodyMass.Name = "BodyMass";
            this.BodyMass.Size = new System.Drawing.Size(227, 20);
            this.BodyMass.TabIndex = 18;
            this.BodyMass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BodyMass.TextChanged += new System.EventHandler(this.BodyMass_TextChanged);
            // 
            // BodyScaleFactor
            // 
            this.BodyScaleFactor.Location = new System.Drawing.Point(126, 244);
            this.BodyScaleFactor.Name = "BodyScaleFactor";
            this.BodyScaleFactor.Size = new System.Drawing.Size(227, 20);
            this.BodyScaleFactor.TabIndex = 19;
            this.BodyScaleFactor.Text = "x|y|z";
            this.BodyScaleFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BodyScaleFactor.TextChanged += new System.EventHandler(this.BodyScaleFactor_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "BodyScaleFactor";
            // 
            // HeadOffset
            // 
            this.HeadOffset.Location = new System.Drawing.Point(126, 270);
            this.HeadOffset.Name = "HeadOffset";
            this.HeadOffset.Size = new System.Drawing.Size(226, 20);
            this.HeadOffset.TabIndex = 21;
            this.HeadOffset.Text = "x|y|z";
            this.HeadOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HeadOffset.TextChanged += new System.EventHandler(this.HeadOffset_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "HeadOffset";
            // 
            // CreateNewButton
            // 
            this.CreateNewButton.Location = new System.Drawing.Point(161, 40);
            this.CreateNewButton.Name = "CreateNewButton";
            this.CreateNewButton.Size = new System.Drawing.Size(174, 21);
            this.CreateNewButton.TabIndex = 23;
            this.CreateNewButton.Text = "Stworz nowy";
            this.CreateNewButton.UseVisualStyleBackColor = true;
            this.CreateNewButton.Click += new System.EventHandler(this.CreateNewButton_Click);
            // 
            // DeleteProfileButton
            // 
            this.DeleteProfileButton.Location = new System.Drawing.Point(12, 326);
            this.DeleteProfileButton.Name = "DeleteProfileButton";
            this.DeleteProfileButton.Size = new System.Drawing.Size(151, 37);
            this.DeleteProfileButton.TabIndex = 24;
            this.DeleteProfileButton.Text = "Usun profil";
            this.DeleteProfileButton.UseVisualStyleBackColor = true;
            this.DeleteProfileButton.Click += new System.EventHandler(this.DeleteProfileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 397);
            this.Controls.Add(this.DeleteProfileButton);
            this.Controls.Add(this.CreateNewButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.HeadOffset);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BodyScaleFactor);
            this.Controls.Add(this.BodyMass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DisplayNameOffset);
            this.Controls.Add(this.WalkSpeed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MeshName);
            this.Controls.Add(this.enemyRadio);
            this.Controls.Add(this.characterRadio);
            this.Controls.Add(this.DisplayName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.profileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.comboBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ProfilesGenerator!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox profileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DisplayName;
        private System.Windows.Forms.RadioButton characterRadio;
        private System.Windows.Forms.RadioButton enemyRadio;
        private System.Windows.Forms.TextBox MeshName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox WalkSpeed;
        private System.Windows.Forms.TextBox DisplayNameOffset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BodyMass;
        private System.Windows.Forms.TextBox BodyScaleFactor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox HeadOffset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button CreateNewButton;
        private System.Windows.Forms.Button DeleteProfileButton;
    }
}

