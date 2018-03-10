using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace PlebQuest.Frames
{
    public partial class FreGame : UserControl
    {
        public MainMenu parentForm;

        public FreGame()
        {
            InitializeComponent();
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
            foreach (Item item in inventory)
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
            completedQuests.Add(new Quest { Name = "Test" });
            completedQuests.Add(new Quest { Name = "Test2" });
            currentQuest = new Quest { Name = "Test3" };

            this.lstQuest.Items.Clear();

            foreach (Quest quest in completedQuests)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = quest.Name;
                item.ForeColor = System.Drawing.Color.Green;
                lstQuest.Items.Add(item);
            }


            this.lstQuest.ForeColor = System.Drawing.Color.Black;
            this.lstQuest.Items.Add(currentQuest.Name);

            this.txtCurrentObjective.Text = objective;
        }

        public void CreateGamePanels()
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
            this.pgbAction.Value = 50;
            //in control properties
            this.pgbAction.ForeColor = System.Drawing.Color.MediumPurple;
            this.pgbExp.ForeColor = System.Drawing.Color.GreenYellow;
            this.pgbHP.ForeColor = System.Drawing.Color.Red;
            this.pgbEncumbrance.ForeColor = System.Drawing.Color.Orange;
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

            this.lstEquipment.Items.AddRange(new ListViewItem[] { itemWeapon, itemHead, itemChest, itemPants, itemBoots });

            foreach (ListViewItem item in lstEquipment.Items)
            {
                item.SubItems[1].Text = item.Name;
            }
        }
    }
}
