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
            using (var reader = new PdfReader(@"C:\Input.pdf"))
            {
                using (var fileStream = new FileStream(@"C:\Output.pdf", FileMode.Create, FileAccess.Write))
                {
                    var document = new Document(reader.GetPageSizeWithRotation(1));
                    var writer = PdfWriter.GetInstance(document, fileStream);

                    document.Open();

                    
                    document.NewPage();

                    var baseFont = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    var importedPage = writer.GetImportedPage(reader, 1);

                    var cb = writer.DirectContent;

                    cb.AddTemplate(importedPage, 0, 0);

                    cb.BeginText();
                    cb.SetFontAndSize(baseFont, 12);

                    var multiLineString = "Hello,\r\nWorld!".Split('\n');

                    string footerL1 = "HIFI INTERNATIONAL SA - Route de Luxembourg - B.P. 1 - L-3201 BETTEMBOURG";
                    string footerL2 = "Tél.: (352) 40 24 24 - Fax: (352) 40 22 33 - www.hifi.lu - E-mail : info@hifi.lu";
                    string footerL3 = "N° TVA LU 190 388 17 - RC Luxembourg B 13.377 - CELLLULL LU044 0141 4148 0170 0000 - BGLLLULL LU50 0030 5353 4541 1000";


                    foreach (var line in multiLineString)
                    {
                        cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, line, 200, 200, 0);
                    }

                    cb.EndText();


                    cb.BeginText();
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, footerL1, 297, 140, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, footerL2, 297, 230, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, footerL3, 297, 220, 0);
                    cb.EndText();


                    
                    

                    document.Close();
                    writer.Close();
                }
            }

                 

            

            

            
            InitializeComponent();


            pdfDoc.LoadFile(PDF_Directory + PDF_FileName);
        }
    }
}
