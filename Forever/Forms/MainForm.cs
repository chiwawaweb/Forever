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
        public MainForm()
        {
            InitializeComponent();

            OrderProvider orderProvider = new OrderProvider();
            orderProvider.CountAll();

            OpenListeCommandes();
        }

        private void OpenListeCommandes()
        {
            //////////////
        }

        private void TsbNewOrder_Click(object sender, EventArgs e)
        {
            OpenOrderForm();
        }

        private void OpenOrderForm()
        {
            if (Application.OpenForms["OrderEditForm"] == null)
            {
                OrderEditForm orderEditForm = new OrderEditForm()
                {
                    MdiParent = this
                };
                orderEditForm.Show();
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
