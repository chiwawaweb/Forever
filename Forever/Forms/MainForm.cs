﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forever.DAL;
using Forever.DTO;

namespace Forever.Forms
{
    public partial class MainForm : Form
    {

        int idRetour;



        public MainForm()
        {
            InitializeComponent();

            OrderProvider orderProvider = new OrderProvider();
            orderProvider.CountAll();

            
        }

        
        

        private void TsbNewOrder_Click(object sender, EventArgs e)
        {
            NewOrderForm();
        }

        private void NewOrderForm()
        {

            OrderEditForm orderEditForm = new OrderEditForm(this, false);
            orderEditForm.ShowDialog();
            
        }
        public void RefreshData()
        {

        }

        private void CreateTable(List<Order> list, int _idRetour)
        {
            idRetour = _idRetour;

            DgvOrders.Rows.Clear();
            DgvOrders.Columns.Clear();

            /* Mise en forme */
            DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn
            {
                Name = "ID",
                HeaderText = "#",
                Width=60
            };




            /* Création des colonnes */
            DgvOrders.Columns.Add(idCol);
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
