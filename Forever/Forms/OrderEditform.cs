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
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Diagnostics;

namespace Forever.Forms
{
    public partial class OrderEditForm : Form
    {
        /* Déclaration des variables */
        int _id, nbBobines, nbCassettes, nbUnitCond, nbDiapos, nbPhotos, nbNegatifs, nbCopiesSupp;
        string vendeur, nom, prenom, adresse, cp, ville, email, tel, gsm, notes;
        bool _view, persoDvdInternet, persoDvdPapier, dvdStandard, dvdPersonnalise, montageAvi, cleUsb, hdd, link;
        DateTime date, dateRetour, createdAt, updatedAt;

        MainForm _owner;
        
        OrderProvider orderProvider = new OrderProvider();
        Order order;
        Utils utils = new Utils();

        public OrderEditForm(MainForm owner, bool view, int id=0)
        {
            _owner = owner;
            _id = id;
            _view = view;

            FormClosed += new FormClosedEventHandler(OrderEditForm_FormClosed);
            InitializeComponent();

            /* Combobox vendeur */
            var dataSourceVendeur = new List<string>();
            dataSourceVendeur.Add("");
            foreach (string transfert in orderProvider.GetVendeurs())
            {
                dataSourceVendeur.Add(transfert);
            }
            CbxVendeur.DataSource = dataSourceVendeur;
            CbxVendeur.DisplayMember = "Vendeur";

            switch (_view)
            {
                /* Mode création */
                case false:
                    New();
                    break;

                /* Mode mise à jour */
                case true:
                    View();
                    break;
            }
        }

        private void New()
        {
            this.Text = "Nouvelle commande";
        }

