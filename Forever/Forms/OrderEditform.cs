using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forever.Forms
{
    public partial class OrderEditForm : Form
    {
        /* Déclaration des variables */
        int _id;

        MainForm _owner;

        public OrderEditForm(MainForm owner, bool update, int id=0)
        {
            _owner = owner;
            _id = id;

            InitializeComponent();
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OrderEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //_owner.RefreshData();
        }
    }
}
