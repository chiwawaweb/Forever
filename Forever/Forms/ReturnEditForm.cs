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
    public partial class ReturnEditForm : Form
    {
        int _id;
        DateTime dateRetour;
        MainForm _owner;
        OrderProvider orderProvider = new OrderProvider();

        public ReturnEditForm(MainForm owner, int id)
        {
            _owner = owner;
            _id = id;

            FormClosed += new FormClosedEventHandler(ReturnEditForm_FormClosed);
            InitializeComponent();

            dateRetour = orderProvider.GetOrderById(_id).DateRetour;
            if (dateRetour == new DateTime(1899, 12, 30))
            { 
                ChkNotReturned.Visible = false;
            }
            else
            {
                DtpDateRetour.Value = dateRetour;
            }
                
        }

        private void Save()
        {
            if (ChkNotReturned.Checked == true)
                dateRetour = new DateTime(1899, 12, 30);
            else
                dateRetour = DtpDateRetour.Value;

            Order order = orderProvider.GetOrderById(_id);

            order.DateRetour = dateRetour;

            orderProvider.Update(order);

            Close();
        }

        #region Gestion des événements

        private void ReturnEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _owner.RefreshData();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        #endregion

        private void ChkNotReturned_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkNotReturned.Checked == true)
                DtpDateRetour.Enabled = false;
            else
                DtpDateRetour.Enabled = true;
        }
    }
}
