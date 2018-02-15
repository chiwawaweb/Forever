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

        int _id;
        double decalage;
        string PDF_FileName, PDF_Directory;
        DateTime date;

        Utils utils = new Utils();
        OrderProvider orderProvider = new OrderProvider();
        PdfContentByte cb;
        public OrderToPdf(int id)
        {
            _id = id;

            using (var reader = new PdfReader(@"C:\Input.pdf"))
            {
                using (var fileStream = new FileStream(@"C:\Output.pdf", FileMode.Create, FileAccess.Write))
                {
                    var document = new Document(reader.GetPageSizeWithRotation(1));
                    var writer = PdfWriter.GetInstance(document, fileStream);

                    document.Open();
                    document.NewPage();
                    
                    decalage = 15.25; // Décalage entre 2 cases sur le formulaire

                    var baseFont = BaseFont.CreateFont(BaseFont.COURIER_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    var importedPage = writer.GetImportedPage(reader, 1);

                    cb = writer.DirectContent;
                    cb.AddTemplate(importedPage, 0, 0);

                    string nom = orderProvider.GetOrderById(_id).Nom;
                    string prenom = orderProvider.GetOrderById(_id).Prenom;
                    string adresse = orderProvider.GetOrderById(_id).Adresse;
                    string cp = orderProvider.GetOrderById(_id).CP;
                    string ville = orderProvider.GetOrderById(_id).Ville;
                    string tel = orderProvider.GetOrderById(_id).Tel;
                    string gsm = orderProvider.GetOrderById(_id).Gsm;

                    /* Remplissage du formulaire */
                    cb.BeginText();

                    /* Partie coordonnées */
                    cb.SetFontAndSize(baseFont, 14);

                    WriteInCases(nom, 138, 656);
                    WriteInCases(prenom, 138, 641);
                    WriteInCases(adresse, 138, 626);
                    WriteInCases(cp, 138, 612);
                    WriteInCases(ville, 245, 612);
                    WriteInCases(tel, 138, 597);
                    WriteInCases(gsm, 397, 597);
                    WriteInCases("XXXXXXXXXXXXXXXXXXXXXXXXXXX", 138, 567);
                    WriteInCases("XXXXXXXXXXXXXXXXXXXXXXXXXX", 153, 552);

                    cb.EndText();


                    
                    

                    document.Close();
                    writer.Close();
                }

                
            }

            InitializeComponent();

            pdfDoc.LoadFile(PDF_Directory + PDF_FileName);
        }

        /// <summary>
        /// Ecrit dans les cases en respectant le décalage.
        /// </summary>
        /// <param name="phrase">Texte à écrire</param>
        private void WriteInCases(string phrase, int x, int y)
        {
            int nbChars = phrase.Length;

            for (int i = 0; i < nbChars; i++)
            {
                int d = Convert.ToInt16(i * decalage);
                cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, phrase.Substring(i, 1), x + d, y, 0);
            }
        }
    }
}
