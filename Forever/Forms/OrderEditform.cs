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
            LblDate.Visible = true;
            LblDateView.Visible = true;
            LblDateRetour.Visible = true;
            LblDateRetourView.Visible = true;
            CbxVendeur.Visible = false;
            LblVendeurView.Visible = true;
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
            date = orderProvider.GetOrderById(_id).Date;
            vendeur = orderProvider.GetOrderById(_id).Vendeur;
            nom = orderProvider.GetOrderById(_id).Nom;
            prenom = orderProvider.GetOrderById(_id).Prenom;
            adresse = orderProvider.GetOrderById(_id).Adresse;
            cp = orderProvider.GetOrderById(_id).CP;
            ville = orderProvider.GetOrderById(_id).Ville;
            tel = orderProvider.GetOrderById(_id).Tel;
            gsm = orderProvider.GetOrderById(_id).Gsm;
            email = orderProvider.GetOrderById(_id).Email;
            nbBobines = orderProvider.GetOrderById(_id).NbBobines;
            nbCassettes = orderProvider.GetOrderById(_id).NbCassettes;
            persoDvdInternet = orderProvider.GetOrderById(_id).PersoDvdInternet;
            persoDvdPapier = orderProvider.GetOrderById(_id).PersoDvdPapier;
            nbUnitCond = orderProvider.GetOrderById(_id).NbUnitCond;
            nbDiapos = orderProvider.GetOrderById(_id).NbDiapos;
            nbPhotos = orderProvider.GetOrderById(_id).NbPhotos;
            nbNegatifs = orderProvider.GetOrderById(_id).NbNegatifs;
            dvdStandard = orderProvider.GetOrderById(_id).DvdStandard;
            dvdPersonnalise = orderProvider.GetOrderById(_id).DvdPersonnalise;
            nbCopiesSupp = orderProvider.GetOrderById(_id).NbCopiesSupp;
            montageAvi = orderProvider.GetOrderById(_id).MontageAvi;
            cleUsb = orderProvider.GetOrderById(_id).CleUsb;
            hdd = orderProvider.GetOrderById(_id).Hdd;
            link = orderProvider.GetOrderById(_id).Link;
            dateRetour = orderProvider.GetOrderById(_id).DateRetour;
            createdAt = orderProvider.GetOrderById(_id).CreatedAt;
            updatedAt = orderProvider.GetOrderById(_id).UpdatedAt;

            /* Affichage des données */
            LblDateView.Text = date.ToShortDateString();
            CbxVendeur.Text = vendeur;
            LblVendeurView.Text = vendeur;
            TxtNom.Text = nom;
            LblNomView.Text = nom;
            TxtPrenom.Text = prenom;
            LblPrenomView.Text = prenom;
            LblAdresseView.Text = adresse;
            LblCpView.Text = cp;
            LblVilleView.Text = ville;
            LblTelView.Text = tel;
            LblGsmView.Text = gsm;
            LblEmailView.Text = email;
            LblNbBobinesView.Text = nbBobines.ToString();
            LblNbCassettesView.Text = nbCassettes.ToString();
            LblNbUnitCondView.Text = nbUnitCond.ToString();
            LblNbDiaposView.Text = nbDiapos.ToString();
            LblNbPhotosView.Text = nbPhotos.ToString();
            LblNbNegatifsView.Text = nbNegatifs.ToString();
            LblNbCopiesSuppView.Text = nbCopiesSupp.ToString();

            if (persoDvdInternet==true)
                LblPersonnalisationView.Text = "Sur Internet";

            if (persoDvdPapier == true)
                LblPersonnalisationView.Text = "Sur papier";

            if (dvdStandard == true)
                LblDvdStandardView.Text = "OUI";
            else
                LblDvdStandardView.Text = "NON";

            if (dvdPersonnalise == true)
                LblDvdPersonnaliseView.Text = "OUI";
            else
                LblDvdPersonnaliseView.Text = "NON";

            if (montageAvi == true)
                LblMontageAviView.Text = "OUI";
            else
                LblMontageAviView.Text = "NON";

            if (cleUsb == true)
                LblCleUsbView.Text = "OUI";
            else
                LblCleUsbView.Text = "NON";

            if (hdd == true)
                LblHddView.Text = "OUI";
            else
                LblHddView.Text = "NON";

            if (link == true)
                LblLinkView.Text = "OUI";
            else
                LblLinkView.Text = "NON";
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

        #endregion
    }
}
