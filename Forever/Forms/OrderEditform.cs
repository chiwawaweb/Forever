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
            CheckForIllegalCrossThreadCalls = false;

            Thread TDate = new Thread(delegate ()
            {
                date = orderProvider.GetOrderById(_id).Date;
                LblDateView.Text = date.ToShortDateString();
                
            });
            TDate.Start();

            Thread TVendeur = new Thread(delegate ()
            {
                vendeur = orderProvider.GetOrderById(_id).Vendeur;
                CbxVendeur.Text = vendeur;
                LblVendeurView.Text = vendeur;
                
            });
            TVendeur.Start();

            Thread TNom = new Thread(delegate ()
            {
                nom = orderProvider.GetOrderById(_id).Nom;
                TxtNom.Text = nom;
                LblNomView.Text = nom;
            });
            TNom.Start();

            Thread TPrenom = new Thread(delegate ()
            {
                prenom = orderProvider.GetOrderById(_id).Prenom;
                TxtPrenom.Text = prenom;
                LblPrenomView.Text = prenom;
            });
            TPrenom.Start();

            Thread TAdresse = new Thread(delegate ()
            {
                adresse = orderProvider.GetOrderById(_id).Adresse;
                TxtAdresse.Text = adresse;
                LblAdresseView.Text = adresse;
            });
            TAdresse.Start();

            Thread TCp = new Thread(delegate ()
            {
                cp = orderProvider.GetOrderById(_id).CP;
                TxtCp.Text = cp;
                LblCpView.Text = cp;
            });
            TCp.Start();

            Thread TVille = new Thread(delegate ()
            {
                ville = orderProvider.GetOrderById(_id).Ville;
                TxtVille.Text = ville;
                LblVilleView.Text = ville;
            });
            TVille.Start();

            Thread TTel = new Thread(delegate ()
            {
                tel = orderProvider.GetOrderById(_id).Tel;
                TxtTel.Text = tel;
                LblTelView.Text = tel;
            });
            TTel.Start();

            Thread TGsm = new Thread(delegate ()
            {
                gsm = orderProvider.GetOrderById(_id).Gsm;
                TxtGsm.Text = gsm;
                LblGsmView.Text = gsm;
            });
            TGsm.Start();

            Thread TEmail = new Thread(delegate ()
            {
                email = orderProvider.GetOrderById(_id).Email;
                TxtEmail.Text = LblEmailView.Text = email;
            });
            TEmail.Start();

            Thread TNbBobines = new Thread(delegate ()
            {
                nbBobines = orderProvider.GetOrderById(_id).NbBobines;
                TxtNbBobines.Text = LblNbBobinesView.Text = nbBobines.ToString();
            });
            TNbBobines.Start();

            Thread TNbCassettes = new Thread(delegate ()
            {
                nbCassettes = orderProvider.GetOrderById(_id).NbCassettes;
                TxtNbCassettes.Text = LblNbCassettesView.Text = nbCassettes.ToString();
            });
            TNbCassettes.Start();

            Thread TPersoDvdInternet = new Thread(delegate ()
            {
                persoDvdInternet = orderProvider.GetOrderById(_id).PersoDvdInternet;
                if (persoDvdInternet == true)
                {
                    LblPersonnalisationView.Text = "Sur Internet";
                    RbtPersoDvdInternet.Checked = true;
                }
            });
            TPersoDvdInternet.Start();

            Thread TPersoDvdPapier = new Thread(delegate ()
            {
                persoDvdPapier = orderProvider.GetOrderById(_id).PersoDvdPapier;
                if (persoDvdPapier == true)
                {
                    LblPersonnalisationView.Text = "Sur papier";
                    RbtDvdPapier.Checked = true;
                }
            });
            TPersoDvdPapier.Start();

            Thread TNbUnitCond = new Thread(delegate ()
            {
                nbUnitCond = orderProvider.GetOrderById(_id).NbUnitCond;
                TxtNbUnitCond.Text = LblNbUnitCondView.Text = nbUnitCond.ToString();
            });
            TNbUnitCond.Start();

            Thread TNbDiapos = new Thread(delegate ()
            {
                nbDiapos = orderProvider.GetOrderById(_id).NbDiapos;
                TxtNbDiapos.Text = LblNbDiaposView.Text = nbDiapos.ToString();
            });
            TNbDiapos.Start();

            Thread TNbPhotos = new Thread(delegate ()
            {
                nbPhotos = orderProvider.GetOrderById(_id).NbPhotos;
                TxtNbPhotos.Text = LblNbPhotosView.Text = nbPhotos.ToString();
            });
            TNbPhotos.Start();

            Thread TNbNegatifs = new Thread(delegate ()
            {
                nbNegatifs = orderProvider.GetOrderById(_id).NbNegatifs;
                TxtNbNegatifs.Text = LblNbNegatifsView.Text = nbNegatifs.ToString();
            });
            TNbNegatifs.Start();

            Thread TDvdStandard = new Thread(delegate ()
            {
                dvdStandard = orderProvider.GetOrderById(_id).DvdStandard;
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
            });
            TDvdStandard.Start();

            Thread TDvdPersonnalise = new Thread(delegate ()
            {
                dvdPersonnalise = orderProvider.GetOrderById(_id).DvdPersonnalise;
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
            });
            TDvdPersonnalise.Start();

            Thread TNbCopiesSupp = new Thread(delegate ()
            {
                nbCopiesSupp = orderProvider.GetOrderById(_id).NbCopiesSupp;
                TxtCopiesSupp.Text = LblNbCopiesSuppView.Text = nbCopiesSupp.ToString();
            });
            TNbCopiesSupp.Start();

            Thread TMontageAvi = new Thread(delegate ()
            {
                montageAvi = orderProvider.GetOrderById(_id).MontageAvi;
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
            });
            TMontageAvi.Start();

            Thread TCleUsb = new Thread(delegate ()
            {
                cleUsb = orderProvider.GetOrderById(_id).CleUsb;
                if (cleUsb == true)
                {
                    LblCleUsbView.Text = "OUI"; ChkCleUsb.Checked = true;
                }
                else
                {
                    LblCleUsbView.Text = "NON"; ChkCleUsb.Checked = false;
                }
            });
            TCleUsb.Start();

            Thread THdd = new Thread(delegate ()
            {
                hdd = orderProvider.GetOrderById(_id).Hdd;
                if (hdd == true)
                {
                    LblHddView.Text = "OUI";

                }
                else
                {
                    LblHddView.Text = "NON";
                    ChkHdd.Checked = false;
                }
            });
            THdd.Start();

            Thread TLink = new Thread(delegate ()
            {
                link = orderProvider.GetOrderById(_id).Link;
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
            });
            TLink.Start();

            Thread TDateRetour = new Thread(delegate ()
            {
                dateRetour = orderProvider.GetOrderById(_id).DateRetour;
                if (dateRetour == new DateTime(1899, 12, 30))
                    LblDateRetourView.Text = "n.c.";
                else
                    LblDateRetourView.Text = dateRetour.ToShortDateString();
            });
            TDateRetour.Start();

            Thread TCreatedAt = new Thread(delegate ()
            {
                createdAt = orderProvider.GetOrderById(_id).CreatedAt;
            });
            TCreatedAt.Start();

            Thread TUpdatedAt = new Thread(delegate ()
            {
                updatedAt = orderProvider.GetOrderById(_id).UpdatedAt;
            });
            TUpdatedAt.Start();

            /*
            TDate.Start();
            TVendeur.Start();
            TNom.Start();
            TPrenom.Start();
            TAdresse.Start();
            TCp.Start();
            TVille.Start();
            TTel.Start();
            TGsm.Start();
            TEmail.Start();
            TNbBobines.Start();
            TNbCassettes.Start();
            TPersoDvdInternet.Start();
            TPersoDvdPapier.Start();
            TNbUnitCond.Start();
            TNbDiapos.Start();
            TNbPhotos.Start();
            TNbNegatifs.Start();
            TDvdStandard.Start();
            TDvdPersonnalise.Start();
            TNbCopiesSupp.Start();
            TMontageAvi.Start();
            TCleUsb.Start();
            THdd.Start();
            TLink.Start();
            TDateRetour.Start();
            */

        }

        private void Edit()
        {

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