        private void View()
        {
            this.Text = "Visualisation d'une commande";

            /* Modification des boutons et des champs */
            BtnCancel.Visible = false;
            BtnSave.Visible = false;
            BtnFermer.Visible = true;
            BtnPrint.Visible = true;
            BtnEdit.Visible = true;
            LblDate.Visible = true;
            LblDateView.Visible = true;
            CbxVendeur.Visible = false;
            LblVendeurView.Visible = true;
            LblDateRetour.Visible = true;
            LblDateRetourView.Visible = true;
            TxtNom.Visible = false;
            LblNomView.Visible = true;
            TxtPrenom.Visible = false;
            LblPrenomView.Visible = true;
            TxtAdresse.Visible = false;
            LblAdresseView.Visible = true;
            TxtCp.Visible = false;
            LblCpView.Visible = true;
            TxtVille.Visible = false;
            LblVilleView.Visible = true;
            TxtTel.Visible = false;
            LblTelView.Visible = true;
            TxtGsm.Visible = false;
            LblGsmView.Visible = true;
            TxtEmail.Visible = false;
            LblEmailView.Visible = true;
            TxtNbBobines.Visible = false;
            LblNbBobinesView.Visible = true;
            TxtNbCassettes.Visible = false;
            LblNbCassettesView.Visible = true;
            RbtDvdPapier.Visible = false;
            RbtPersoDvdInternet.Visible = false;
            LblPersonnalisationView.Visible = true;
            TxtNbUnitCond.Visible = false;
            LblNbUnitCondView.Visible = true;
            TxtNbDiapos.Visible = false;
            LblNbDiaposView.Visible = true;
            TxtNbPhotos.Visible = false;
            LblNbPhotosView.Visible = true;
            TxtNbNegatifs.Visible = false;
            LblNbNegatifsView.Visible = true;
            ChkDvdPersonnalise.Visible = false;
            LblDvdPersonnaliseView.Visible = true;
            ChkDvdStandard.Visible = false;
            LblDvdStandardView.Visible = true;
            TxtCopiesSupp.Visible = false;
            LblNbCopiesSuppView.Visible = true;
            ChkMontageAvi.Visible = false;
            LblMontageAviView.Visible = true;
            ChkCleUsb.Visible = false;
            LblCleUsbView.Visible = true;
            ChkHdd.Visible = false;
            LblHddView.Visible = true;
            ChkLink.Visible = false;
            LblLinkView.Visible = true;

            /* Récupération des données */
            order = orderProvider.GetOrderById(_id);

            date = order.Date;
            vendeur = order.Vendeur;
            nom = order.Nom;
            prenom = order.Prenom;
            adresse = order.Adresse;
            cp = order.CP;
            ville = order.Ville;
            tel = order.Tel;
            gsm = order.Gsm;
            email = order.Email;
            nbBobines = order.NbBobines;
            nbCassettes = order.NbCassettes;
            persoDvdInternet = order.PersoDvdInternet;
            persoDvdPapier = order.PersoDvdPapier;
            nbUnitCond = order.NbUnitCond;
            nbDiapos = order.NbDiapos;
            nbPhotos = order.NbPhotos;
            nbNegatifs = order.NbNegatifs;
            dvdStandard = order.DvdStandard;
            dvdPersonnalise = order.DvdPersonnalise;
            nbCopiesSupp = order.NbCopiesSupp;
            montageAvi = order.MontageAvi;
            cleUsb = order.CleUsb;
            cleUsb = orderProvider.GetOrderById(_id).CleUsb;
            hdd = order.Hdd;
            link = order.Link;
            dateRetour = order.DateRetour;
            createdAt = order.CreatedAt;
            updatedAt = order.UpdatedAt;

            /* Affichage des données */
            LblDateView.Text = date.ToShortDateString();
            CbxVendeur.Text = LblVendeurView.Text = vendeur;
            TxtNom.Text = LblNomView.Text = nom;
            TxtPrenom.Text = LblPrenomView.Text = prenom;
            TxtAdresse.Text = LblAdresseView.Text = adresse;
            TxtCp.Text = LblCpView.Text = cp;
            TxtVille.Text = LblVilleView.Text = ville;
            TxtTel.Text = LblTelView.Text = tel;
            TxtGsm.Text = LblGsmView.Text = gsm;
            TxtEmail.Text = LblEmailView.Text = email;
            TxtNbBobines.Text = LblNbBobinesView.Text = nbBobines.ToString();
            TxtNbCassettes.Text = LblNbCassettesView.Text = nbCassettes.ToString();

            if (persoDvdInternet == true)
            {
                LblPersonnalisationView.Text = "Sur Internet";
                RbtPersoDvdInternet.Checked = true;
            }

            if (persoDvdPapier == true)
            {
                LblPersonnalisationView.Text = "Sur papier";
                RbtDvdPapier.Checked = true;
            }

            TxtNbUnitCond.Text = LblNbUnitCondView.Text = nbUnitCond.ToString();
            TxtNbDiapos.Text = LblNbDiaposView.Text = nbDiapos.ToString();
            TxtNbPhotos.Text = LblNbPhotosView.Text = nbPhotos.ToString();
            TxtNbNegatifs.Text = LblNbNegatifsView.Text = nbNegatifs.ToString();

            if (dvdStandard == true)
            {
                LblDvdStandardView.Text = "OUI";
                ChkDvdStandard.Checked = true;
            }
            else
            {
                LblDvdStandardView.Text = "NON";
                ChkDvdStandard.Checked = true;
            }

            if (dvdPersonnalise == true)
            {
                LblDvdPersonnaliseView.Text = "OUI";
                ChkDvdPersonnalise.Checked = true;
            }
            else
            {
                LblDvdPersonnaliseView.Text = "NON";
                ChkDvdPersonnalise.Checked = false;
            }

            TxtCopiesSupp.Text = LblNbCopiesSuppView.Text = nbCopiesSupp.ToString();

            if (montageAvi == true)
            {
                LblMontageAviView.Text = "OUI";
                ChkMontageAvi.Checked = true;
            }
            else
            {
                LblMontageAviView.Text = "NON";
                ChkMontageAvi.Checked = false;
            }

            if (cleUsb == true)
            {
                LblCleUsbView.Text = "OUI"; ChkCleUsb.Checked = true;
            }
            else
            {
                LblCleUsbView.Text = "NON"; ChkCleUsb.Checked = false;
            }

            if (hdd == true)
            {
                LblHddView.Text = "OUI";

            }
            else
            {
                LblHddView.Text = "NON";
                ChkHdd.Checked = false;
            }

            if (link == true)
            {
                ChkLink.Checked = true;
                LblLinkView.Text = "OUI";
            }
            else
            {
                LblLinkView.Text = "NON";
                ChkLink.Checked = false;
            }

            if (dateRetour == new DateTime(1899, 12, 30))
                LblDateRetourView.Text = "n.c.";
            else
                LblDateRetourView.Text = dateRetour.ToShortDateString();

        }

