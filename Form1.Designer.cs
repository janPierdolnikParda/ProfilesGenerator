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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DeleteProfileButton = new System.Windows.Forms.Button();
            this.CreateNewButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.HeadOffset = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BodyScaleFactor = new System.Windows.Forms.TextBox();
            this.BodyMass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DisplayNameOffset = new System.Windows.Forms.TextBox();
            this.WalkSpeed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MeshName = new System.Windows.Forms.TextBox();
            this.enemyRadio = new System.Windows.Forms.RadioButton();
            this.characterRadio = new System.Windows.Forms.RadioButton();
            this.DisplayName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.profileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.iCreateNewButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.describedRadio = new System.Windows.Forms.RadioButton();
            this.itemSwordRadio = new System.Windows.Forms.RadioButton();
            this.idString = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.mesh = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.inventoryMaterial = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.mass = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Pickable = new System.Windows.Forms.CheckBox();
            this.Equipment = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.nameOffset = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.iDeleteButton = new System.Windows.Forms.Button();
            this.iSaveButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(365, 396);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.DeleteProfileButton);
            this.tabPage1.Controls.Add(this.CreateNewButton);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.HeadOffset);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.BodyScaleFactor);
            this.tabPage1.Controls.Add(this.BodyMass);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.DisplayNameOffset);
            this.tabPage1.Controls.Add(this.WalkSpeed);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.MeshName);
            this.tabPage1.Controls.Add(this.enemyRadio);
            this.tabPage1.Controls.Add(this.characterRadio);
            this.tabPage1.Controls.Add(this.DisplayName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.profileName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.saveButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(357, 370);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Character/Enemy";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 21);
            this.comboBox1.TabIndex = 48;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DeleteProfileButton
            // 
            this.DeleteProfileButton.Location = new System.Drawing.Point(12, 327);
            this.DeleteProfileButton.Name = "DeleteProfileButton";
            this.DeleteProfileButton.Size = new System.Drawing.Size(151, 37);
            this.DeleteProfileButton.TabIndex = 47;
            this.DeleteProfileButton.Text = "Usun profil";
            this.DeleteProfileButton.UseVisualStyleBackColor = true;
            this.DeleteProfileButton.Click += new System.EventHandler(this.DeleteProfileButton_Click);
            // 
            // CreateNewButton
            // 
            this.CreateNewButton.Location = new System.Drawing.Point(161, 41);
            this.CreateNewButton.Name = "CreateNewButton";
            this.CreateNewButton.Size = new System.Drawing.Size(174, 21);
            this.CreateNewButton.TabIndex = 46;
            this.CreateNewButton.Text = "Stworz nowy";
            this.CreateNewButton.UseVisualStyleBackColor = true;
            this.CreateNewButton.Click += new System.EventHandler(this.CreateNewButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "HeadOffset";
            // 
            // HeadOffset
            // 
            this.HeadOffset.Location = new System.Drawing.Point(126, 271);
            this.HeadOffset.Name = "HeadOffset";
            this.HeadOffset.Size = new System.Drawing.Size(226, 20);
            this.HeadOffset.TabIndex = 42;
            this.HeadOffset.Text = "x|y|z";
            this.HeadOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HeadOffset.TextChanged += new System.EventHandler(this.HeadOffset_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "BodyScaleFactor";
            // 
            // BodyScaleFactor
            // 
            this.BodyScaleFactor.Location = new System.Drawing.Point(126, 245);
            this.BodyScaleFactor.Name = "BodyScaleFactor";
            this.BodyScaleFactor.Size = new System.Drawing.Size(227, 20);
            this.BodyScaleFactor.TabIndex = 40;
            this.BodyScaleFactor.Text = "x|y|z";
            this.BodyScaleFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BodyScaleFactor.TextChanged += new System.EventHandler(this.BodyScaleFactor_TextChanged);
            // 
            // BodyMass
            // 
            this.BodyMass.Location = new System.Drawing.Point(126, 219);
            this.BodyMass.Name = "BodyMass";
            this.BodyMass.Size = new System.Drawing.Size(227, 20);
            this.BodyMass.TabIndex = 39;
            this.BodyMass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BodyMass.TextChanged += new System.EventHandler(this.BodyMass_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "BodyMass";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "DisplayNameOffset";
            // 
            // DisplayNameOffset
            // 
            this.DisplayNameOffset.Location = new System.Drawing.Point(126, 193);
            this.DisplayNameOffset.Name = "DisplayNameOffset";
            this.DisplayNameOffset.Size = new System.Drawing.Size(227, 20);
            this.DisplayNameOffset.TabIndex = 36;
            this.DisplayNameOffset.Text = "x|y|z";
            this.DisplayNameOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DisplayNameOffset.TextChanged += new System.EventHandler(this.DisplayNameOffset_TextChanged);
            // 
            // WalkSpeed
            // 
            this.WalkSpeed.Location = new System.Drawing.Point(126, 167);
            this.WalkSpeed.Name = "WalkSpeed";
            this.WalkSpeed.Size = new System.Drawing.Size(227, 20);
            this.WalkSpeed.TabIndex = 35;
            this.WalkSpeed.Text = "1,85";
            this.WalkSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WalkSpeed.TextChanged += new System.EventHandler(this.WalkSpeed_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "WalkSpeed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "MeshName";
            // 
            // MeshName
            // 
            this.MeshName.Location = new System.Drawing.Point(126, 140);
            this.MeshName.Name = "MeshName";
            this.MeshName.Size = new System.Drawing.Size(227, 20);
            this.MeshName.TabIndex = 32;
            this.MeshName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MeshName.TextChanged += new System.EventHandler(this.MeshName_TextChanged);
            // 
            // enemyRadio
            // 
            this.enemyRadio.AutoSize = true;
            this.enemyRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enemyRadio.Location = new System.Drawing.Point(273, 13);
            this.enemyRadio.Name = "enemyRadio";
            this.enemyRadio.Size = new System.Drawing.Size(62, 17);
            this.enemyRadio.TabIndex = 45;
            this.enemyRadio.TabStop = true;
            this.enemyRadio.Text = "Enemy";
            this.enemyRadio.UseVisualStyleBackColor = true;
            this.enemyRadio.CheckedChanged += new System.EventHandler(this.enemyRadio_CheckedChanged);
            // 
            // characterRadio
            // 
            this.characterRadio.AutoSize = true;
            this.characterRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.characterRadio.Location = new System.Drawing.Point(161, 13);
            this.characterRadio.Name = "characterRadio";
            this.characterRadio.Size = new System.Drawing.Size(80, 17);
            this.characterRadio.TabIndex = 43;
            this.characterRadio.TabStop = true;
            this.characterRadio.Text = "Character";
            this.characterRadio.UseVisualStyleBackColor = true;
            this.characterRadio.CheckedChanged += new System.EventHandler(this.characterRadio_CheckedChanged);
            // 
            // DisplayName
            // 
            this.DisplayName.Location = new System.Drawing.Point(126, 114);
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.Size = new System.Drawing.Size(227, 20);
            this.DisplayName.TabIndex = 31;
            this.DisplayName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DisplayName.TextChanged += new System.EventHandler(this.DisplayName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "DisplayName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "ProfileName";
            // 
            // profileName
            // 
            this.profileName.Location = new System.Drawing.Point(126, 88);
            this.profileName.Name = "profileName";
            this.profileName.Size = new System.Drawing.Size(227, 20);
            this.profileName.TabIndex = 28;
            this.profileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.profileName.TextChanged += new System.EventHandler(this.profileName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Wybierz profil";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(184, 327);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(169, 37);
            this.saveButton.TabIndex = 26;
            this.saveButton.Text = "Zapisz profile";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.iSaveButton);
            this.tabPage2.Controls.Add(this.iDeleteButton);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.nameOffset);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.Equipment);
            this.tabPage2.Controls.Add(this.Pickable);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.mass);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.inventoryMaterial);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.mesh);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.description);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.name);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.idString);
            this.tabPage2.Controls.Add(this.itemSwordRadio);
            this.tabPage2.Controls.Add(this.describedRadio);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.iCreateNewButton);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(357, 370);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Items";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 36);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(126, 21);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(26, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Wybierz profil";
            // 
            // iCreateNewButton
            // 
            this.iCreateNewButton.Location = new System.Drawing.Point(156, 36);
            this.iCreateNewButton.Name = "iCreateNewButton";
            this.iCreateNewButton.Size = new System.Drawing.Size(170, 20);
            this.iCreateNewButton.TabIndex = 2;
            this.iCreateNewButton.Text = "Stworz nowy";
            this.iCreateNewButton.UseVisualStyleBackColor = true;
            this.iCreateNewButton.Click += new System.EventHandler(this.iCreateNewButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Type";
            // 
            // describedRadio
            // 
            this.describedRadio.AutoSize = true;
            this.describedRadio.Location = new System.Drawing.Point(97, 78);
            this.describedRadio.Name = "describedRadio";
            this.describedRadio.Size = new System.Drawing.Size(102, 17);
            this.describedRadio.TabIndex = 4;
            this.describedRadio.TabStop = true;
            this.describedRadio.Text = "DescribedProfile";
            this.describedRadio.UseVisualStyleBackColor = true;
            this.describedRadio.CheckedChanged += new System.EventHandler(this.describedRadio_CheckedChanged);
            // 
            // itemSwordRadio
            // 
            this.itemSwordRadio.AutoSize = true;
            this.itemSwordRadio.Location = new System.Drawing.Point(223, 78);
            this.itemSwordRadio.Name = "itemSwordRadio";
            this.itemSwordRadio.Size = new System.Drawing.Size(75, 17);
            this.itemSwordRadio.TabIndex = 5;
            this.itemSwordRadio.TabStop = true;
            this.itemSwordRadio.Text = "ItemSword";
            this.itemSwordRadio.UseVisualStyleBackColor = true;
            this.itemSwordRadio.CheckedChanged += new System.EventHandler(this.itemSwordRadio_CheckedChanged);
            // 
            // idString
            // 
            this.idString.Location = new System.Drawing.Point(97, 101);
            this.idString.Name = "idString";
            this.idString.Size = new System.Drawing.Size(201, 20);
            this.idString.TabIndex = 6;
            this.idString.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idString.TextChanged += new System.EventHandler(this.idString_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "IdString";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(97, 127);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(201, 20);
            this.name.TabIndex = 8;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Name";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(97, 153);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(201, 20);
            this.description.TabIndex = 10;
            this.description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.description.TextChanged += new System.EventHandler(this.description_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 156);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Description";
            // 
            // mesh
            // 
            this.mesh.Location = new System.Drawing.Point(97, 179);
            this.mesh.Name = "mesh";
            this.mesh.Size = new System.Drawing.Size(201, 20);
            this.mesh.TabIndex = 12;
            this.mesh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mesh.TextChanged += new System.EventHandler(this.mesh_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 182);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Mesh";
            // 
            // inventoryMaterial
            // 
            this.inventoryMaterial.Location = new System.Drawing.Point(97, 205);
            this.inventoryMaterial.Name = "inventoryMaterial";
            this.inventoryMaterial.Size = new System.Drawing.Size(201, 20);
            this.inventoryMaterial.TabIndex = 14;
            this.inventoryMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inventoryMaterial.TextChanged += new System.EventHandler(this.inventoryMaterial_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 208);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "InventoryMaterial";
            // 
            // mass
            // 
            this.mass.Location = new System.Drawing.Point(97, 231);
            this.mass.Name = "mass";
            this.mass.Size = new System.Drawing.Size(201, 20);
            this.mass.TabIndex = 16;
            this.mass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mass.TextChanged += new System.EventHandler(this.mass_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 234);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Mass";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 258);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "IsPickable";
            // 
            // Pickable
            // 
            this.Pickable.AutoSize = true;
            this.Pickable.Location = new System.Drawing.Point(170, 257);
            this.Pickable.Name = "Pickable";
            this.Pickable.Size = new System.Drawing.Size(48, 17);
            this.Pickable.TabIndex = 19;
            this.Pickable.Text = "True";
            this.Pickable.UseVisualStyleBackColor = true;
            this.Pickable.CheckedChanged += new System.EventHandler(this.Pickable_CheckedChanged);
            // 
            // Equipment
            // 
            this.Equipment.AutoSize = true;
            this.Equipment.Location = new System.Drawing.Point(170, 280);
            this.Equipment.Name = "Equipment";
            this.Equipment.Size = new System.Drawing.Size(48, 17);
            this.Equipment.TabIndex = 20;
            this.Equipment.Text = "True";
            this.Equipment.UseVisualStyleBackColor = true;
            this.Equipment.CheckedChanged += new System.EventHandler(this.Equipment_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 281);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 13);
            this.label19.TabIndex = 21;
            this.label19.Text = "IsEquipment";
            // 
            // nameOffset
            // 
            this.nameOffset.Location = new System.Drawing.Point(97, 303);
            this.nameOffset.Name = "nameOffset";
            this.nameOffset.Size = new System.Drawing.Size(201, 20);
            this.nameOffset.TabIndex = 22;
            this.nameOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameOffset.TextChanged += new System.EventHandler(this.nameOffset_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(5, 306);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 13);
            this.label20.TabIndex = 23;
            this.label20.Text = "NameOffset";
            // 
            // iDeleteButton
            // 
            this.iDeleteButton.Location = new System.Drawing.Point(3, 338);
            this.iDeleteButton.Name = "iDeleteButton";
            this.iDeleteButton.Size = new System.Drawing.Size(142, 26);
            this.iDeleteButton.TabIndex = 24;
            this.iDeleteButton.Text = "Usun profil";
            this.iDeleteButton.UseVisualStyleBackColor = true;
            this.iDeleteButton.Click += new System.EventHandler(this.iDeleteButton_Click);
            // 
            // iSaveButton
            // 
            this.iSaveButton.Location = new System.Drawing.Point(192, 339);
            this.iSaveButton.Name = "iSaveButton";
            this.iSaveButton.Size = new System.Drawing.Size(158, 25);
            this.iSaveButton.TabIndex = 25;
            this.iSaveButton.Text = "Zapisz profile";
            this.iSaveButton.UseVisualStyleBackColor = true;
            this.iSaveButton.Click += new System.EventHandler(this.iSaveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 397);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ProfilesGenerator!";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button DeleteProfileButton;
        private System.Windows.Forms.Button CreateNewButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox HeadOffset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BodyScaleFactor;
        private System.Windows.Forms.TextBox BodyMass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DisplayNameOffset;
        private System.Windows.Forms.TextBox WalkSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MeshName;
        private System.Windows.Forms.RadioButton enemyRadio;
        private System.Windows.Forms.RadioButton characterRadio;
        private System.Windows.Forms.TextBox DisplayName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox profileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button iSaveButton;
        private System.Windows.Forms.Button iDeleteButton;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox nameOffset;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox Equipment;
        private System.Windows.Forms.CheckBox Pickable;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox mass;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox inventoryMaterial;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox mesh;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox idString;
        private System.Windows.Forms.RadioButton itemSwordRadio;
        private System.Windows.Forms.RadioButton describedRadio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button iCreateNewButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2;



    }
}

