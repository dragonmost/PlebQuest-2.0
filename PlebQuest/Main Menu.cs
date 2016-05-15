﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlebServer;

namespace PlebQuest
{
    public partial class Form1 : Form
    {
        Client client;
        NameGenerator nameGenerator;

        Stats stats;
        Pleb pleb;


        public Form1()
        {
            InitializeComponent();
            nameGenerator = new NameGenerator();
        }

        private void butNew_Click(object sender, EventArgs e)
        {
            pnlCharacterCreation.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stats = new Stats();
            PropertyInfo[] properties = stats.GetType().GetProperties();
            int total = 0;

            foreach (PropertyInfo property in properties)
            {
                ListViewItem item = new ListViewItem(property.Name);
                item.Name = property.Name;
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
                item.SubItems[1].Text = property.GetValue(stats).ToString();
                lstCreationStat.Items.Add(item);

                total += (int)property.GetValue(stats);
            }

            this.txtCreationTotalStats.Text = total.ToString();
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            pleb = new Pleb(-1, this.txtCreationName.Text, stats, this.cheated);
        }

        private void butJoin_Click(object sender, EventArgs e)
        {
            client = new Client("localhost");

            client.SendData(new string[] { Commands.PlayerConnection, txtUsername.Text, txtPassword.Text });
        }

        private void butPlay_Click(object sender, EventArgs e)
        {

        }

        private void butCreate_Click(object sender, EventArgs e)
        {
            this.pnlCharacterCreation.Visible = true;
        }

        private void butCancelCreation_Click(object sender, EventArgs e)
        {
            this.pnlCharacterCreation.Visible = false;
        }

        private void butRoll_Click(object sender, EventArgs e)
        {
            stats = new Stats();
            int total = 0;

            foreach (PropertyInfo property in stats.GetType().GetProperties())
            {
                ListViewItem item = lstCreationStat.Items.Find(property.Name, true).First();
                item.SubItems[1].Text = property.GetValue(stats).ToString();

                total += (int)property.GetValue(stats);
            }

            this.txtCreationTotalStats.Text = total.ToString();
        }

        private Queue<Keys> keySequence = new Queue<Keys>();
        private bool cheated = false;

        private void txtCreationTotalStats_KeyDown(object sender, KeyEventArgs e)
        {
            keySequence.Enqueue(e.KeyCode);

            if (keySequence.Count > Cheat.Konami.Count)
                keySequence.Dequeue();

            if(keySequence.SequenceEqual(Cheat.Konami))
            {
                stats = new Stats();
                stats.Perfect();
                int total = 0;

                foreach (PropertyInfo property in stats.GetType().GetProperties())
                {
                    ListViewItem item = lstCreationStat.Items.Find(property.Name, true).First();
                    item.SubItems[1].Text = property.GetValue(stats).ToString();

                    total += (int)property.GetValue(stats);
                }
                this.txtCreationTotalStats.Text = total.ToString();
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
    }
}
