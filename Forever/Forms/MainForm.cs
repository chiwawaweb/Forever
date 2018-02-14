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

namespace Forever.Forms
{
    public partial class MainForm : Form
    {
        OrdersListForm ordersListForm = new OrdersListForm();
        public MainForm()
        {
            InitializeComponent();

            OrderProvider orderProvider = new OrderProvider();
            orderProvider.CountAll();

            OpenListeCommandes();
        }

        private void OpenListeCommandes()
        {
            if (Application.OpenForms["OrdersListForm"] == null)
            {

                if (ordersListForm.IsDisposed == true)
                {
                    OrdersListForm contactsListForm = new OrdersListForm();
                    ordersListForm.MdiParent = this;
                    ordersListForm.Show();
                    this.LayoutMdi(MdiLayout.TileHorizontal);
                }
                else
                {
                    ordersListForm.MdiParent = this;
                    ordersListForm.Show();
                    this.LayoutMdi(MdiLayout.TileHorizontal);
                }
            }
            else
            {
                ordersListForm.Activate();
            }
        }

        private void TsbNewOrder_Click(object sender, EventArgs e)
        {
            OpenOrderForm();
        }

        private void OpenOrderForm()
        {

            OrderEditForm orderEditForm = new OrderEditForm();
            orderEditForm.ShowDialog();
            
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
