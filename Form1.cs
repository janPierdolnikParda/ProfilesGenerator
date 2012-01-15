using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace ProfilesGenerator
{
    public partial class Form1 : Form
    {
        List<Enemy> EnemyProfiles;
        List<Character> CharacterProfiles;
        List<ItemProfile> ItemProfiles;

        public Form1()
        {
            EnemyProfiles = new List<Enemy>();
            CharacterProfiles = new List<Character>();
            ItemProfiles = new List<ItemProfile>();

            InitializeComponent();
            LadujZPliku();
            LadujItemyZPliku();
            characterRadio.Checked = true;
            UpdateView();
        }

        void UpdateView()
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                if (characterRadio.Checked)
                {
                    profileName.Text = CharacterProfiles[comboBox1.SelectedIndex].ProfileName;
                    DisplayName.Text = CharacterProfiles[comboBox1.SelectedIndex].DisplayName;
                    MeshName.Text = CharacterProfiles[comboBox1.SelectedIndex].MeshName;
                    WalkSpeed.Text = CharacterProfiles[comboBox1.SelectedIndex].WalkSpeed;
                    DisplayNameOffset.Text = CharacterProfiles[comboBox1.SelectedIndex].DisplayNameOffset;
                    BodyMass.Text = CharacterProfiles[comboBox1.SelectedIndex].BodyMass;
                    BodyScaleFactor.Text = CharacterProfiles[comboBox1.SelectedIndex].BodyScaleFactor;
                    HeadOffset.Text = CharacterProfiles[comboBox1.SelectedIndex].HeadOffset;
                }

                if (enemyRadio.Checked)
                {
                    profileName.Text = EnemyProfiles[comboBox1.SelectedIndex].ProfileName;
                    DisplayName.Text = EnemyProfiles[comboBox1.SelectedIndex].DisplayName;
                    MeshName.Text = EnemyProfiles[comboBox1.SelectedIndex].MeshName;
                    WalkSpeed.Text = EnemyProfiles[comboBox1.SelectedIndex].WalkSpeed;
                    DisplayNameOffset.Text = EnemyProfiles[comboBox1.SelectedIndex].DisplayNameOffset;
                    BodyMass.Text = EnemyProfiles[comboBox1.SelectedIndex].BodyMass;
                    BodyScaleFactor.Text = EnemyProfiles[comboBox1.SelectedIndex].BodyScaleFactor;
                    HeadOffset.Text = EnemyProfiles[comboBox1.SelectedIndex].HeadOffset;
                }
            }

            else
            {
                profileName.Text = "";
                DisplayName.Text = "";
                MeshName.Text = "";
                WalkSpeed.Text = "";
                DisplayNameOffset.Text = "";
                BodyMass.Text = "";
                BodyScaleFactor.Text = "";
                HeadOffset.Text = "";

                if (characterRadio.Checked && CharacterProfiles.Count > 0)
                {
                    comboBox1.SelectedIndex = 0;
                    UpdateView();
                }

                if (enemyRadio.Checked && EnemyProfiles.Count > 0)
                {
                    comboBox1.SelectedIndex = 0;
                    UpdateView();
                }
            }

            if (comboBox2.SelectedIndex >= 0)
            {
                idString.Text = ItemProfiles[comboBox2.SelectedIndex].IdString;
                name.Text = ItemProfiles[comboBox2.SelectedIndex].Name;
                mesh.Text = ItemProfiles[comboBox2.SelectedIndex].Mesh;

                Equipment.Checked = (bool.Parse(ItemProfiles[comboBox2.SelectedIndex].IsEquipment));
                Pickable.Checked = (bool.Parse(ItemProfiles[comboBox2.SelectedIndex].IsPickable));

                if (ItemProfiles[comboBox2.SelectedIndex].Type == "DescribedProfile")
                    describedRadio.Checked = true;
                else
                    itemSwordRadio.Checked = true;

                mass.Text = ItemProfiles[comboBox2.SelectedIndex].Mass;
                inventoryMaterial.Text = ItemProfiles[comboBox2.SelectedIndex].InventoryMaterial;
                description.Text = ItemProfiles[comboBox2.SelectedIndex].Description;
                nameOffset.Text = ItemProfiles[comboBox2.SelectedIndex].NameOffset;
            }

            else
            {
                idString.Text = "";
                name.Text = "";
                mesh.Text = "";
                Equipment.Checked = false;
                Pickable.Checked = false;
                describedRadio.Checked = false;
                itemSwordRadio.Checked = false;
                mass.Text = "";
                inventoryMaterial.Text = "";
                description.Text = "";
                nameOffset.Text = "";

                if (ItemProfiles.Count > 0 && comboBox2.SelectedIndex < 0)
                {
                    comboBox2.SelectedIndex = 0;
                    UpdateView();
                }
            }

        }


        private void CreateNewButton_Click(object sender, EventArgs e)
        {
            if (characterRadio.Checked)
            {
                CharacterProfiles.Add(new Character());
                comboBox1.Items.Add(CharacterProfiles[CharacterProfiles.Count - 1].ProfileName);
                comboBox1.SelectedIndex = CharacterProfiles.Count - 1;
                UpdateView();
            }

            if (enemyRadio.Checked)
            {
                EnemyProfiles.Add(new Enemy());
                comboBox1.Items.Add(EnemyProfiles[EnemyProfiles.Count - 1].ProfileName);
                comboBox1.SelectedIndex = EnemyProfiles.Count - 1;
                UpdateView();
            }
        }

        private void profileName_TextChanged(object sender, EventArgs e)
        {
            if (characterRadio.Checked && comboBox1.SelectedIndex >= 0)
            {
                CharacterProfiles[comboBox1.SelectedIndex].ProfileName = profileName.Text;
                comboBox1.Items[comboBox1.SelectedIndex] = profileName.Text;
            }

            if (enemyRadio.Checked && comboBox1.SelectedIndex >= 0)
            {
                EnemyProfiles[comboBox1.SelectedIndex].ProfileName = profileName.Text;
                comboBox1.Items[comboBox1.SelectedIndex] = profileName.Text;
            }
        }

        void LadujZListy(bool isCharacter)
        {
            if (isCharacter)
            {
                while (comboBox1.Items.Count > 0)
                    comboBox1.Items.RemoveAt(0);

                foreach (Character c in CharacterProfiles)
                    comboBox1.Items.Add(c.ProfileName);
            }

            else
            {
                while (comboBox1.Items.Count > 0)
                    comboBox1.Items.RemoveAt(0);

                foreach (Enemy e in EnemyProfiles)
                    comboBox1.Items.Add(e.ProfileName);
            }
        }

        private void DisplayName_TextChanged(object sender, EventArgs e)
        {
            if (characterRadio.Checked && comboBox1.SelectedIndex >= 0)
            {
                CharacterProfiles[comboBox1.SelectedIndex].DisplayName = DisplayName.Text;
            }

            if (enemyRadio.Checked && comboBox1.SelectedIndex >= 0)
            {
                EnemyProfiles[comboBox1.SelectedIndex].DisplayName = DisplayName.Text;
            }
        }

        private void MeshName_TextChanged(object sender, EventArgs e)
        {
            if (characterRadio.Checked && comboBox1.SelectedIndex >= 0)
            {
                CharacterProfiles[comboBox1.SelectedIndex].MeshName = MeshName.Text;
            }

            if (enemyRadio.Checked && comboBox1.SelectedIndex >= 0)
            {
                EnemyProfiles[comboBox1.SelectedIndex].MeshName = MeshName.Text;
            }
        }

        private void WalkSpeed_TextChanged(object sender, EventArgs e)
        {
            if (characterRadio.Checked && comboBox1.SelectedIndex >= 0)
            {
                CharacterProfiles[comboBox1.SelectedIndex].WalkSpeed = WalkSpeed.Text;
            }

            if (enemyRadio.Checked && comboBox1.SelectedIndex >= 0)
            {
                EnemyProfiles[comboBox1.SelectedIndex].WalkSpeed = WalkSpeed.Text;
            }
        }

        private void DisplayNameOffset_TextChanged(object sender, EventArgs e)
        {
            if (characterRadio.Checked && comboBox1.SelectedIndex >= 0)
            {
                CharacterProfiles[comboBox1.SelectedIndex].DisplayNameOffset = DisplayNameOffset.Text;
            }

            if (enemyRadio.Checked && comboBox1.SelectedIndex >= 0)
            {
                EnemyProfiles[comboBox1.SelectedIndex].DisplayNameOffset = DisplayNameOffset.Text;
            }
        }

        private void BodyMass_TextChanged(object sender, EventArgs e)
        {
            if (characterRadio.Checked && comboBox1.SelectedIndex >= 0)
            {
                CharacterProfiles[comboBox1.SelectedIndex].BodyMass = BodyMass.Text;
            }

            if (enemyRadio.Checked && comboBox1.SelectedIndex >= 0)
            {
                EnemyProfiles[comboBox1.SelectedIndex].BodyMass = BodyMass.Text;
            }
        }

        private void BodyScaleFactor_TextChanged(object sender, EventArgs e)
        {
            if (characterRadio.Checked && comboBox1.SelectedIndex >= 0)
            {
                CharacterProfiles[comboBox1.SelectedIndex].BodyScaleFactor = BodyScaleFactor.Text;
            }

            if (enemyRadio.Checked && comboBox1.SelectedIndex >= 0)
            {
                EnemyProfiles[comboBox1.SelectedIndex].BodyScaleFactor = BodyScaleFactor.Text;
            }
        }

        private void HeadOffset_TextChanged(object sender, EventArgs e)
        {
            if (characterRadio.Checked && comboBox1.SelectedIndex >= 0)
            {
                CharacterProfiles[comboBox1.SelectedIndex].HeadOffset = HeadOffset.Text;
            }

            if (enemyRadio.Checked && comboBox1.SelectedIndex >= 0)
            {
                EnemyProfiles[comboBox1.SelectedIndex].HeadOffset = HeadOffset.Text;
            }
        }

        private void DeleteProfileButton_Click(object sender, EventArgs e)
        {
            int Tymczas = comboBox1.SelectedIndex;
            if (enemyRadio.Checked && comboBox1.SelectedIndex >= 0)
            {
                EnemyProfiles.RemoveAt(comboBox1.SelectedIndex);
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                comboBox1.SelectedIndex = Tymczas - 1;

                if (comboBox1.SelectedIndex < 0 && EnemyProfiles.Count > 0)
                    comboBox1.SelectedIndex = 0;
            }

            if (characterRadio.Checked && comboBox1.SelectedIndex >= 0)
            {
                CharacterProfiles.RemoveAt(comboBox1.SelectedIndex);
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                comboBox1.SelectedIndex = Tymczas - 1;

                if (comboBox1.SelectedIndex < 0 && CharacterProfiles.Count > 0)
                    comboBox1.SelectedIndex = 0;
            }
        }

        void LadujZPliku()
        {
            if (File.Exists("Media\\Profiles\\NPCs.xml"))
            {
                XmlDocument File1 = new XmlDocument();
                File1.Load("Media\\Profiles\\NPCs.xml");
                XmlElement root = File1.DocumentElement;
                XmlNodeList Items = root.SelectNodes("//npcs//npc");

                foreach (XmlNode item in Items)
                {
                    Character newChar = new Character();

                    newChar.ProfileName = item["ProfileName"].InnerText;
                    newChar.MeshName = item["MeshName"].InnerText;
                    newChar.DisplayName = item["DisplayName"].InnerText;
                    newChar.BodyMass = item["BodyMass"].InnerText;
                    newChar.WalkSpeed = item["WalkSpeed"].InnerText;
                    newChar.DisplayNameOffset = item["DisplayNameOffset_x"].InnerText + "|" + item["DisplayNameOffset_y"].InnerText + "|" + item["DisplayNameOffset_z"].InnerText;
                    newChar.BodyScaleFactor = item["BodyScaleFactor_x"].InnerText + "|" + item["BodyScaleFactor_y"].InnerText + "|" + item["BodyScaleFactor_z"].InnerText;
                    newChar.HeadOffset = item["HeadOffset_x"].InnerText + "|" + item["HeadOffset_y"].InnerText + "|" + item["HeadOffset_z"].InnerText;

                    CharacterProfiles.Add(newChar);
                }
            }

            if (System.IO.File.Exists("Media\\Profiles\\Enemies.xml"))
            {
                XmlDocument File2 = new XmlDocument();
                File2.Load("Media\\Profiles\\Enemies.xml");
                XmlElement root = File2.DocumentElement;
                XmlNodeList Items = root.SelectNodes("//enemies//enemy");

                foreach (XmlNode item in Items)
                {
                    Enemy newChar = new Enemy();

                    newChar.ProfileName = item["ProfileName"].InnerText;
                    newChar.MeshName = item["MeshName"].InnerText;
                    newChar.DisplayName = item["DisplayName"].InnerText;
                    newChar.BodyMass = item["BodyMass"].InnerText;
                    newChar.WalkSpeed = item["WalkSpeed"].InnerText;
                    newChar.DisplayNameOffset = item["DisplayNameOffset_x"].InnerText + "|" + item["DisplayNameOffset_y"].InnerText + "|" + item["DisplayNameOffset_z"].InnerText;
                    newChar.BodyScaleFactor = item["BodyScaleFactor_x"].InnerText + "|" + item["BodyScaleFactor_y"].InnerText + "|" + item["BodyScaleFactor_z"].InnerText;
                    newChar.HeadOffset = item["HeadOffset_x"].InnerText + "|" + item["HeadOffset_y"].InnerText + "|" + item["HeadOffset_z"].InnerText;

                    EnemyProfiles.Add(newChar);
                }
            }
        }

        void ZapiszDoPliku()
        {
            XmlTextWriter NPCs = new XmlTextWriter("Media\\Profiles\\NPCs.xml", (Encoding)null);
            NPCs.WriteStartElement("npcs");

            foreach (Character ch in CharacterProfiles)
            {
                NPCs.WriteStartElement("npc");
                NPCs.WriteElementString("ProfileName", ch.ProfileName);
                NPCs.WriteElementString("DisplayName", ch.DisplayName);
                NPCs.WriteElementString("MeshName", ch.MeshName);
                NPCs.WriteElementString("BodyMass", ch.BodyMass);
                NPCs.WriteElementString("WalkSpeed", ch.WalkSpeed);

                string x = "";
                string y = "";
                string z = "";
                int licznik = 0;

                while (ch.DisplayNameOffset[licznik] != '|')
                {
                    x += ch.DisplayNameOffset[licznik];
                    licznik++;
                }

                licznik++;

                while (ch.DisplayNameOffset[licznik] != '|')
                {
                    y += ch.DisplayNameOffset[licznik];
                    licznik++;
                }

                licznik++;

                while (licznik != ch.DisplayNameOffset.Length)
                {
                    z += ch.DisplayNameOffset[licznik];
                    licznik++;
                }

                licznik = 0;

                NPCs.WriteElementString("DisplayNameOffset_x", x);
                NPCs.WriteElementString("DisplayNameOffset_y", y);
                NPCs.WriteElementString("DisplayNameOffset_z", z);

                x = "";
                y = "";
                z = "";

                while (ch.HeadOffset[licznik] != '|')
                {
                    x += ch.HeadOffset[licznik];
                    licznik++;
                }

                licznik++;

                while (ch.HeadOffset[licznik] != '|')
                {
                    y += ch.HeadOffset[licznik];
                    licznik++;
                }

                licznik++;

                while (licznik != ch.HeadOffset.Length)
                {
                    z += ch.HeadOffset[licznik];
                    licznik++;
                }

                licznik = 0;

                NPCs.WriteElementString("HeadOffset_x", x);
                NPCs.WriteElementString("HeadOffset_y", y);
                NPCs.WriteElementString("HeadOffset_z", z);


                x = "";
                y = "";
                z = "";

                while (ch.BodyScaleFactor[licznik] != '|')
                {
                    x += ch.BodyScaleFactor[licznik];
                    licznik++;
                }

                licznik++;

                while (ch.BodyScaleFactor[licznik] != '|')
                {
                    y += ch.BodyScaleFactor[licznik];
                    licznik++;
                }

                licznik++;

                while (licznik != ch.BodyScaleFactor.Length)
                {
                    z += ch.BodyScaleFactor[licznik];
                    licznik++;
                }

                licznik = 0;

                NPCs.WriteElementString("BodyScaleFactor_x", x);
                NPCs.WriteElementString("BodyScaleFactor_y", y);
                NPCs.WriteElementString("BodyScaleFactor_z", z);
                NPCs.WriteEndElement();
            }

            NPCs.WriteEndElement();
            NPCs.Flush();
            NPCs.Close();

            XmlTextWriter Enemies = new XmlTextWriter("Media\\Profiles\\Enemies.xml", (Encoding)null);
            Enemies.WriteStartElement("enemies");

            foreach (Enemy en in EnemyProfiles)
            {
                Enemies.WriteStartElement("enemy");
                Enemies.WriteElementString("ProfileName", en.ProfileName);
                Enemies.WriteElementString("DisplayName", en.DisplayName);
                Enemies.WriteElementString("MeshName", en.MeshName);
                Enemies.WriteElementString("BodyMass", en.BodyMass);
                Enemies.WriteElementString("WalkSpeed", en.WalkSpeed);

                string x = "";
                string y = "";
                string z = "";
                int licznik = 0;

                while (en.DisplayNameOffset[licznik] != '|')
                {
                    x += en.DisplayNameOffset[licznik];
                    licznik++;
                }

                licznik++;

                while (en.DisplayNameOffset[licznik] != '|')
                {
                    y += en.DisplayNameOffset[licznik];
                    licznik++;
                }

                licznik++;

                while (en.DisplayNameOffset.Length != licznik)
                {
                    z += en.DisplayNameOffset[licznik];
                    licznik++;
                }

                licznik = 0;

                Enemies.WriteElementString("DisplayNameOffset_x", x);
                Enemies.WriteElementString("DisplayNameOffset_y", y);
                Enemies.WriteElementString("DisplayNameOffset_z", z);

                x = "";
                y = "";
                z = "";

                while (en.HeadOffset[licznik] != '|')
                {
                    x += en.HeadOffset[licznik];
                    licznik++;
                }

                licznik++;

                while (en.HeadOffset[licznik] != '|')
                {
                    y += en.HeadOffset[licznik];
                    licznik++;
                }

                licznik++;

                while (en.HeadOffset.Length != licznik)
                {
                    z += en.HeadOffset[licznik];
                    licznik++;
                }

                licznik = 0;

                Enemies.WriteElementString("HeadOffset_x", x);
                Enemies.WriteElementString("HeadOffset_y", y);
                Enemies.WriteElementString("HeadOffset_z", z);


                x = "";
                y = "";
                z = "";

                while (en.BodyScaleFactor[licznik] != '|')
                {
                    x += en.BodyScaleFactor[licznik];
                    licznik++;
                }

                licznik++;

                while (en.BodyScaleFactor[licznik] != '|')
                {
                    y += en.BodyScaleFactor[licznik];
                    licznik++;
                }

                licznik++;

                while (en.BodyScaleFactor.Length != licznik)
                {
                    z += en.BodyScaleFactor[licznik];
                    licznik++;
                }

                licznik = 0;

                Enemies.WriteElementString("BodyScaleFactor_x", x);
                Enemies.WriteElementString("BodyScaleFactor_y", y);
                Enemies.WriteElementString("BodyScaleFactor_z", z);
                Enemies.WriteEndElement();
            }

            Enemies.WriteEndElement();
            Enemies.Flush();
            Enemies.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            ZapiszDoPliku();
        }

        private void characterRadio_CheckedChanged(object sender, EventArgs e)
        {
            LadujZListy(true);
            UpdateView();
        }

        private void enemyRadio_CheckedChanged(object sender, EventArgs e)
        {
            LadujZListy(false);
            UpdateView();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void iCreateNewButton_Click(object sender, EventArgs e)
        {
            ItemProfiles.Add(new ItemProfile());
            comboBox2.Items.Add(ItemProfiles[ItemProfiles.Count - 1].IdString);
            comboBox2.SelectedIndex = ItemProfiles.Count - 1;
            UpdateView();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void describedRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex >= 0 && describedRadio.Checked)
            {
                ItemProfiles[comboBox2.SelectedIndex].Type = "DescribedProfile";
            }
        }

        private void itemSwordRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex >= 0 && itemSwordRadio.Checked)
            {
                ItemProfiles[comboBox2.SelectedIndex].Type = "ItemSword";
            }
        }

        private void idString_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex >= 0)
            {
                ItemProfiles[comboBox2.SelectedIndex].IdString = idString.Text;
                comboBox2.Items[comboBox2.SelectedIndex] = idString.Text;
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex >= 0)
            {
                ItemProfiles[comboBox2.SelectedIndex].Name = name.Text;
            }
        }

        private void description_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex >= 0)
            {
                ItemProfiles[comboBox2.SelectedIndex].Description = description.Text;
            }
        }

        private void mesh_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex >= 0)
            {
                ItemProfiles[comboBox2.SelectedIndex].Mesh = mesh.Text;
            }
        }

        private void inventoryMaterial_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex >= 0)
            {
                ItemProfiles[comboBox2.SelectedIndex].InventoryMaterial = inventoryMaterial.Text;
            }
        }

        private void mass_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex >= 0)
            {
                ItemProfiles[comboBox2.SelectedIndex].Mass = mass.Text;
            }
        }

        private void nameOffset_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex >= 0)
            {
                ItemProfiles[comboBox2.SelectedIndex].NameOffset = nameOffset.Text;
            }
        }

        private void Pickable_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex >= 0)
            {
                if (Pickable.Checked)
                    ItemProfiles[comboBox2.SelectedIndex].IsPickable = "true";
                else
                    ItemProfiles[comboBox2.SelectedIndex].IsPickable = "false";
            }
        }

        private void Equipment_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex >= 0)
            {
                if (Equipment.Checked)
                    ItemProfiles[comboBox2.SelectedIndex].IsEquipment = "true";
                else
                    ItemProfiles[comboBox2.SelectedIndex].IsEquipment = "false";
            }
        }

        private void iDeleteButton_Click(object sender, EventArgs e)
        {
            int Tymczas = comboBox2.SelectedIndex;
            if (comboBox2.SelectedIndex >= 0)
            {
                ItemProfiles.RemoveAt(comboBox2.SelectedIndex);
                comboBox2.Items.RemoveAt(comboBox2.SelectedIndex);
                comboBox2.SelectedIndex = Tymczas - 1;

                if (comboBox2.SelectedIndex < 0 && ItemProfiles.Count > 0)
                    comboBox2.SelectedIndex = 0;
            }
        }

        private void iSaveButton_Click(object sender, EventArgs e)
        {
            ZapiszItemyDoPliku();
            MessageBox.Show("Itemy zapisane.", "Zapisywanie");
        }

        void ZapiszItemyDoPliku()
        {
            XmlTextWriter Items = new XmlTextWriter("Media\\Profiles\\Items.xml", (Encoding)null);
            Items.WriteStartElement("items");

            foreach (ItemProfile ip in ItemProfiles)
            {
                Items.WriteStartElement("item");
                Items.WriteElementString("idstring", ip.IdString);
                Items.WriteElementString("name", ip.Name);
                Items.WriteElementString("mesh", ip.Mesh);
                Items.WriteElementString("type", ip.Type);
                Items.WriteElementString("description", ip.Description);
                Items.WriteElementString("inventory_material", ip.InventoryMaterial);
                Items.WriteElementString("mass", ip.Mass);
                Items.WriteElementString("ispickable", ip.IsPickable);
                Items.WriteElementString("isequipment", ip.IsEquipment);

                string x = "";
                string y = "";
                string z = "";
                int licznik = 0;

                while (ip.NameOffset[licznik] != '|')
                {
                    x += ip.NameOffset[licznik];
                    licznik++;
                }

                licznik++;

                while (ip.NameOffset[licznik] != '|')
                {
                    y += ip.NameOffset[licznik];
                    licznik++;
                }

                licznik++;

                while (ip.NameOffset.Length != licznik)
                {
                    z += ip.NameOffset[licznik];
                    licznik++;
                }

                licznik = 0;

                Items.WriteElementString("nameoffsetx", x);
                Items.WriteElementString("nameoffsety", y);
                Items.WriteElementString("nameoffsetz", z);
                Items.WriteEndElement();
            }

            Items.WriteEndElement();
            Items.Flush();
            Items.Close();
        }

        void LadujItemyZPliku()
        {
            if (File.Exists("Media\\Profiles\\Items.xml"))
            {
                XmlDocument File1 = new XmlDocument();
                File1.Load("Media\\Profiles\\Items.xml");
                XmlElement root = File1.DocumentElement;
                XmlNodeList Items = root.SelectNodes("//items//item");

                foreach (XmlNode item in Items)
                {
                    ItemProfile newChar = new ItemProfile();

                    newChar.IdString = item["idstring"].InnerText;
                    newChar.Mesh = item["mesh"].InnerText;
                    newChar.Name = item["name"].InnerText;
                    newChar.Mass = item["mass"].InnerText;
                    newChar.NameOffset = item["nameoffsetx"].InnerText + "|" + item["nameoffsety"].InnerText + "|" + item["nameoffsetz"].InnerText;
                    newChar.Type = item["type"].InnerText;
                    newChar.Description = item["description"].InnerText;
                    newChar.InventoryMaterial = item["inventory_material"].InnerText;
                    newChar.IsPickable = item["ispickable"].InnerText;
                    newChar.IsEquipment = item["isequipment"].InnerText;

                    ItemProfiles.Add(newChar);
                    comboBox2.Items.Add(newChar.IdString);
                }
            }
        }
    }
}