        private void Edit()
        {
            MessageBox.Show("Etes-vous certain de vouloir modifier cette fiche ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void Save()
        {
            /* Récupération des données */
            vendeur = CbxVendeur.Text.Trim().ToUpper();
            nom = utils.RemoveDiacritics(TxtNom.Text).Trim().ToUpper();
            prenom = utils.RemoveDiacritics(TxtPrenom.Text).Trim().ToUpper();
            adresse = utils.RemoveDiacritics(TxtAdresse.Text).Trim().ToUpper();
            cp = utils.RemoveDiacritics(TxtCp.Text).Trim().ToUpper();
            ville = utils.RemoveDiacritics(TxtVille.Text).Trim().ToUpper();
            email = TxtEmail.Text.Trim().ToLower();
            tel = utils.RemoveDiacritics(TxtTel.Text).Trim().ToUpper();
            gsm = utils.RemoveDiacritics(TxtGsm.Text).Trim().ToUpper();
            if (String.IsNullOrEmpty(TxtNbBobines.Text)) { nbBobines = 0; } else { nbBobines = int.Parse(TxtNbBobines.Text); ; }
            if (String.IsNullOrEmpty(TxtNbCassettes.Text)) { nbCassettes = 0; } else { nbCassettes = int.Parse(TxtNbCassettes.Text); ; }
            persoDvdInternet = RbtPersoDvdInternet.Checked;
            persoDvdPapier = RbtDvdPapier.Checked;
            if (String.IsNullOrEmpty(TxtNbUnitCond.Text)) { nbUnitCond = 0; } else { nbUnitCond = int.Parse(TxtNbUnitCond.Text); ; }
            if (String.IsNullOrEmpty(TxtNbDiapos.Text)) { nbDiapos = 0; } else { nbDiapos = int.Parse(TxtNbDiapos.Text); ; }
            if (String.IsNullOrEmpty(TxtNbPhotos.Text)) { nbPhotos = 0; } else { nbPhotos = int.Parse(TxtNbPhotos.Text); ; }
            if (String.IsNullOrEmpty(TxtNbNegatifs.Text)) { nbNegatifs = 0; } else { nbNegatifs = int.Parse(TxtNbNegatifs.Text); ; }
            dvdStandard = ChkDvdStandard.Checked;
            dvdPersonnalise = ChkDvdPersonnalise.Checked;
            if (String.IsNullOrEmpty(TxtCopiesSupp.Text)) { nbCopiesSupp = 0; } else { nbCopiesSupp = int.Parse(TxtCopiesSupp.Text); ; }
            montageAvi = ChkMontageAvi.Checked;
            cleUsb = ChkCleUsb.Checked;
            hdd = ChkHdd.Checked;
            link = ChkLink.Checked;

            /* Vérification des données */
            bool erreurs = false;
            string errMsg = "Votre saisie comporte des erreurs : \n\n";

            if (vendeur.Length<2)
            {
                erreurs = true;
                errMsg += "- Vendeur non spécifié\n";
            }
            
            if (nom.Length<2)
            {
                erreurs = true;
                errMsg += "- Nom non spécifié\n";
            }

            if (prenom.Length<2)
            {
                erreurs = true;
                errMsg += "- Prénom non spécifié\n";
            }

            if (adresse.Length<2)
            {
                erreurs = true;
                errMsg += "- Adresse non spécifiée\n";
            }

            if (cp.Length < 2)
            {
                erreurs = true;
                errMsg += "- Code postal non spécifié\n";
            }

            if (ville.Length < 2)
            {
                erreurs = true;
                errMsg += "- Ville non spécifiée\n";
            }

            /* Au moins un téléphone ou email */
            if (string.IsNullOrEmpty(tel) && string.IsNullOrEmpty(gsm) && string.IsNullOrEmpty(email))
            {
                erreurs = true;
                errMsg += "- Au moins un numéro de téléphone ou adresse email\n";
            }
            else
            {
                if (tel!="" && tel.Length < 5)
                {
                    erreurs = true;
                    errMsg += "- Numéro de téléphone trop court\n";
                }

                if (!string.IsNullOrEmpty(gsm) && gsm.Length < 5)
                {
                    erreurs = true;
                    errMsg += "- Numéro de portable trop court\n";
                }

                if (utils.IsEmailValid(email) == false)
                {
                    erreurs = true;
                    errMsg += "- Adresse email incorrecte\n";
                }
            }

            if (nbUnitCond<1)
            {
                erreurs = true;
                errMsg += "- Nombre d'unité de conditionnement\n";
            }

            /* nombre de supports déposés au moins égal à 1 */
            int nbElementsDeposes = nbBobines + nbCassettes + nbPhotos + nbDiapos + nbNegatifs;
            if (nbElementsDeposes<1)
            {
                erreurs = true;
                errMsg += "- Nombre d'éléments déposés\n";
            }

            /* Contrôle si erreurs */
            if (erreurs == true)
            {
                MessageBox.Show(errMsg, "Erreurs dans la saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                /* Aucune erreur, on continue */
                using (Context context = new Context())
                {
                    if (_view == true)
                    {
                        UpdateDatabase();
                    }
                    else
                    {
                        AddDatabase();
                    }

                    //Visible = false;
                    OrderToPdf orderToPdf = new OrderToPdf(_id);
                    orderToPdf.ShowDialog();

                    Close();
                }
            }
        }

        private void UpdateDatabase()
        {
            
        }

        private void AddDatabase()
        {
            Order order = new Order
            {
                Date = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                Vendeur = vendeur,
                Nom = nom,
                Prenom = prenom,
                Adresse = adresse,
                CP = cp,
                Ville = ville,
                Email = email,
                Tel = tel,
                Gsm = gsm,
                NbBobines = nbBobines,
                NbCassettes = nbCassettes,
                PersoDvdInternet = persoDvdInternet,
                PersoDvdPapier = persoDvdPapier,
                NbUnitCond = nbUnitCond,
                NbDiapos = nbDiapos,
                NbPhotos = nbPhotos,
                NbNegatifs = nbNegatifs,
                DvdStandard = dvdStandard,
                DvdPersonnalise = dvdPersonnalise,
                NbCopiesSupp = nbCopiesSupp,
                MontageAvi = montageAvi,
                CleUsb = cleUsb,
                Hdd = hdd,
                Link = link,
                Notes = notes,
                DateRetour = new DateTime(1899,12,30),
                CreatedAt = DateTime.Now
            };

            orderProvider.Create(order);
            _id = order.Id;
        }

        private void PrintOrder()
        {
            OrderToPdf frm = new OrderToPdf(_id);
            frm.ShowDialog();
        }

        #region Gestion des événements

        private void TxtNbDiapos_KeyPress(object sender, KeyPressEventArgs e)
        {
            utils.ChiffreOnly(e);
        }

        private void TxtNbPhotos_KeyPress(object sender, KeyPressEventArgs e)
        {
            utils.ChiffreOnly(e);
        }

        private void TxtNbNegatifs_KeyPress(object sender, KeyPressEventArgs e)
        {
            utils.ChiffreOnly(e);
        }

        private void TxtCopiesSupp_KeyPress(object sender, KeyPressEventArgs e)
        {
            utils.ChiffreOnly(e);
        }

        private void TxtNbUnitCond_KeyPress(object sender, KeyPressEventArgs e)
        {
            utils.ChiffreOnly(e);
        }

        private void TxtNbCassettes_KeyPress(object sender, KeyPressEventArgs e)
        {
            utils.ChiffreOnly(e);
        }

        private void TxtNbBobines_KeyPress(object sender, KeyPressEventArgs e)
        {
            utils.ChiffreOnly(e);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OrderEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _owner.RefreshData();
        }

        private void TxtGsm_KeyPress(object sender, KeyPressEventArgs e)
        {
            utils.ChiffreOnly(e);
        }

        private void TxtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            utils.ChiffreOnly(e);
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            PrintOrder();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        #endregion
    }
}
