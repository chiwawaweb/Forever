using System;
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
using Forever.Classes;

namespace Forever.Forms
{
    public partial class MainForm : Form
    {

        int idRetour;

        Utils utils = new Utils();
        OrderProvider orderProvider = new OrderProvider();

        public MainForm()
        {
            InitializeComponent();

            OrderProvider orderProvider = new OrderProvider();
            orderProvider.CountAll();

            
        }

        private void OpenOrderForm(bool view)
        {
            if (view == true)
            {
                if (DgvOrders.RowCount > 0)
                {
                    int ID = int.Parse(DgvOrders.CurrentRow.Cells[0].Value.ToString());
                    idRetour = ID;
                    OrderEditForm frm = new OrderEditForm(this, view, ID);
                    frm.ShowDialog();
                }
            }
            else
            {
                OrderEditForm frm = new OrderEditForm(this, view);
                frm.ShowDialog();
            }
            
        }
        public void RefreshData(bool firstLine = false)
        {
            List<Order> list;
            list = orderProvider.Search(utils.RemoveDiacritics(TxtSearch.Text));

            if (firstLine == true)
            {
                idRetour = 0;
            }

            CreateTable(list, idRetour);
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
                Width = 60
            };
            idCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            idCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn dateCol = new DataGridViewTextBoxColumn
            {
                Name = "DATE",
                HeaderText = "Date",
                Width = 100
            };

            DataGridViewTextBoxColumn clientCol = new DataGridViewTextBoxColumn
            {
                Name = "CLIENT",
                HeaderText = "Nom du client",
                Width = 300
            };

            DataGridViewTextBoxColumn localiteCol = new DataGridViewTextBoxColumn
            {
                Name = "LOCALITE",
                HeaderText = "Localite",
                Width = 200
            };

            DataGridViewTextBoxColumn dateRetourCol = new DataGridViewTextBoxColumn
            {
                Name = "DATERETOUR",
                HeaderText = "Retour",
                Width = 100
            };

            DataGridViewTextBoxColumn vendeurCol = new DataGridViewTextBoxColumn
            {
                Name = "VENDEUR",
                HeaderText = "Vendeur",
                Width = 140
            };




            /* Création des colonnes */
            DgvOrders.Columns.Add(idCol);
            DgvOrders.Columns.Add(dateCol);
            DgvOrders.Columns.Add(clientCol);
            DgvOrders.Columns.Add(localiteCol);
            DgvOrders.Columns.Add(dateRetourCol);
            DgvOrders.Columns.Add(vendeurCol);

            /* Ajout des lignes */
            for (int i = 0; i < list.Count; i++)
            {
                int number = DgvOrders.Rows.Add();

                int id = list[i].Id;
                DateTime date = list[i].Date;
                string client = (list[i].Nom + " " + list[i].Prenom).Trim();
                string localite = (list[i].CP + " " + list[i].Ville).Trim();
                DateTime dateRetour = list[i].DateRetour;
                string vendeur = list[i].Vendeur;

                DgvOrders.Rows[number].Cells[0].Value = id.ToString("000000");
                DgvOrders.Rows[number].Cells[1].Value = date.ToShortDateString();
                DgvOrders.Rows[number].Cells[2].Value = client;
                DgvOrders.Rows[number].Cells[3].Value = localite;
                DgvOrders.Rows[number].Cells[4].Value = dateRetour.ToShortDateString();
                DgvOrders.Rows[number].Cells[5].Value = vendeur;


                /* pointe sur l'enregistrement courant */
                if (list[i].Id == idRetour)
                {
                    DgvOrders.Rows[number].Cells[1].Selected = true;
                }
            }
        }

        #region Gestion des événements

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TsbNewOrder_Click(object sender, EventArgs e)
        {
            OpenOrderForm(false);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void TsbView_Click(object sender, EventArgs e)
        {
            OpenOrderForm(true);
        }

        private void DgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenOrderForm(true);
        }

        #endregion

    }
}
