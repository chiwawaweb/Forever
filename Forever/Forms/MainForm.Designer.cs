﻿namespace Forever.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.TsbNewOrder = new System.Windows.Forms.ToolStripButton();
            this.TsbView = new System.Windows.Forms.ToolStripButton();
            this.TsbPrint = new System.Windows.Forms.ToolStripButton();
            this.TsbRetour = new System.Windows.Forms.ToolStripButton();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fichiersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DgvOrders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.miseÀJourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStrip
            // 
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbNewOrder,
            this.TsbView,
            this.TsbPrint,
            this.TsbRetour});
            this.ToolStrip.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(628, 31);
            this.ToolStrip.TabIndex = 0;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // TsbNewOrder
            // 
            this.TsbNewOrder.Image = global::Forever.Properties.Resources.icon_new_24;
            this.TsbNewOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbNewOrder.Name = "TsbNewOrder";
            this.TsbNewOrder.Size = new System.Drawing.Size(146, 28);
            this.TsbNewOrder.Text = "Nouvelle commande";
            this.TsbNewOrder.Click += new System.EventHandler(this.TsbNewOrder_Click);
            // 
            // TsbView
            // 
            this.TsbView.Image = global::Forever.Properties.Resources.icon_consulter_24;
            this.TsbView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbView.Name = "TsbView";
            this.TsbView.Size = new System.Drawing.Size(84, 28);
            this.TsbView.Text = "Visualiser";
            this.TsbView.Click += new System.EventHandler(this.TsbView_Click);
            // 
            // TsbPrint
            // 
            this.TsbPrint.Image = global::Forever.Properties.Resources.icon_print_24;
            this.TsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbPrint.Name = "TsbPrint";
            this.TsbPrint.Size = new System.Drawing.Size(97, 28);
            this.TsbPrint.Text = "Réimprimer";
            this.TsbPrint.Click += new System.EventHandler(this.TsbPrint_Click);
            // 
            // TsbRetour
            // 
            this.TsbRetour.Image = global::Forever.Properties.Resources.icon_valider_24;
            this.TsbRetour.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbRetour.Name = "TsbRetour";
            this.TsbRetour.Size = new System.Drawing.Size(70, 28);
            this.TsbRetour.Text = "Retour";
            this.TsbRetour.Click += new System.EventHandler(this.TsbRetour_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StatusStrip.Location = new System.Drawing.Point(0, 462);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.StatusStrip.Size = new System.Drawing.Size(628, 22);
            this.StatusStrip.SizingGrip = false;
            this.StatusStrip.TabIndex = 1;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichiersToolStripMenuItem,
            this.toolStripMenuItem2});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MenuStrip.Size = new System.Drawing.Size(628, 24);
            this.MenuStrip.TabIndex = 3;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fichiersToolStripMenuItem
            // 
            this.fichiersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paramètresToolStripMenuItem,
            this.toolStripMenuItem1,
            this.quitterToolStripMenuItem});
            this.fichiersToolStripMenuItem.Name = "fichiersToolStripMenuItem";
            this.fichiersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichiersToolStripMenuItem.Text = "Fichier";
            // 
            // paramètresToolStripMenuItem
            // 
            this.paramètresToolStripMenuItem.Name = "paramètresToolStripMenuItem";
            this.paramètresToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.paramètresToolStripMenuItem.Text = "Paramètres";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(130, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // DgvOrders
            // 
            this.DgvOrders.AllowUserToAddRows = false;
            this.DgvOrders.AllowUserToDeleteRows = false;
            this.DgvOrders.AllowUserToOrderColumns = true;
            this.DgvOrders.AllowUserToResizeColumns = false;
            this.DgvOrders.AllowUserToResizeRows = false;
            this.DgvOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvOrders.Location = new System.Drawing.Point(0, 90);
            this.DgvOrders.Margin = new System.Windows.Forms.Padding(2);
            this.DgvOrders.MultiSelect = false;
            this.DgvOrders.Name = "DgvOrders";
            this.DgvOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvOrders.RowTemplate.Height = 28;
            this.DgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvOrders.ShowCellErrors = false;
            this.DgvOrders.ShowCellToolTips = false;
            this.DgvOrders.ShowEditingIcon = false;
            this.DgvOrders.ShowRowErrors = false;
            this.DgvOrders.Size = new System.Drawing.Size(628, 374);
            this.DgvOrders.TabIndex = 5;
            this.DgvOrders.TabStop = false;
            this.DgvOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOrders_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Recherche :";
            // 
            // TxtSearch
            // 
            this.TxtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtSearch.Location = new System.Drawing.Point(87, 62);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(244, 22);
            this.TxtSearch.TabIndex = 7;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(337, 60);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(77, 26);
            this.BtnSearch.TabIndex = 8;
            this.BtnSearch.Text = "Chercher";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miseÀJourToolStripMenuItem,
            this.toolStripMenuItem3,
            this.aProposToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem2.Text = "?";
            // 
            // miseÀJourToolStripMenuItem
            // 
            this.miseÀJourToolStripMenuItem.Name = "miseÀJourToolStripMenuItem";
            this.miseÀJourToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.miseÀJourToolStripMenuItem.Text = "Mise à jour...";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(149, 6);
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aProposToolStripMenuItem.Text = "A propos...";
            // 
            // MainForm
            // 
            this.AcceptButton = this.BtnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 484);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvOrders);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Forever";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripButton TsbNewOrder;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fichiersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.DataGridView DgvOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.ToolStripButton TsbView;
        private System.Windows.Forms.ToolStripButton TsbPrint;
        private System.Windows.Forms.ToolStripButton TsbRetour;
        private System.Windows.Forms.ToolStripMenuItem paramètresToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem miseÀJourToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
    }
}