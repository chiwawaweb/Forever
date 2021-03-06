﻿using Forever.DAL;
using Forever.DTO;
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
        string PDF_FileName, PDF_Directory, emailUser, emailDomain;

        Utils utils = new Utils();
        Order order;
        OrderProvider orderProvider = new OrderProvider();
        PdfContentByte cb;

        public OrderToPdf(int id)
        {
            _id = id;

            PDF_Directory = @"temp\";
            PDF_FileName = "forever_" + utils.MD5Hash(DateTime.Now.ToString("yyyyMMddHHmmssfff")) + ".pdf";

            /* Création du répertoire temporaire */
            Directory.CreateDirectory(PDF_Directory);
            string[] filenames = Directory.GetFiles(PDF_Directory, "*.*", SearchOption.TopDirectoryOnly);
            foreach (string fName in filenames)
            {
                try
                {
                    File.Delete(fName);
                }
                catch { }
            }

            using (var reader = new PdfReader(@"ModeleForever.pdf"))
            {
                using (var fileStream = new FileStream(PDF_Directory + PDF_FileName, FileMode.Create, FileAccess.Write))
                {
                    var document = new Document(reader.GetPageSizeWithRotation(1));
                    var writer = PdfWriter.GetInstance(document, fileStream);

                    document.Open();
                    document.NewPage();
                    
                    decalage = 15.25; // Décalage entre 2 cases sur le formulaire

                    var baseFont = BaseFont.CreateFont(BaseFont.COURIER_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    var smallFont = BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    var miniFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    var importedPage = writer.GetImportedPage(reader, 1);

                    cb = writer.DirectContent;
                    cb.AddTemplate(importedPage, 0, 0);

                    order = orderProvider.GetOrderById(_id);

                    DateTime date = order.Date;
                    string vendeur = order.Vendeur;
                    string nom = order.Nom;
                    string prenom = order.Prenom;
                    string adresse = order.Adresse;
                    string cp = order.CP;
                    string ville = order.Ville;
                    string tel = order.Tel;
                    string gsm = order.Gsm;
                    string email = order.Email;
                    int nbBobines = order.NbBobines;
                    int nbCassettes = order.NbCassettes;
                    bool persoDvdInternet = order.PersoDvdInternet;
                    bool persoDvdPapier = order.PersoDvdPapier;
                    int nbUnitCond = order.NbUnitCond;
                    int nbDiapos = order.NbDiapos;
                    int nbPhotos = order.NbPhotos;
                    int nbNegatifs = order.NbNegatifs;
                    bool dvdStandard = order.DvdStandard;
                    bool dvdPersonnalise = order.DvdPersonnalise;
                    int nbCopiesSupp = order.NbCopiesSupp;
                    bool montageAvi = order.MontageAvi;
                    bool cleUsb = order.CleUsb;
                    bool hdd = order.Hdd;
                    bool link = order.Link;
                    DateTime dateRetour = order.DateRetour;

                    /* Split de l'adresse email */
                    if (email != "")
                    {
                        MailAddress emailSplit = new MailAddress(email);
                        emailUser = emailSplit.User;
                        emailDomain = emailSplit.Host;
                    }

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
                    WriteInCases(emailUser, 138, 567);
                    WriteInCases(emailDomain, 153, 552);

                    /* Partie élements déposes */
                    cb.SetFontAndSize(baseFont, 22);

                    WriteInBigCase(nbBobines, 255, 512);
                    WriteInBigCase(nbCassettes, 511, 512);
                    WriteInBigCase(nbUnitCond, 190 , 404);
                    WriteInBigCase(nbDiapos, 350, 404);
                    WriteInBigCase(nbPhotos, 430, 404);
                    WriteInBigCase(nbNegatifs, 511, 404);

                    if (persoDvdInternet == true)
                        WriteInCases("x", 309, 478);

                    if (persoDvdPapier == true)
                        WriteInCases("x", 429, 478);

                    /* Partie supports de restitution */
                    if (dvdStandard == true)
                        WriteInCases("X", 195, 321);

                    if (dvdPersonnalise == true)
                        WriteInCases("X", 195, 294);

                    if (montageAvi == true)
                        WriteInCases("X", 370, 322);

                    if (cleUsb == true)
                        WriteInCases("X", 371, 302);

                    if (hdd == true)
                        WriteInCases("X", 526, 322); // hdd

                    if (link == true)
                        WriteInCases("X", 525, 302); // link

                    WriteInBigCase(nbCopiesSupp, 206, 264);

                    /* Nom du client, date et téléphone */
                    string telClient = tel;
                    if (string.IsNullOrEmpty(tel))
                        telClient = gsm;

                    cb.SetFontAndSize(smallFont, 9);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, nom.PadRight(20), 470, 771, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, date.ToShortDateString(), 470, 758, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, telClient, 470, 744, 0);

                    /* Nom du magasin */
                    cb.SetFontAndSize(miniFont, 7);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "HIFI INTERNATIONAL SA", 452, 708, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "C.C. BELLE ETOILE", 452, 700, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "", 452, 692, 0);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "L-8050 BERTRANGE", 452, 684, 0);

                    cb.EndText();

                    document.Close();
                    writer.Close();
                }
            }

            InitializeComponent();

            pdfDoc.LoadFile(PDF_Directory + PDF_FileName);
        }

        /// <summary>
        /// Ecrit un texte dans les cases en respectant le décalage.
        /// </summary>
        /// <param name="phrase">Texte à écrire</param>
        private void WriteInCases(string phrase, int x, int y)
        {
            if (!string.IsNullOrEmpty(phrase))
            {
                int nbChars = phrase.Length;

                for (int i = 0; i < nbChars; i++)
                {
                    int d = Convert.ToInt16(i * decalage);
                    cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, phrase.Substring(i, 1), x + d, y, 0);
                }
            }
        }

        /// <summary>
        /// Ecrit un chiffre dans une case
        /// </summary>
        /// <param name="phrase">Chiffre</param>
        /// <param name="x">Coordonnées X</param>
        /// <param name="y">Coordonnées Y</param>
        private void WriteInBigCase(int phrase = 0, int x = 0, int y = 0)
        {
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, phrase.ToString(), x, y, 0);
        }

        private void OrderToPdf_Load(object sender, EventArgs e)
        {
            pdfDoc.printWithDialog();
        }

        /// <summary>
        /// Ouvre la boîte de dialogue pour l'impression du PDF.
        /// </summary>
        private void PrintPdf()
        {
            pdfDoc.printWithDialog();
        }

        #region Gestion des événements

        private void TsbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TsbPrint_Click(object sender, EventArgs e)
        {
            PrintPdf();
        }

        #endregion
    }
}
