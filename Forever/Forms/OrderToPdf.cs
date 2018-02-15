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

            string oldFile = "oldFile.pdf";
            string newFile = "newFile.pdf";

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

            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            // the pdf content
            PdfContentByte cb = writer.DirectContent;

            // open the reader
            PdfReader reader = new PdfReader(oldFile);
            Rectangle size = reader.GetPageSizeWithRotation(1);

            // write the text in the pdf content
            cb.BeginText();
            string text = "Some random blablablabla...";
            // put the alignment and coordinates here
            cb.ShowTextAligned(1, text, 520, 640, 0);
            cb.EndText();
            cb.BeginText();
            text = "Other random blabla...";
            // put the alignment and coordinates here
            cb.ShowTextAligned(2, text, 100, 200, 0);
            cb.EndText();

            // create the new page and add it to the pdf
            PdfImportedPage page = writer.GetImportedPage(reader, 1);
            cb.AddTemplate(page, 0, 0);

            Document doc = new Document(PageSize.A4, 0, 0, 0, 15);
            try
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(PDF_Directory + PDF_FileName, FileMode.Create));
                writer.ViewerPreferences = PdfWriter.FitWindow;
                writer.PageEvent = new ITextEvents(_id);

                /* entête du fichier */
                doc.AddTitle("Commande Forever du " + date.ToShortDateString());
                doc.AddAuthor("Forever");
                doc.Open();

                doc.Add(new Phrase("\n")); // Ne pas supprimer !!

                /* Clôture du document */
                doc.Close();
                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK);
            }


            InitializeComponent();


            pdfDoc.LoadFile(PDF_Directory + PDF_FileName);
        }
    }
}
