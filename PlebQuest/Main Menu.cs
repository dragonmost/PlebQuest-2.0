using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlebServer;

namespace PlebQuest
{
    public partial class Form1 : Form
    {
        NameGenerator nameGenerator;

        private GameCreation gameCreation;

        public Form1()
        {
            InitializeComponent();
            this.pnlCharacterCreation.Visible = false;
            //this.pnlGame.Visible = false;
            this.CreateGamePanels();
            this.RefreshQuest(null, null, "Fetch 3 left goblin ears from the same goblin"); 
        }

        private void butNew_Click(object sender, EventArgs e)
        {
            this.LoadCreationScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            //pleb = new Pleb(this.txtCreationName.Text, butCreationMale.Checked, stats, this.cheated);
        }

        private void butJoin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtMenuUsername.Text)
                || string.IsNullOrWhiteSpace(this.txtMenuPassword.Text))
            {
                MessageBox.Show("Username and Password can't be empty");
                return;
            }

            string[] data = new string[] { Commands.PlayerConnection, txtMenuUsername.Text, Utils.sha256_hash(txtMenuPassword.Text) };
            //Client.Instance.SendDataWithResponse(data);
        }

        private void butPlay_Click(object sender, EventArgs e)
        {

        }

        private void butCreate_Click(object sender, EventArgs e)
        {
            frmAccountCreation frm = new frmAccountCreation();
            frm.ShowDialog();
        }

        private void butCancelCreation_Click(object sender, EventArgs e)
        {
            this.pnlCharacterCreation.Visible = false;
        }

        private void butRoll_Click(object sender, EventArgs e)
        {
            gameCreation.Randomize();

            this.txtCreationTotalStats.Text = gameCreation.TotalStats.ToString();
        }

        private Queue<Keys> keySequence = new Queue<Keys>();
        private bool cheated = false;

        private void txtCreationTotalStats_KeyDown(object sender, KeyEventArgs e)
        {
            keySequence.Enqueue(e.KeyCode);

            if (keySequence.Count > Cheat.Konami.Count)
                keySequence.Dequeue();

            if (keySequence.SequenceEqual(Cheat.Konami))
            {
                gameCreation.MakePerfect();

                this.txtCreationTotalStats.Text = gameCreation.TotalStats.ToString();
                this.cheated = true;
            }

        }

        private void txtCreationTotalStats_Leave(object sender, EventArgs e)
        {
            keySequence = new Queue<Keys>();
        }

        private void butGenerate_Click(object sender, EventArgs e)
        {
            this.txtCreationName.Text = nameGenerator.BuildName();
        }

        private void SetControlState(object sender, EventArgs e)
        {
            this.butCreationStart.Enabled = !string.IsNullOrWhiteSpace(this.txtCreationName.Text)
                && this.lstCreationRace.SelectedIndex != -1 && this.lstCreationClass.SelectedIndex != -1;
        }

        private void LoadCreationScreen()
        {
            this.nameGenerator = new NameGenerator();
            this.gameCreation = new GameCreation();
            Stats stats = gameCreation.Stats;

            PropertyInfo[] properties = stats.GetType().GetProperties();

            foreach (PropertyInfo property in properties)
            {
                ListViewItem item = new ListViewItem(property.Name);
                item.Name = property.Name;
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
                item.SubItems[1].Text = property.GetValue(stats).ToString();
                lstCreationStat.Items.Add(item);
            }

            this.txtCreationTotalStats.Text = gameCreation.TotalStats.ToString();

            Task.Run(() =>
            {
                Race[] races = gameCreation.Races;
                Classe[] classes = gameCreation.Classes;

                this.Invoke(new MethodInvoker(() =>
                {
                    if (races != null)
                        this.lstCreationRace.Items.AddRange(races.Select(x => x.Name).ToArray());

                    if (classes != null)
                        this.lstCreationClass.Items.AddRange(classes.Select(x => x.Name).ToArray());
                }));
            });

            this.txtCreationName.Text = nameGenerator.BuildName();

            this.pnlCharacterCreation.Visible = true;
        }

        private void txtCreationName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //shortcuts dont work
            var regex = new Regex(@"[^a-zA-Z0-9-\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void CreateGamePanels()
        {
            CreateCharaterListView();
            CreateEquipmentListView();

            //when should I update names etc.
            this.grpPlebSheet.Text = "Dragonmost ♂";    //♀
            this.grpLevel.Text = "Level: " + "3";
            this.pgbHP.Value = 75;
            this.pgbMP.Value = 95;
            this.pgbExp.Value = 25;
            this.pgbEncumbrance.Value = 10;
            this.pgbHP.ForeColor = System.Drawing.Color.Yellow;
        }

        private void CreateCharaterListView()
        {
            ListViewItem itemRace = new ListViewItem("Race");
            itemRace.Name = "Race";
            itemRace.SubItems.Add(new ListViewItem.ListViewSubItem());

            ListViewItem itemClass = new ListViewItem("Class");
            itemClass.Name = "Class";
            itemClass.SubItems.Add(new ListViewItem.ListViewSubItem());

            lstPlebSheet.Items.AddRange(new ListViewItem[] { itemRace, itemClass });

            PropertyInfo[] properties = Type.GetType("PlebQuest.Stats").GetProperties();
            foreach (PropertyInfo property in properties)
            {
                ListViewItem item = new ListViewItem(property.Name);
                item.Name = property.Name;
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
                lstPlebSheet.Items.Add(item);
            }

            ListViewItem itemAlignment = new ListViewItem("Alignment"); //could displayed near expBar
            itemAlignment.Name = "Alignment";
            itemAlignment.SubItems.Add(new ListViewItem.ListViewSubItem());
            lstPlebSheet.Items.Add(itemAlignment);
        }

        private void CreateEquipmentListView()
        {
            ListViewItem itemWeapon = new ListViewItem("Weapon");
            itemWeapon.SubItems.Add(new ListViewItem.ListViewSubItem());

            ListViewItem itemHead = new ListViewItem("Head");
            itemHead.SubItems.Add(new ListViewItem.ListViewSubItem());

            ListViewItem itemChest = new ListViewItem("Chest");
            itemChest.SubItems.Add(new ListViewItem.ListViewSubItem());

            ListViewItem itemPants = new ListViewItem("Pants");
            itemPants.SubItems.Add(new ListViewItem.ListViewSubItem());

            ListViewItem itemBoots = new ListViewItem("Boots");
            itemBoots.SubItems.Add(new ListViewItem.ListViewSubItem());

            this.lstEquipment.Items.AddRange(new ListViewItem[] { itemWeapon, itemHead, itemChest, itemPants, itemBoots});

            foreach(ListViewItem item in lstEquipment.Items)
            {
                item.SubItems[1].Text = item.Name;
            }
        }

        public void RefreshEquipments(Equipment equip)
        {
            PropertyInfo[] properties = equip.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                ListViewItem item = this.lstEquipment.Items[property.Name];
                item.SubItems[1].Text = (property.GetValue(equip) as Armor).Name;
            }
        }

        public void RefreshStats(Stats stats)
        {
            PropertyInfo[] properties = stats.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                ListViewItem item = this.lstPlebSheet.Items[property.Name];
                item.SubItems[1].Text = property.GetValue(stats).ToString();
            }
        }

        public void RefreshRegion(Region region)
        {
            this.lblRegion.Text = region.Name;
            this.txtRegion.Text = region.Description;
        }

        public void RefreshSpeels(List<Speel> speelBook)
        {
            this.lstSpeel.Items.Clear();
            this.lstSpeel.Items.AddRange(speelBook.Select(x => x.Name).ToArray());
        }

        public void RefreshAlignment(int aligment)
        {
            ListViewItem item = this.lstPlebSheet.Items["Alignment"];
            item.SubItems[1].Text = aligment.ToString();
        }

        public void RefreshInventory(int gold, List<Item> inventory, int maxWeight, int currentWeight)
        {
            this.lblGold.Text = "Gold: " + gold.ToString();

            this.lstInventory.Items.Clear();
            foreach(Item item in inventory)
            {
                this.lstInventory.Items.Add(item.Quantity.ToString() + " " + item.Name);
            }

            this.pgbEncumbrance.Maximum = maxWeight;
            this.pgbEncumbrance.Value = currentWeight;
        }

        public void RefreshHP(int CurrentHP, int MaxHP)
        {
            this.pgbHP.Maximum = MaxHP;
            this.pgbHP.Value = CurrentHP;
        }

        public void RefreshQuest(List<Quest> completedQuests, Quest currentQuest, string objective)
        {
            completedQuests = new List<Quest>();
            completedQuests.Add(new Quest {Name = "Test" });
            completedQuests.Add(new Quest { Name = "Test2" });
            currentQuest = new Quest { Name = "Test3" };

            this.lstQuest.Items.Clear();

            foreach(Quest quest in completedQuests)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = quest.Name;
                item.ForeColor = System.Drawing.Color.Green;
                lstQuest.Items.Add(item);
            }
            

            //this.lstQuest.ForeColor = System.Drawing.Color.Black;
            this.lstQuest.Items.Add(currentQuest.Name);

            this.txtCurrentObjective.Text = objective;
        }
    }
}
