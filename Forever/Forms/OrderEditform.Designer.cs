namespace Forever.Forms
{
    partial class OrderEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderEditForm));
            this.LblNom = new System.Windows.Forms.Label();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.CbxVendeur = new System.Windows.Forms.ComboBox();
            this.TxtPrenom = new System.Windows.Forms.TextBox();
            this.TxtAdresse = new System.Windows.Forms.TextBox();
            this.TxtCp = new System.Windows.Forms.TextBox();
            this.TxtVille = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtNbBobines = new System.Windows.Forms.TextBox();
            this.TxtNbCassettes = new System.Windows.Forms.TextBox();
            this.TxtNbUnitCond = new System.Windows.Forms.TextBox();
            this.TxtNbDiapos = new System.Windows.Forms.TextBox();
            this.TxtNbPhotos = new System.Windows.Forms.TextBox();
            this.TxtNbNegatifs = new System.Windows.Forms.TextBox();
            this.ChkDvdStandard = new System.Windows.Forms.CheckBox();
            this.ChkDvdPersonnalise = new System.Windows.Forms.CheckBox();
            this.ChkMontageAvi = new System.Windows.Forms.CheckBox();
            this.TxtCopiesSupp = new System.Windows.Forms.TextBox();
            this.ChkCleUsb = new System.Windows.Forms.CheckBox();
            this.ChkHdd = new System.Windows.Forms.CheckBox();
            this.ChkLink = new System.Windows.Forms.CheckBox();
            this.LblPrenom = new System.Windows.Forms.Label();
            this.LblAdresse = new System.Windows.Forms.Label();
            this.LblCp = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblVille = new System.Windows.Forms.Label();
            this.LblGsm = new System.Windows.Forms.Label();
            this.LblTel = new System.Windows.Forms.Label();
            this.TxtGsm = new System.Windows.Forms.TextBox();
            this.TxtTel = new System.Windows.Forms.TextBox();
            this.LblVendeur = new System.Windows.Forms.Label();
            this.GrpCoordonnees = new System.Windows.Forms.GroupBox();
            this.GrpElements = new System.Windows.Forms.GroupBox();
            this.RbtDvdPapier = new System.Windows.Forms.RadioButton();
            this.RbtPersoDvdInternet = new System.Windows.Forms.RadioButton();
            this.LblNbCassettes = new System.Windows.Forms.Label();
            this.LblNbBobines = new System.Windows.Forms.Label();
            this.LblPersoDvd = new System.Windows.Forms.Label();
            this.LblNbNegatifs = new System.Windows.Forms.Label();
            this.LblNbPhotos = new System.Windows.Forms.Label();
            this.LblNbDiapos = new System.Windows.Forms.Label();
            this.LblUnitCond = new System.Windows.Forms.Label();
            this.GrpSupports = new System.Windows.Forms.GroupBox();
            this.LblCopiesSupp = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.GrpCoordonnees.SuspendLayout();
            this.GrpElements.SuspendLayout();
            this.GrpSupports.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Location = new System.Drawing.Point(51, 41);
            this.LblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(44, 16);
            this.LblNom.TabIndex = 0;
            this.LblNom.Text = "Nom :";
            // 
            // TxtNom
            // 
            this.TxtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNom.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNom.Location = new System.Drawing.Point(97, 36);
            this.TxtNom.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNom.MaxLength = 27;
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(295, 26);
            this.TxtNom.TabIndex = 0;
            // 
            // CbxVendeur
            // 
            this.CbxVendeur.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxVendeur.FormattingEnabled = true;
            this.CbxVendeur.Location = new System.Drawing.Point(128, 13);
            this.CbxVendeur.Margin = new System.Windows.Forms.Padding(4);
            this.CbxVendeur.Name = "CbxVendeur";
            this.CbxVendeur.Size = new System.Drawing.Size(178, 27);
            this.CbxVendeur.TabIndex = 0;
            // 
            // TxtPrenom
            // 
            this.TxtPrenom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPrenom.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.TxtPrenom.Location = new System.Drawing.Point(515, 36);
            this.TxtPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPrenom.MaxLength = 27;
            this.TxtPrenom.Name = "TxtPrenom";
            this.TxtPrenom.Size = new System.Drawing.Size(295, 26);
            this.TxtPrenom.TabIndex = 1;
            // 
            // TxtAdresse
            // 
            this.TxtAdresse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtAdresse.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.TxtAdresse.Location = new System.Drawing.Point(97, 70);
            this.TxtAdresse.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAdresse.MaxLength = 27;
            this.TxtAdresse.Name = "TxtAdresse";
            this.TxtAdresse.Size = new System.Drawing.Size(295, 26);
            this.TxtAdresse.TabIndex = 2;
            // 
            // TxtCp
            // 
            this.TxtCp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.TxtCp.Location = new System.Drawing.Point(515, 70);
            this.TxtCp.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCp.MaxLength = 5;
            this.TxtCp.Name = "TxtCp";
            this.TxtCp.Size = new System.Drawing.Size(55, 26);
            this.TxtCp.TabIndex = 3;
            // 
            // TxtVille
            // 
            this.TxtVille.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtVille.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.TxtVille.Location = new System.Drawing.Point(622, 70);
            this.TxtVille.Margin = new System.Windows.Forms.Padding(4);
            this.TxtVille.MaxLength = 20;
            this.TxtVille.Name = "TxtVille";
            this.TxtVille.Size = new System.Drawing.Size(189, 26);
            this.TxtVille.TabIndex = 4;
            // 
            // TxtEmail
            // 
            this.TxtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.TxtEmail.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.TxtEmail.Location = new System.Drawing.Point(515, 104);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEmail.MaxLength = 54;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(296, 26);
            this.TxtEmail.TabIndex = 7;
            // 
            // TxtNbBobines
            // 
            this.TxtNbBobines.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.TxtNbBobines.Location = new System.Drawing.Point(169, 30);
            this.TxtNbBobines.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNbBobines.MaxLength = 2;
            this.TxtNbBobines.Name = "TxtNbBobines";
            this.TxtNbBobines.Size = new System.Drawing.Size(32, 26);
            this.TxtNbBobines.TabIndex = 0;
            this.TxtNbBobines.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtNbBobines.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNbBobines_KeyPress);
            // 
            // TxtNbCassettes
            // 
            this.TxtNbCassettes.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.TxtNbCassettes.Location = new System.Drawing.Point(384, 30);
            this.TxtNbCassettes.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNbCassettes.MaxLength = 2;
            this.TxtNbCassettes.Name = "TxtNbCassettes";
            this.TxtNbCassettes.Size = new System.Drawing.Size(32, 26);
            this.TxtNbCassettes.TabIndex = 1;
            this.TxtNbCassettes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtNbCassettes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNbCassettes_KeyPress);
            // 
            // TxtNbUnitCond
            // 
            this.TxtNbUnitCond.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.TxtNbUnitCond.Location = new System.Drawing.Point(223, 73);
            this.TxtNbUnitCond.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNbUnitCond.MaxLength = 4;
            this.TxtNbUnitCond.Name = "TxtNbUnitCond";
            this.TxtNbUnitCond.Size = new System.Drawing.Size(52, 26);
            this.TxtNbUnitCond.TabIndex = 4;
            this.TxtNbUnitCond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtNbUnitCond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNbUnitCond_KeyPress);
            // 
            // TxtNbDiapos
            // 
            this.TxtNbDiapos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.TxtNbDiapos.Location = new System.Drawing.Point(614, 73);
            this.TxtNbDiapos.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNbDiapos.MaxLength = 4;
            this.TxtNbDiapos.Name = "TxtNbDiapos";
            this.TxtNbDiapos.Size = new System.Drawing.Size(52, 26);
            this.TxtNbDiapos.TabIndex = 5;
            this.TxtNbDiapos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtNbDiapos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNbDiapos_KeyPress);
            // 
            // TxtNbPhotos
            // 
            this.TxtNbPhotos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.TxtNbPhotos.Location = new System.Drawing.Point(614, 107);
            this.TxtNbPhotos.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNbPhotos.MaxLength = 4;
            this.TxtNbPhotos.Name = "TxtNbPhotos";
            this.TxtNbPhotos.Size = new System.Drawing.Size(52, 26);
            this.TxtNbPhotos.TabIndex = 6;
            this.TxtNbPhotos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtNbPhotos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNbPhotos_KeyPress);
            // 
            // TxtNbNegatifs
            // 
            this.TxtNbNegatifs.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.TxtNbNegatifs.Location = new System.Drawing.Point(614, 141);
            this.TxtNbNegatifs.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNbNegatifs.MaxLength = 4;
            this.TxtNbNegatifs.Name = "TxtNbNegatifs";
            this.TxtNbNegatifs.Size = new System.Drawing.Size(52, 26);
            this.TxtNbNegatifs.TabIndex = 7;
            this.TxtNbNegatifs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtNbNegatifs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNbNegatifs_KeyPress);
            // 
            // ChkDvdStandard
            // 
            this.ChkDvdStandard.AutoSize = true;
            this.ChkDvdStandard.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkDvdStandard.Location = new System.Drawing.Point(32, 33);
            this.ChkDvdStandard.Margin = new System.Windows.Forms.Padding(4);
            this.ChkDvdStandard.Name = "ChkDvdStandard";
            this.ChkDvdStandard.Size = new System.Drawing.Size(133, 20);
            this.ChkDvdStandard.TabIndex = 0;
            this.ChkDvdStandard.Text = "DVD standard(s)";
            this.ChkDvdStandard.UseVisualStyleBackColor = true;
            // 
            // ChkDvdPersonnalise
            // 
            this.ChkDvdPersonnalise.AutoSize = true;
            this.ChkDvdPersonnalise.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkDvdPersonnalise.Location = new System.Drawing.Point(7, 61);
            this.ChkDvdPersonnalise.Margin = new System.Windows.Forms.Padding(4);
            this.ChkDvdPersonnalise.Name = "ChkDvdPersonnalise";
            this.ChkDvdPersonnalise.Size = new System.Drawing.Size(158, 20);
            this.ChkDvdPersonnalise.TabIndex = 1;
            this.ChkDvdPersonnalise.Text = "DVD personnalisé(s)";
            this.ChkDvdPersonnalise.UseVisualStyleBackColor = true;
            // 
            // ChkMontageAvi
            // 
            this.ChkMontageAvi.AutoSize = true;
            this.ChkMontageAvi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkMontageAvi.Location = new System.Drawing.Point(215, 33);
            this.ChkMontageAvi.Margin = new System.Windows.Forms.Padding(4);
            this.ChkMontageAvi.Name = "ChkMontageAvi";
            this.ChkMontageAvi.Size = new System.Drawing.Size(192, 20);
            this.ChkMontageAvi.TabIndex = 3;
            this.ChkMontageAvi.Text = "Fichiers de montage (.avi)";
            this.ChkMontageAvi.UseVisualStyleBackColor = true;
            // 
            // TxtCopiesSupp
            // 
            this.TxtCopiesSupp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.TxtCopiesSupp.Location = new System.Drawing.Point(152, 85);
            this.TxtCopiesSupp.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCopiesSupp.Name = "TxtCopiesSupp";
            this.TxtCopiesSupp.Size = new System.Drawing.Size(32, 26);
            this.TxtCopiesSupp.TabIndex = 2;
            this.TxtCopiesSupp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCopiesSupp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCopiesSupp_KeyPress);
            // 
            // ChkCleUsb
            // 
            this.ChkCleUsb.AutoSize = true;
            this.ChkCleUsb.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkCleUsb.Location = new System.Drawing.Point(266, 61);
            this.ChkCleUsb.Margin = new System.Windows.Forms.Padding(4);
            this.ChkCleUsb.Name = "ChkCleUsb";
            this.ChkCleUsb.Size = new System.Drawing.Size(141, 20);
            this.ChkCleUsb.TabIndex = 4;
            this.ChkCleUsb.Text = "Clé USB (MPEG4)";
            this.ChkCleUsb.UseVisualStyleBackColor = true;
            // 
            // ChkHdd
            // 
            this.ChkHdd.AutoSize = true;
            this.ChkHdd.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkHdd.Location = new System.Drawing.Point(471, 33);
            this.ChkHdd.Margin = new System.Windows.Forms.Padding(4);
            this.ChkHdd.Name = "ChkHdd";
            this.ChkHdd.Size = new System.Drawing.Size(167, 20);
            this.ChkHdd.TabIndex = 5;
            this.ChkHdd.Text = "Disque dur numérique";
            this.ChkHdd.UseVisualStyleBackColor = true;
            // 
            // ChkLink
            // 
            this.ChkLink.AutoSize = true;
            this.ChkLink.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkLink.Location = new System.Drawing.Point(462, 61);
            this.ChkLink.Margin = new System.Windows.Forms.Padding(4);
            this.ChkLink.Name = "ChkLink";
            this.ChkLink.Size = new System.Drawing.Size(176, 20);
            this.ChkLink.TabIndex = 6;
            this.ChkLink.Text = "Lien de téléchargement";
            this.ChkLink.UseVisualStyleBackColor = true;
            // 
            // LblPrenom
            // 
            this.LblPrenom.AutoSize = true;
            this.LblPrenom.Location = new System.Drawing.Point(448, 41);
            this.LblPrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPrenom.Name = "LblPrenom";
            this.LblPrenom.Size = new System.Drawing.Size(65, 16);
            this.LblPrenom.TabIndex = 23;
            this.LblPrenom.Text = "Prénom :";
            // 
            // LblAdresse
            // 
            this.LblAdresse.AutoSize = true;
            this.LblAdresse.Location = new System.Drawing.Point(27, 75);
            this.LblAdresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAdresse.Name = "LblAdresse";
            this.LblAdresse.Size = new System.Drawing.Size(68, 16);
            this.LblAdresse.TabIndex = 23;
            this.LblAdresse.Text = "Adresse :";
            // 
            // LblCp
            // 
            this.LblCp.AutoSize = true;
            this.LblCp.Location = new System.Drawing.Point(421, 75);
            this.LblCp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCp.Name = "LblCp";
            this.LblCp.Size = new System.Drawing.Size(92, 16);
            this.LblCp.TabIndex = 23;
            this.LblCp.Text = "Code postal :";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(463, 108);
            this.LblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(50, 16);
            this.LblEmail.TabIndex = 23;
            this.LblEmail.Text = "Email :";
            // 
            // LblVille
            // 
            this.LblVille.AutoSize = true;
            this.LblVille.Location = new System.Drawing.Point(577, 75);
            this.LblVille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblVille.Name = "LblVille";
            this.LblVille.Size = new System.Drawing.Size(42, 16);
            this.LblVille.TabIndex = 24;
            this.LblVille.Text = "Ville :";
            // 
            // LblGsm
            // 
            this.LblGsm.AutoSize = true;
            this.LblGsm.Location = new System.Drawing.Point(216, 108);
            this.LblGsm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblGsm.Name = "LblGsm";
            this.LblGsm.Size = new System.Drawing.Size(69, 16);
            this.LblGsm.TabIndex = 28;
            this.LblGsm.Text = "Portable :";
            // 
            // LblTel
            // 
            this.LblTel.AutoSize = true;
            this.LblTel.Location = new System.Drawing.Point(10, 108);
            this.LblTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTel.Name = "LblTel";
            this.LblTel.Size = new System.Drawing.Size(84, 16);
            this.LblTel.TabIndex = 27;
            this.LblTel.Text = "Téléphone :";
            // 
            // TxtGsm
            // 
            this.TxtGsm.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.TxtGsm.Location = new System.Drawing.Point(293, 103);
            this.TxtGsm.Margin = new System.Windows.Forms.Padding(4);
            this.TxtGsm.MaxLength = 10;
            this.TxtGsm.Name = "TxtGsm";
            this.TxtGsm.Size = new System.Drawing.Size(99, 26);
            this.TxtGsm.TabIndex = 6;
            // 
            // TxtTel
            // 
            this.TxtTel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.TxtTel.Location = new System.Drawing.Point(97, 103);
            this.TxtTel.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTel.MaxLength = 10;
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(99, 26);
            this.TxtTel.TabIndex = 5;
            // 
            // LblVendeur
            // 
            this.LblVendeur.AutoSize = true;
            this.LblVendeur.Location = new System.Drawing.Point(57, 18);
            this.LblVendeur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblVendeur.Name = "LblVendeur";
            this.LblVendeur.Size = new System.Drawing.Size(69, 16);
            this.LblVendeur.TabIndex = 29;
            this.LblVendeur.Text = "Vendeur :";
            // 
            // GrpCoordonnees
            // 
            this.GrpCoordonnees.Controls.Add(this.TxtAdresse);
            this.GrpCoordonnees.Controls.Add(this.TxtNom);
            this.GrpCoordonnees.Controls.Add(this.TxtPrenom);
            this.GrpCoordonnees.Controls.Add(this.TxtGsm);
            this.GrpCoordonnees.Controls.Add(this.TxtCp);
            this.GrpCoordonnees.Controls.Add(this.TxtTel);
            this.GrpCoordonnees.Controls.Add(this.TxtVille);
            this.GrpCoordonnees.Controls.Add(this.LblVille);
            this.GrpCoordonnees.Controls.Add(this.TxtEmail);
            this.GrpCoordonnees.Controls.Add(this.LblNom);
            this.GrpCoordonnees.Controls.Add(this.LblTel);
            this.GrpCoordonnees.Controls.Add(this.LblAdresse);
            this.GrpCoordonnees.Controls.Add(this.LblEmail);
            this.GrpCoordonnees.Controls.Add(this.LblPrenom);
            this.GrpCoordonnees.Controls.Add(this.LblCp);
            this.GrpCoordonnees.Controls.Add(this.LblGsm);
            this.GrpCoordonnees.Location = new System.Drawing.Point(31, 47);
            this.GrpCoordonnees.Name = "GrpCoordonnees";
            this.GrpCoordonnees.Size = new System.Drawing.Size(859, 162);
            this.GrpCoordonnees.TabIndex = 1;
            this.GrpCoordonnees.TabStop = false;
            this.GrpCoordonnees.Text = "Coordonnées";
            // 
            // GrpElements
            // 
            this.GrpElements.BackColor = System.Drawing.SystemColors.Control;
            this.GrpElements.Controls.Add(this.RbtDvdPapier);
            this.GrpElements.Controls.Add(this.RbtPersoDvdInternet);
            this.GrpElements.Controls.Add(this.TxtNbBobines);
            this.GrpElements.Controls.Add(this.TxtNbCassettes);
            this.GrpElements.Controls.Add(this.TxtNbUnitCond);
            this.GrpElements.Controls.Add(this.TxtNbDiapos);
            this.GrpElements.Controls.Add(this.TxtNbPhotos);
            this.GrpElements.Controls.Add(this.TxtNbNegatifs);
            this.GrpElements.Controls.Add(this.LblNbCassettes);
            this.GrpElements.Controls.Add(this.LblNbBobines);
            this.GrpElements.Controls.Add(this.LblPersoDvd);
            this.GrpElements.Controls.Add(this.LblNbNegatifs);
            this.GrpElements.Controls.Add(this.LblNbPhotos);
            this.GrpElements.Controls.Add(this.LblNbDiapos);
            this.GrpElements.Controls.Add(this.LblUnitCond);
            this.GrpElements.Location = new System.Drawing.Point(31, 215);
            this.GrpElements.Name = "GrpElements";
            this.GrpElements.Size = new System.Drawing.Size(859, 187);
            this.GrpElements.TabIndex = 31;
            this.GrpElements.TabStop = false;
            this.GrpElements.Text = "Eléments déposés";
            // 
            // RbtDvdPapier
            // 
            this.RbtDvdPapier.AutoSize = true;
            this.RbtDvdPapier.Location = new System.Drawing.Point(728, 33);
            this.RbtDvdPapier.Name = "RbtDvdPapier";
            this.RbtDvdPapier.Size = new System.Drawing.Size(92, 20);
            this.RbtDvdPapier.TabIndex = 3;
            this.RbtDvdPapier.Text = "Sur papier";
            this.RbtDvdPapier.UseVisualStyleBackColor = true;
            // 
            // RbtPersoDvdInternet
            // 
            this.RbtPersoDvdInternet.AutoSize = true;
            this.RbtPersoDvdInternet.Checked = true;
            this.RbtPersoDvdInternet.Location = new System.Drawing.Point(622, 33);
            this.RbtPersoDvdInternet.Name = "RbtPersoDvdInternet";
            this.RbtPersoDvdInternet.Size = new System.Drawing.Size(100, 20);
            this.RbtPersoDvdInternet.TabIndex = 2;
            this.RbtPersoDvdInternet.TabStop = true;
            this.RbtPersoDvdInternet.Text = "Sur internet";
            this.RbtPersoDvdInternet.UseVisualStyleBackColor = true;
            // 
            // LblNbCassettes
            // 
            this.LblNbCassettes.AutoSize = true;
            this.LblNbCassettes.Location = new System.Drawing.Point(217, 35);
            this.LblNbCassettes.Name = "LblNbCassettes";
            this.LblNbCassettes.Size = new System.Drawing.Size(171, 16);
            this.LblNbCassettes.TabIndex = 10;
            this.LblNbCassettes.Text = "Nombre de CASSETTES :";
            // 
            // LblNbBobines
            // 
            this.LblNbBobines.AutoSize = true;
            this.LblNbBobines.Location = new System.Drawing.Point(17, 35);
            this.LblNbBobines.Name = "LblNbBobines";
            this.LblNbBobines.Size = new System.Drawing.Size(148, 16);
            this.LblNbBobines.TabIndex = 8;
            this.LblNbBobines.Text = "Nombre de BOBINES :";
            // 
            // LblPersoDvd
            // 
            this.LblPersoDvd.AutoSize = true;
            this.LblPersoDvd.Location = new System.Drawing.Point(433, 35);
            this.LblPersoDvd.Name = "LblPersoDvd";
            this.LblPersoDvd.Size = new System.Drawing.Size(174, 16);
            this.LblPersoDvd.TabIndex = 12;
            this.LblPersoDvd.Text = "Personnalisation du DVD :";
            // 
            // LblNbNegatifs
            // 
            this.LblNbNegatifs.AutoSize = true;
            this.LblNbNegatifs.Location = new System.Drawing.Point(501, 146);
            this.LblNbNegatifs.Name = "LblNbNegatifs";
            this.LblNbNegatifs.Size = new System.Drawing.Size(107, 16);
            this.LblNbNegatifs.TabIndex = 16;
            this.LblNbNegatifs.Text = "Nb de négatifs :";
            // 
            // LblNbPhotos
            // 
            this.LblNbPhotos.AutoSize = true;
            this.LblNbPhotos.Location = new System.Drawing.Point(508, 112);
            this.LblNbPhotos.Name = "LblNbPhotos";
            this.LblNbPhotos.Size = new System.Drawing.Size(100, 16);
            this.LblNbPhotos.TabIndex = 15;
            this.LblNbPhotos.Text = "Nb de photos :";
            // 
            // LblNbDiapos
            // 
            this.LblNbDiapos.AutoSize = true;
            this.LblNbDiapos.Location = new System.Drawing.Point(508, 78);
            this.LblNbDiapos.Name = "LblNbDiapos";
            this.LblNbDiapos.Size = new System.Drawing.Size(99, 16);
            this.LblNbDiapos.TabIndex = 14;
            this.LblNbDiapos.Text = "Nb de diapos :";
            // 
            // LblUnitCond
            // 
            this.LblUnitCond.AutoSize = true;
            this.LblUnitCond.Location = new System.Drawing.Point(26, 78);
            this.LblUnitCond.Name = "LblUnitCond";
            this.LblUnitCond.Size = new System.Drawing.Size(190, 16);
            this.LblUnitCond.TabIndex = 13;
            this.LblUnitCond.Text = "Nb unités conditionnements :";
            // 
            // GrpSupports
            // 
            this.GrpSupports.Controls.Add(this.LblCopiesSupp);
            this.GrpSupports.Controls.Add(this.ChkDvdStandard);
            this.GrpSupports.Controls.Add(this.ChkDvdPersonnalise);
            this.GrpSupports.Controls.Add(this.ChkMontageAvi);
            this.GrpSupports.Controls.Add(this.ChkCleUsb);
            this.GrpSupports.Controls.Add(this.TxtCopiesSupp);
            this.GrpSupports.Controls.Add(this.ChkLink);
            this.GrpSupports.Controls.Add(this.ChkHdd);
            this.GrpSupports.Location = new System.Drawing.Point(31, 408);
            this.GrpSupports.Name = "GrpSupports";
            this.GrpSupports.Size = new System.Drawing.Size(859, 127);
            this.GrpSupports.TabIndex = 32;
            this.GrpSupports.TabStop = false;
            this.GrpSupports.Text = "Supports de restitution";
            // 
            // LblCopiesSupp
            // 
            this.LblCopiesSupp.AutoSize = true;
            this.LblCopiesSupp.Location = new System.Drawing.Point(45, 85);
            this.LblCopiesSupp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCopiesSupp.Name = "LblCopiesSupp";
            this.LblCopiesSupp.Size = new System.Drawing.Size(99, 16);
            this.LblCopiesSupp.TabIndex = 24;
            this.LblCopiesSupp.Text = "Copies supp. :";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(787, 557);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(103, 34);
            this.BtnSave.TabIndex = 99;
            this.BtnSave.TabStop = false;
            this.BtnSave.Text = "OK";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(678, 557);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(103, 34);
            this.BtnCancel.TabIndex = 33;
            this.BtnCancel.TabStop = false;
            this.BtnCancel.Text = "Annuler";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // OrderEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 607);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.GrpSupports);
            this.Controls.Add(this.GrpElements);
            this.Controls.Add(this.GrpCoordonnees);
            this.Controls.Add(this.CbxVendeur);
            this.Controls.Add(this.LblVendeur);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderEditForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Commande Forever";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderEditForm_FormClosed);
            this.GrpCoordonnees.ResumeLayout(false);
            this.GrpCoordonnees.PerformLayout();
            this.GrpElements.ResumeLayout(false);
            this.GrpElements.PerformLayout();
            this.GrpSupports.ResumeLayout(false);
            this.GrpSupports.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.ComboBox CbxVendeur;
        private System.Windows.Forms.TextBox TxtPrenom;
        private System.Windows.Forms.TextBox TxtAdresse;
        private System.Windows.Forms.TextBox TxtCp;
        private System.Windows.Forms.TextBox TxtVille;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtNbBobines;
        private System.Windows.Forms.TextBox TxtNbCassettes;
        private System.Windows.Forms.TextBox TxtNbUnitCond;
        private System.Windows.Forms.TextBox TxtNbDiapos;
        private System.Windows.Forms.TextBox TxtNbPhotos;
        private System.Windows.Forms.TextBox TxtNbNegatifs;
        private System.Windows.Forms.CheckBox ChkDvdStandard;
        private System.Windows.Forms.CheckBox ChkDvdPersonnalise;
        private System.Windows.Forms.CheckBox ChkMontageAvi;
        private System.Windows.Forms.TextBox TxtCopiesSupp;
        private System.Windows.Forms.CheckBox ChkCleUsb;
        private System.Windows.Forms.CheckBox ChkHdd;
        private System.Windows.Forms.CheckBox ChkLink;
        private System.Windows.Forms.Label LblPrenom;
        private System.Windows.Forms.Label LblAdresse;
        private System.Windows.Forms.Label LblCp;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblVille;
        private System.Windows.Forms.Label LblGsm;
        private System.Windows.Forms.Label LblTel;
        private System.Windows.Forms.TextBox TxtGsm;
        private System.Windows.Forms.TextBox TxtTel;
        private System.Windows.Forms.Label LblVendeur;
        private System.Windows.Forms.GroupBox GrpCoordonnees;
        private System.Windows.Forms.GroupBox GrpElements;
        private System.Windows.Forms.GroupBox GrpSupports;
        private System.Windows.Forms.RadioButton RbtDvdPapier;
        private System.Windows.Forms.RadioButton RbtPersoDvdInternet;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label LblCopiesSupp;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LblNbBobines;
        private System.Windows.Forms.Label LblNbCassettes;
        private System.Windows.Forms.Label LblPersoDvd;
        private System.Windows.Forms.Label LblNbNegatifs;
        private System.Windows.Forms.Label LblNbPhotos;
        private System.Windows.Forms.Label LblNbDiapos;
        private System.Windows.Forms.Label LblUnitCond;
    }
}