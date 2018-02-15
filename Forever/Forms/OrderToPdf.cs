using Forever.DAL;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading;
using System.Windows.Forms;
using Forever.Classes;

namespace Forever.Forms
{
    public partial class OrderToPdf : Form
    {

        private int _id;
        private string PDF_FileName, PDF_Directory;
        private DateTime date;

        Utils utils = new Utils();
        OrderProvider orderProvider = new OrderProvider();

        public OrderToPdf(int id)
        {
            _id = id;

            date = orderProvider.GetOrderById(_id).Date;

            PDF_Directory = @"temp\";
            PDF_FileName = "forever_" + _id.ToString("00000") + ".pdf";

            /* Création du répertoire temporaire */
            Directory.CreateDirectory(PDF_Directory);
            string path = @"temp\";
            string[] filenames = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly);
            foreach (string fName in filenames)
            {
                File.Delete(fName);
            }





            InitializeComponent();
        }
    }
}
