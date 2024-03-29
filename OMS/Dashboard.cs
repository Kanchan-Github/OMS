﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMS
{
    public partial class Dashboard : Form
    {
        public Dashboard(string Username)
        {
            InitializeComponent();
         
            label5.Text = Username;
        }

        private void InventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Order().Show();
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Order().Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void ProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
