using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forever.DTO;
using Forever.DAL;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Forever.Classes
{
    public class ITextEvents : PdfPageEventHelper
    {
        int _id;
        DateTime date;

        OrderProvider orderProvider = new OrderProvider();

        PdfContentByte cb;
        BaseFont courierNewBold = null;


        public ITextEvents(int id)
        {
            _id = id;

            date = orderProvider.GetOrderById(_id).Date;
            
        }

        #region Fields 

        private string _header;

        #endregion

        #region Properties 

        public string Header
        {
            get { return _header; }
            set { _header = value; }
        }

        #endregion


        public override void OnOpenDocument(PdfWriter writer, Document document)
        {
            try
            {
                
                courierNewBold = BaseFont.CreateFont(BaseFont.COURIER_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                

                cb = writer.DirectContent;
            }
            catch (DocumentException de) { }
            catch (System.IO.IOException ioe) { }
        }

        public override void OnEndPage(PdfWriter writer, Document document)
        {
            base.OnEndPage(writer, document);
            
            // the pdf content
            PdfContentByte cb = writer.DirectContent;

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

            

        }

    }
}
