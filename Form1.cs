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
        List<Prize> Prizes;
        List<Dialog> Dialogs;

        public Form1()
        {
            EnemyProfiles = new List<Enemy>();
            CharacterProfiles = new List<Character>();
            ItemProfiles = new List<ItemProfile>();
            Prizes = new List<Prize>();
            Dialogs = new List<Dialog>();

            InitializeComponent();

            comboBox5.Items.Add("NEUTRAL");
            comboBox5.Items.Add("FRIENDLY");
            comboBox5.Items.Add("ENEMY");
            comboBox5.SelectedIndex = 0;

            actionBox.Items.Add("MakeQuestFinished");
            actionBox.Items.Add("MakeFirstFalse");
            actionBox.Items.Add("MakeFirstTrue");
            actionBox.Items.Add("MakeEdgeTrue");
            actionBox.Items.Add("MakeEdgeFalse");
            actionBox.Items.Add("GiveQuest");
            actionBox.Items.Add("ActivateActivator");
            actionBox.SelectedIndex = 0;

            LadujZPliku();
            LadujItemyZPliku();
            LadujPrize();
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
                    zasiegOgl.Enabled = false;
                    zasiegWzr.Enabled = false;
                    walkaWrecz.Text = CharacterProfiles[comboBox1.SelectedIndex].WW;
                    zrecznosc.Text = CharacterProfiles[comboBox1.SelectedIndex].ZR;
                    opanowanie.Text = CharacterProfiles[comboBox1.SelectedIndex].OP;
                    zywotnosc.Text = CharacterProfiles[comboBox1.SelectedIndex].ZY;
                    charyzma.Text = CharacterProfiles[comboBox1.SelectedIndex].CH;
                    Sila.Text = CharacterProfiles[comboBox1.SelectedIndex].SI;
                    wytrzymalosc.Text = CharacterProfiles[comboBox1.SelectedIndex].WY;
                    comboBox5.SelectedIndex = int.Parse(CharacterProfiles[comboBox1.SelectedIndex].FriendlyType);
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
                    zasiegOgl.Enabled = true;
                    zasiegWzr.Enabled = true;
                    zasiegOgl.Text = EnemyProfiles[comboBox1.SelectedIndex].ZasiegOgolny;
                    zasiegWzr.Text = EnemyProfiles[comboBox1.SelectedIndex].ZasiegWzroku;
                    walkaWrecz.Text = EnemyProfiles[comboBox1.SelectedIndex].WW;
                    zrecznosc.Text = EnemyProfiles[comboBox1.SelectedIndex].ZR;
                    opanowanie.Text = EnemyProfiles[comboBox1.SelectedIndex].OP;
                    zywotnosc.Text = EnemyProfiles[comboBox1.SelectedIndex].ZY;
                    charyzma.Text = EnemyProfiles[comboBox1.SelectedIndex].CH;
                    Sila.Text = EnemyProfiles[comboBox1.SelectedIndex].SI;
                    wytrzymalosc.Text = EnemyProfiles[comboBox1.SelectedIndex].WY;
                    comboBox5.SelectedIndex = int.Parse(EnemyProfiles[comboBox1.SelectedIndex].FriendlyType);
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

            if (comboBox4.SelectedIndex >= 0)
            {
                PrizeID.Text = Prizes[comboBox4.SelectedIndex].PrizeID;
                PrizeGold.Text = Prizes[comboBox4.SelectedIndex].Gold;
                PrizeExp.Text = Prizes[comboBox4.SelectedIndex].EXP;

                while (listaItemow.Items.Count > 0)
                    listaItemow.Items.RemoveAt(0);

                foreach (String str in Prizes[comboBox4.SelectedIndex].Itemy)
                    listaItemow.Items.Add(str);

                while (comboBox3.Items.Count > 0)
                    comboBox3.Items.RemoveAt(0);

                foreach (ItemProfile ip in ItemProfiles)
                    comboBox3.Items.Add(ip.IdString);

                comboBox3.SelectedIndex = 0;
            }

            else
            {
                PrizeID.Text = "";
                PrizeGold.Text = "";
                PrizeExp.Text = "";

                while (listaItemow.Items.Count > 0)
                    listaItemow.Items.RemoveAt(0);

                while (comboBox3.Items.Count > 0)
                    comboBox3.Items.RemoveAt(0);
            }

            if (dialogBox.SelectedIndex >= 0)
            {
                dialogID.Enabled = true;
                reactionsBox.Enabled = true;
                reactionID.Enabled = true;
                connectedEdgesBox.Enabled = true;
                connectedNodeBox.Enabled = true;
                edgeID.Enabled = true;
                FirstTalk.Enabled = true;
                GotQuest.Enabled = true;
                IsQuestDone.Enabled = true;
                IsQuestFinished.Enabled = true;
                questIDBox.Enabled = true;
                nodeBox.Enabled = true;
                nodeID.Enabled = true;
                nodeText.Enabled = true;
                nodeActionsBox.Enabled = true;
                actionBox.Enabled = true;
                actionQuest.Enabled = true;
                actionEdge.Enabled = true;
                nReplyBox.Enabled = true;
                nodeRepliesBox.Enabled = true;
                replyBox.Enabled = true;
                replyID.Enabled = true;
                replyText.Enabled = true;
                replyIsEnding.Enabled = true;
                rReactionsBox.Enabled = true;
                createReaction.Enabled = true;
                deleteReaction.Enabled = true;
                createEdge.Enabled = true;
                deleteEdge.Enabled = true;
                createNode.Enabled = true;
                deleteNode.Enabled = true;
                addAction.Enabled = true;
                deleteAction.Enabled = true;
                addReply.Enabled = true;
                nDeleteReply.Enabled = true;
                deleteReply.Enabled = true;
                createReply.Enabled = true;
                deleteReply.Enabled = true;
                saveDialogs.Enabled = true;
                deleteDialog.Enabled = true;

                dialogID.Text = Dialogs[dialogBox.SelectedIndex].ID;
                reactionsBox.Items.Clear();

                foreach (TalkReaction r in Dialogs[dialogBox.SelectedIndex].Reactions)
                    reactionsBox.Items.Add(r.ID);

                if (Dialogs[dialogBox.SelectedIndex].Reactions.Count > 0)
                    reactionsBox.SelectedIndex = 0;

                if (reactionsBox.SelectedIndex >= 0)
                {
                    reactionID.Text = Dialogs[dialogBox.SelectedIndex].Reactions[reactionsBox.SelectedIndex].ID;
                    connectedEdgesBox.Items.Clear();
                    foreach (String e in Dialogs[dialogBox.SelectedIndex].Reactions[reactionsBox.SelectedIndex].Edges)
                        connectedEdgesBox.Items.Add(e);

                    if (Dialogs[dialogBox.SelectedIndex].Reactions[reactionsBox.SelectedIndex].Edges.Count > 0)
                        connectedEdgesBox.SelectedIndex = 0;

                    connectedNodeBox.Items.Clear();
                    foreach (TalkNode n in Dialogs[dialogBox.SelectedIndex].Nodes)
                        connectedNodeBox.Items.Add(n.ID);

                    if (Dialogs[dialogBox.SelectedIndex].Nodes.Count > 0)
                        connectedNodeBox.SelectedIndex = connectedNodeBox.Items.IndexOf(Dialogs[dialogBox.SelectedIndex].Reactions[reactionsBox.SelectedIndex].Edges[connectedEdgesBox.SelectedIndex]);

                    if (connectedEdgesBox.SelectedIndex > 0)
                    {
                        edgeID.Text = Dialogs[dialogBox.SelectedIndex].Reactions[reactionsBox.SelectedIndex].Edges[connectedEdgesBox.SelectedIndex];
                        FirstTalk.Checked = Dialogs[dialogBox.SelectedIndex].Edges[IndexOfEdgeWithID((String)connectedEdgesBox.SelectedItem)].FirstTalk;
                        GotQuest.Checked = Dialogs[dialogBox.SelectedIndex].Edges[IndexOfEdgeWithID((String)connectedEdgesBox.SelectedItem)].GotQuest;
                        IsQuestDone.Checked = Dialogs[dialogBox.SelectedIndex].Edges[IndexOfEdgeWithID((String)connectedEdgesBox.SelectedItem)].IsQuestDone;
                        IsQuestFinished.Checked = Dialogs[dialogBox.SelectedIndex].Edges[IndexOfEdgeWithID((String)connectedEdgesBox.SelectedItem)].IsQuestFinished;

                        questIDBox.Items.Clear();
                        questIDBox.Items.Add("");
                        questIDBox.Items.Add("pierwszy");
                        questIDBox.SelectedIndex = 0;
                    }
                    else
                    {
                        edgeID.Text = "";
                        FirstTalk.Checked = false;
                        GotQuest.Checked = false;
                        IsQuestDone.Checked = false;
                        IsQuestFinished.Checked = false;
                        questIDBox.Items.Clear();
                    }
                }

                else
                {
                    reactionID.Text = "";
                    connectedEdgesBox.Items.Clear();
                    connectedNodeBox.Items.Clear();
                    edgeID.Text = "";
                    FirstTalk.Checked = false;
                    GotQuest.Checked = false;
                    IsQuestDone.Checked = false;
                    IsQuestFinished.Checked = false;
                    questIDBox.Items.Clear();
                }


                nodeBox.Items.Clear();
                foreach (TalkNode n in Dialogs[dialogBox.SelectedIndex].Nodes)
                    nodeBox.Items.Add(n.ID);

                if (nodeBox.Items.Count > 0)
                    nodeBox.SelectedIndex = 0;

                if (nodeBox.SelectedIndex >= 0)
                {
                    nodeID.Text = (String)nodeBox.Items[0];
                    nodeText.Text = Dialogs[dialogBox.SelectedIndex].Nodes[nodeBox.SelectedIndex].Text;

                    nodeActionsBox.Items.Clear();
                    foreach (int i in Dialogs[dialogBox.SelectedIndex].Nodes[nodeBox.SelectedIndex].Actions)
                        nodeActionsBox.Items.Add(actionBox.Items[i]);

                    if (nodeActionsBox.Items.Count > 0)
                        nodeActionsBox.SelectedIndex = 0;

                    actionQuest.Items.Clear();
                    actionQuest.Items.Add("");
                    actionQuest.Items.Add("pierwszy");
                    actionQuest.SelectedIndex = 0;

                    actionEdge.Items.Clear();
                    actionEdge.Items.Add("");
                    foreach(TalkEdge e in Dialogs[dialogBox.SelectedIndex].Edges)
                        actionEdge.Items.Add(e.ID);// + "(" + Dialogs[dialogBox.SelectedIndex].ID + ")");

                    /*foreach(Dialog d in Dialogs)
                    {
                        if (d.ID != Dialogs[dialogBox.SelectedIndex].ID)
                            foreach (TalkEdge e in Dialogs[dialogBox.SelectedIndex].Edges)
                                actionEdge.Items.Add(e.ID + "(" + Dialogs[dialogBox.SelectedIndex].ID + ")");
                    }*/

                    actionEdge.SelectedIndex = actionEdge.Items.IndexOf(Dialogs[dialogBox.SelectedIndex].Nodes[nodeBox.SelectedIndex].ActionEdge);

                    nReplyBox.Items.Clear();
                    foreach (TalkReply r in Dialogs[dialogBox.SelectedIndex].Replies)
                        nReplyBox.Items.Add(r.ID);

                    if (nReplyBox.Items.Count > 0)
                        nReplyBox.SelectedIndex = 0;

                    nodeRepliesBox.Items.Clear();
                    foreach (String s in Dialogs[dialogBox.SelectedIndex].Nodes[nodeBox.SelectedIndex].Replies)
                        nodeRepliesBox.Items.Add(s);

                    if (nodeRepliesBox.Items.Count > 0)
                        nodeRepliesBox.SelectedIndex = 0;
                }

                else
                {
                }

                replyBox.Items.Clear();
                foreach (TalkReply r in Dialogs[dialogBox.SelectedIndex].Replies)
                    replyBox.Items.Add(r.ID);

                if (replyBox.Items.Count > 0)
                    replyBox.SelectedIndex = 0;

                if (replyBox.SelectedIndex >= 0)
                {
                    replyID.Text = Dialogs[dialogBox.SelectedIndex].Replies[replyBox.SelectedIndex].ID;
                    replyText.Text = Dialogs[dialogBox.SelectedIndex].Replies[replyBox.SelectedIndex].Text;
                    replyIsEnding.Checked = Dialogs[dialogBox.SelectedIndex].Replies[replyBox.SelectedIndex].isEnding;

                    rReactionsBox.Items.Clear();
                    rReactionsBox.Enabled = replyIsEnding.Checked;
                    foreach (TalkReaction r in Dialogs[dialogBox.SelectedIndex].Reactions)
                        rReactionsBox.Items.Add(r.ID);

                    if (rReactionsBox.Items.Count > 0)
                        rReactionsBox.SelectedIndex = rReactionsBox.Items.IndexOf(Dialogs[dialogBox.SelectedIndex].Replies[replyBox.SelectedIndex].ReactionID);
                }

                else
                {
                    replyID.Text = "";
                    replyText.Text = "";
                    replyIsEnding.Checked = false;
                    rReactionsBox.Items.Clear();
                    rReactionsBox.Enabled = true;
                }
            }

            else
            {
                dialogID.Enabled = false;
                reactionsBox.Enabled = false;
                reactionID.Enabled = false;
                connectedEdgesBox.Enabled = false;
                connectedNodeBox.Enabled = false;
                edgeID.Enabled = false;
                FirstTalk.Enabled = false;
                GotQuest.Enabled = false;
                IsQuestDone.Enabled = false;
                IsQuestFinished.Enabled = false;
                questIDBox.Enabled = false;
                nodeBox.Enabled = false;
                nodeID.Enabled = false;
                nodeText.Enabled = false;
                nodeActionsBox.Enabled = false;
                actionBox.Enabled = false;
                actionQuest.Enabled = false;
                actionEdge.Enabled = false;
                nReplyBox.Enabled = false;
                nodeRepliesBox.Enabled = false;
                replyBox.Enabled = false;
                replyID.Enabled = false;
                replyText.Enabled = false;
                replyIsEnding.Enabled = false;
                rReactionsBox.Enabled = false;
                createReaction.Enabled = false;
                deleteReaction.Enabled = false;
                createEdge.Enabled = false;
                deleteEdge.Enabled = false;
                createNode.Enabled = false;
                deleteNode.Enabled = false;
                addAction.Enabled = false;
                deleteAction.Enabled = false;
                addReply.Enabled = false;
                nDeleteReply.Enabled = false;
                deleteReply.Enabled = false;
                createReply.Enabled = false;
                deleteReply.Enabled = false;
                saveDialogs.Enabled = false;
                deleteDialog.Enabled = false;
            }
        }

        public int IndexOfEdgeWithID(String ID)
        {
            int ret = 0;

            for (int i = 0; i < Dialogs[dialogBox.SelectedIndex].Edges.Count; i++)
                if (Dialogs[dialogBox.SelectedIndex].Edges[i].ID == ID)
                    ret = i;
            return ret;
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
            int counter = 0;
			
			if (characterRadio.Checked && comboBox1.SelectedIndex >= 0)
            {
                CharacterProfiles[comboBox1.SelectedIndex].ProfileName = profileName.Text;
                comboBox1.Items[comboBox1.SelectedIndex] = profileName.Text;

				foreach (Character ip in CharacterProfiles)
					if (ip.ProfileName == profileName.Text)
						counter++;
            }

            if (enemyRadio.Checked && comboBox1.SelectedIndex >= 0)
            {
                EnemyProfiles[comboBox1.SelectedIndex].ProfileName = profileName.Text;
                comboBox1.Items[comboBox1.SelectedIndex] = profileName.Text;

				foreach (Enemy ip in EnemyProfiles)
					if (ip.ProfileName == profileName.Text)
						counter++;
            }

			if (counter == 1)
				profileName.BackColor = Color.White;
			else
				profileName.BackColor = Color.Red;

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
                    newChar.WW = item["WalkaWrecz"].InnerText;
                    newChar.SI = item["Sila"].InnerText;
                    newChar.FriendlyType = item["FriendlyType"].InnerText;
                    newChar.CH = item["Charyzma"].InnerText;
                    newChar.ZR = item["Zrecznosc"].InnerText;
                    newChar.ZY = item["Zywotnosc"].InnerText;
                    newChar.OP = item["Opanowanie"].InnerText;
                    newChar.WY = item["Wytrzymalosc"].InnerText;

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
                    newChar.WW = item["WalkaWrecz"].InnerText;
                    newChar.SI = item["Sila"].InnerText;
                    newChar.FriendlyType = item["FriendlyType"].InnerText;
                    newChar.CH = item["Charyzma"].InnerText;
                    newChar.ZR = item["Zrecznosc"].InnerText;
                    newChar.ZY = item["Zywotnosc"].InnerText;
                    newChar.OP = item["Opanowanie"].InnerText;
                    newChar.WY = item["Wytrzymalosc"].InnerText;
                    newChar.ZasiegOgolny = item["ZasiegOgolny"].InnerText;
                    newChar.ZasiegWzroku = item["ZasiegWzroku"].InnerText;

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

                NPCs.WriteElementString("FriendlyType", ch.FriendlyType);
                NPCs.WriteElementString("WalkaWrecz", ch.WW);
                NPCs.WriteElementString("Zywotnosc", ch.ZY);
                NPCs.WriteElementString("Opanowanie", ch.OP);
                NPCs.WriteElementString("Wytrzymalosc", ch.WY);
                NPCs.WriteElementString("Zrecznosc", ch.ZR);
                NPCs.WriteElementString("Sila", ch.SI);
                NPCs.WriteElementString("Charyzma", ch.CH);

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

                Enemies.WriteElementString("FriendlyType", en.FriendlyType);
                Enemies.WriteElementString("WalkaWrecz", en.WW);
                Enemies.WriteElementString("Zywotnosc", en.ZY);
                Enemies.WriteElementString("Opanowanie", en.OP);
                Enemies.WriteElementString("Wytrzymalosc", en.WY);
                Enemies.WriteElementString("Zrecznosc", en.ZR);
                Enemies.WriteElementString("Sila", en.SI);
                Enemies.WriteElementString("Charyzma", en.CH);
                Enemies.WriteElementString("ZasiegWzroku", en.ZasiegWzroku);
                Enemies.WriteElementString("ZasiegOgolny", en.ZasiegOgolny);

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
				
				int counter = 0;

				foreach (ItemProfile ip in ItemProfiles)
					if (ip.IdString == idString.Text)
						counter++;

				if (counter == 1)
					idString.BackColor = Color.White;
				else
					idString.BackColor = Color.Red;
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

        private void AddNewPrize_Click(object sender, EventArgs e)
        {
            Prizes.Add(new Prize());
            comboBox4.Items.Add(Prizes[Prizes.Count - 1].PrizeID);
            comboBox4.SelectedIndex = Prizes.Count - 1;
            UpdateView();            
        }

        private void PrizeID_TextChanged(object sender, EventArgs e)
        {
			if (comboBox4.SelectedIndex >= 0)
			{
				int counter = 0;
				Prizes[comboBox4.SelectedIndex].PrizeID = PrizeID.Text;
				comboBox4.Items[comboBox4.SelectedIndex] = PrizeID.Text;

				foreach (Prize ip in Prizes)
					if (ip.PrizeID == PrizeID.Text)
						counter++;


				if (counter == 1)
					PrizeID.BackColor = Color.White;
				else
					PrizeID.BackColor = Color.Red;
			}
            
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex >= 0 && comboBox3.SelectedIndex >= 0)
            {
				if (ItemProfiles[comboBox3.SelectedIndex].IsPickable == "true")
				{
					listaItemow.Items.Add(comboBox3.Items[comboBox3.SelectedIndex]);
					Prizes[comboBox4.SelectedIndex].Itemy.Add(ItemProfiles[comboBox3.SelectedIndex].IdString);
				}
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void UsunWybranyItemButton_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex >= 0 && listaItemow.SelectedIndex >= 0)
            {
                int Tymczas = listaItemow.SelectedIndex;
                listaItemow.Items.RemoveAt(listaItemow.SelectedIndex);

                if (listaItemow.Items.Count > 0)
                {
                    if (Tymczas > 0)
                        listaItemow.SelectedIndex = Tymczas - 1;
                    else
                        listaItemow.SelectedIndex = Tymczas;
                }
                
            }
        }

        private void PrizeGold_TextChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex >= 0)
                Prizes[comboBox4.SelectedIndex].Gold = PrizeGold.Text;
        }

        private void PrizeExp_TextChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex >= 0)
                Prizes[comboBox4.SelectedIndex].EXP = PrizeExp.Text;
        }

        private void DeletePrizeButton_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex >= 0)
            {
                int Tymczas = comboBox4.SelectedIndex;

                Prizes.RemoveAt(comboBox4.SelectedIndex);
                comboBox4.Items.RemoveAt(comboBox4.SelectedIndex);

                if (comboBox4.Items.Count > 0)
                {
                    if (Tymczas > 0)
                        comboBox4.SelectedIndex = Tymczas - 1;
                    else
                        comboBox4.SelectedIndex = Tymczas;
                }
            }
        }

        private void SavePrizeButton_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex >= 0)
            {
                ZapiszPrize();

                MessageBox.Show("Zapisano wszystkie prizy.", "Zapisywanie");
            }
        }

        public void ZapiszPrize()
        {
            XmlTextWriter Items = new XmlTextWriter("Media\\Profiles\\Prizes.xml", (Encoding)null);
            Items.WriteStartElement("prizes");

            foreach (Prize pr in Prizes)
            {
                Items.WriteStartElement("prize");
                Items.WriteElementString("PrizeID", pr.PrizeID);
                Items.WriteElementString("Exp", pr.EXP);
                Items.WriteElementString("Gold", pr.Gold);
                Items.WriteStartElement("items");

                foreach (String str in pr.Itemy)
                {
                    Items.WriteStartElement("item");
                    Items.WriteElementString("idstring", str);
                    Items.WriteEndElement();
                }

                Items.WriteEndElement();
                Items.WriteEndElement();
            }

            Items.WriteEndElement();
            Items.Flush();
            Items.Close();
        }

        public void LadujPrize()
        {
            if (File.Exists("Media\\Profiles\\Prizes.xml"))
            {
                XmlDocument File1 = new XmlDocument();
                File1.Load("Media\\Profiles\\Prizes.xml");
                XmlElement root = File1.DocumentElement;
                XmlNodeList Items = root.SelectNodes("//prizes//prize");

                foreach (XmlNode item in Items)
                {
                    Prize newChar = new Prize();

                    newChar.PrizeID = item["PrizeID"].InnerText;
                    newChar.EXP = item["Exp"].InnerText;
                    newChar.Gold = item["Gold"].InnerText;

                    XmlNodeList Itemy = item["items"].ChildNodes;

                    foreach (XmlNode it in Itemy)
                    {
                        newChar.Itemy.Add(it["idstring"].InnerText);
                    }

                    Prizes.Add(newChar);
                    comboBox4.Items.Add(newChar.PrizeID);
                }
            }
        }

        private void walkaWrecz_TextChanged(object sender, EventArgs e)
        {
            if (characterRadio.Checked && comboBox1.SelectedIndex >= 0)
                CharacterProfiles[comboBox1.SelectedIndex].WW = walkaWrecz.Text;

            if (enemyRadio.Checked && comboBox1.SelectedIndex >= 0)
                EnemyProfiles[comboBox1.SelectedIndex].WW = walkaWrecz.Text;
        }

        private void Sila_TextChanged(object sender, EventArgs e)
        {
            if (characterRadio.Checked && comboBox1.SelectedIndex >= 0)
                CharacterProfiles[comboBox1.SelectedIndex].SI = Sila.Text;

            if (enemyRadio.Checked && comboBox1.SelectedIndex >= 0)
                EnemyProfiles[comboBox1.SelectedIndex].SI = Sila.Text;
        }

        private void zrecznosc_TextChanged(object sender, EventArgs e)
        {
            if (characterRadio.Checked && comboBox1.SelectedIndex >= 0)
                CharacterProfiles[comboBox1.SelectedIndex].ZR = zrecznosc.Text;

            if (enemyRadio.Checked && comboBox1.SelectedIndex >= 0)
                EnemyProfiles[comboBox1.SelectedIndex].ZR = zrecznosc.Text;
        }

        private void zywotnosc_TextChanged(object sender, EventArgs e)
        {
            if (characterRadio.Checked && comboBox1.SelectedIndex >= 0)
                CharacterProfiles[comboBox1.SelectedIndex].ZY = zywotnosc.Text;

            if (enemyRadio.Checked && comboBox1.SelectedIndex >= 0)
                EnemyProfiles[comboBox1.SelectedIndex].ZY = zywotnosc.Text;
        }

        private void wytrzymalosc_TextChanged(object sender, EventArgs e)
        {
            if (characterRadio.Checked && comboBox1.SelectedIndex >= 0)
                CharacterProfiles[comboBox1.SelectedIndex].WY = wytrzymalosc.Text;

            if (enemyRadio.Checked && comboBox1.SelectedIndex >= 0)
                EnemyProfiles[comboBox1.SelectedIndex].WY = wytrzymalosc.Text;
        }

        private void opanowanie_TextChanged(object sender, EventArgs e)
        {
            if (characterRadio.Checked && comboBox1.SelectedIndex >= 0)
                CharacterProfiles[comboBox1.SelectedIndex].OP = opanowanie.Text;

            if (enemyRadio.Checked && comboBox1.SelectedIndex >= 0)
                EnemyProfiles[comboBox1.SelectedIndex].OP = opanowanie.Text;
        }

        private void charyzma_TextChanged(object sender, EventArgs e)
        {
            if (characterRadio.Checked && comboBox1.SelectedIndex >= 0)
                CharacterProfiles[comboBox1.SelectedIndex].CH = charyzma.Text;

            if (enemyRadio.Checked && comboBox1.SelectedIndex >= 0)
                EnemyProfiles[comboBox1.SelectedIndex].CH = charyzma.Text;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (characterRadio.Checked && comboBox1.SelectedIndex >= 0)
                CharacterProfiles[comboBox1.SelectedIndex].FriendlyType = comboBox5.SelectedIndex.ToString();

            if (enemyRadio.Checked && comboBox1.SelectedIndex >= 0)
                EnemyProfiles[comboBox1.SelectedIndex].FriendlyType = comboBox5.SelectedIndex.ToString();
        }

        private void zasiegWzr_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
                EnemyProfiles[comboBox1.SelectedIndex].ZasiegWzroku = zasiegWzr.Text;
        }

        private void zasiegOgl_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
                EnemyProfiles[comboBox1.SelectedIndex].ZasiegOgolny = zasiegOgl.Text;
        }

        private void createDialog_Click(object sender, EventArgs e)
        {
            Dialogs.Add(new Dialog());
            dialogBox.Items.Add(Dialogs[Dialogs.Count - 1].ID);
            dialogBox.SelectedIndex = Dialogs.Count - 1;
            UpdateView();
        }

        private void deleteDialog_Click(object sender, EventArgs e)
        {
            Dialogs.RemoveAt(dialogBox.SelectedIndex);
            int tym = dialogBox.SelectedIndex;
            dialogBox.Items.RemoveAt(dialogBox.SelectedIndex);

            if (tym == 0 && dialogBox.Items.Count > 0)
                dialogBox.SelectedIndex = 0;
            else
                dialogBox.SelectedIndex = tym - 1;

            UpdateView();
        }

        private void dialogID_TextChanged(object sender, EventArgs e)
        {
            Dialogs[dialogBox.SelectedIndex].ID = dialogID.Text;
            dialogBox.Items[dialogBox.SelectedIndex] = dialogID.Text;
            UpdateView();
        }

        private void dialogBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void reactionsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void createReaction_Click(object sender, EventArgs e)
        {
            Dialogs[dialogBox.SelectedIndex].Reactions.Add(new TalkReaction());
            UpdateView();
        }

        private void deleteReaction_Click(object sender, EventArgs e)
        {
            Dialogs[dialogBox.SelectedIndex].Reactions.RemoveAt(reactionsBox.SelectedIndex);
            int tym = reactionsBox.SelectedIndex;
            reactionsBox.Items.RemoveAt(reactionsBox.SelectedIndex);

            if (tym == 0 && reactionsBox.Items.Count > 0)
                reactionsBox.SelectedIndex = 0;
            else
                reactionsBox.SelectedIndex = tym - 1;

            UpdateView();
        }

        private void reactionID_TextChanged(object sender, EventArgs e)
        {
            Dialogs[dialogBox.SelectedIndex].Reactions[reactionsBox.SelectedIndex].ID = reactionID.Text;
            reactionsBox.Items[reactionsBox.SelectedIndex] = reactionID.Text;
        }
    }
}
