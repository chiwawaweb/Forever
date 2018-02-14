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

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
