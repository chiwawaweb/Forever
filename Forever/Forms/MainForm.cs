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

            this.DgvOrders.DefaultCellStyle.Font = new Font("Consolas", 10);

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
                Width = 95
            };
            dateCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dateCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn clientCol = new DataGridViewTextBoxColumn
            {
                Name = "CLIENT",
                HeaderText = "Nom du client",
                Width = 450
            };
            clientCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn adresseCol = new DataGridViewTextBoxColumn
            {
                Name = "ADRESSE",
                HeaderText = "Adresse",
                Width = 230
            };
            adresseCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn localiteCol = new DataGridViewTextBoxColumn
            {
                Name = "LOCALITE",
                HeaderText = "Code postal / Localite",
                Width = 220
            };
            localiteCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn telCol = new DataGridViewTextBoxColumn
            {
                Name = "TELEPHONE",
                HeaderText = "Téléphone",
                Width = 90
            };
            telCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn gsmCol = new DataGridViewTextBoxColumn
            {
                Name = "PORTABLE",
                HeaderText = "Portable",
                Width = 90
            };
            gsmCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn dateRetourCol = new DataGridViewTextBoxColumn
            {
                Name = "DATERETOUR",
                HeaderText = "Retour",
                Width = 95
            };
            dateRetourCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dateRetourCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn vendeurCol = new DataGridViewTextBoxColumn
            {
                Name = "VENDEUR",
                HeaderText = "Vendeur",
                Width = 160
            };
            vendeurCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            /* Création des colonnes */
            DgvOrders.Columns.Add(idCol);
            DgvOrders.Columns.Add(dateCol);
            DgvOrders.Columns.Add(clientCol);
            DgvOrders.Columns.Add(adresseCol);
            DgvOrders.Columns.Add(localiteCol);
            DgvOrders.Columns.Add(telCol);
            DgvOrders.Columns.Add(gsmCol);
            DgvOrders.Columns.Add(dateRetourCol);
            DgvOrders.Columns.Add(vendeurCol);

            /* Ajout des lignes */
            for (int i = 0; i < list.Count; i++)
            {
                string dateRetourStr;
                int number = DgvOrders.Rows.Add();

                int id = list[i].Id;
                DateTime date = list[i].Date;
                string client = (list[i].Nom + " " + list[i].Prenom).Trim();
                string adresse = list[i].Adresse.Trim();
                string localite = (list[i].CP + " " + list[i].Ville).Trim();
                string tel = list[i].Tel;
                string gsm = list[i].Gsm;
                DateTime dateRetour = list[i].DateRetour;
                if (dateRetour == new DateTime(1899, 12, 30))
                    dateRetourStr = "";
                else
                    dateRetourStr = dateRetour.ToString("dd/MM/yyyy");
                string vendeur = list[i].Vendeur;

                DgvOrders.Rows[number].Cells[0].Value = id.ToString("000000");
                DgvOrders.Rows[number].Cells[1].Value = date.ToShortDateString();
                DgvOrders.Rows[number].Cells[2].Value = client;
                DgvOrders.Rows[number].Cells[3].Value = adresse;
                DgvOrders.Rows[number].Cells[4].Value = localite;
                DgvOrders.Rows[number].Cells[5].Value = tel;
                DgvOrders.Rows[number].Cells[6].Value = gsm;
                DgvOrders.Rows[number].Cells[7].Value = dateRetourStr;
                DgvOrders.Rows[number].Cells[8].Value = vendeur;

                /* pointe sur l'enregistrement courant */
                if (list[i].Id == idRetour)
                {
                    DgvOrders.Rows[number].Cells[1].Selected = true;
                }
            }
        }

        private void PrintOrder()
        {
            if (DgvOrders.RowCount > 0)
            {
                int id = int.Parse(DgvOrders.CurrentRow.Cells[0].Value.ToString());
                idRetour = id;
                OrderToPdf frm = new OrderToPdf(id);
                frm.ShowDialog();
            }
        }

        private void DateRetour()
        {
            if (DgvOrders.RowCount > 0)
            {
                int id = int.Parse(DgvOrders.CurrentRow.Cells[0].Value.ToString());
                idRetour = id;
                ReturnEditForm frm = new ReturnEditForm(this, id);
                frm.ShowDialog();
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

        private void TsbPrint_Click(object sender, EventArgs e)
        {
            PrintOrder();
        }

        private void TsbRetour_Click(object sender, EventArgs e)
        {
            DateRetour();
        }

        #endregion


    }
}
