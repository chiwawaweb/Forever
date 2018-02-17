namespace Forever.Forms
{
    partial class OrderToPdf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderToPdf));
            this.pdfDoc = new AxAcroPDFLib.AxAcroPDF();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.TsbPrint = new System.Windows.Forms.ToolStripButton();
            this.TsbClose = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pdfDoc)).BeginInit();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pdfDoc
            // 
            this.pdfDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfDoc.Enabled = true;
            this.pdfDoc.Location = new System.Drawing.Point(0, 29);
            this.pdfDoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pdfDoc.Name = "pdfDoc";
            this.pdfDoc.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfDoc.OcxState")));
            this.pdfDoc.Size = new System.Drawing.Size(687, 745);
            this.pdfDoc.TabIndex = 0;
            // 
            // ToolStrip
            // 
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbPrint,
            this.TsbClose});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(687, 25);
            this.ToolStrip.TabIndex = 1;
            // 
            // TsbPrint
            // 
            this.TsbPrint.Image = global::Forever.Properties.Resources.icon_print_24;
            this.TsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbPrint.Name = "TsbPrint";
            this.TsbPrint.Size = new System.Drawing.Size(76, 22);
            this.TsbPrint.Text = "Imprimer";
            this.TsbPrint.Click += new System.EventHandler(this.TsbPrint_Click);
            // 
            // TsbClose
            // 
            this.TsbClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TsbClose.Image = global::Forever.Properties.Resources.icon_close_24;
            this.TsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbClose.Name = "TsbClose";
            this.TsbClose.Size = new System.Drawing.Size(64, 22);
            this.TsbClose.Text = "Fermer";
            this.TsbClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.TsbClose.Click += new System.EventHandler(this.TsbClose_Click);
            // 
            // OrderToPdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 774);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.pdfDoc);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderToPdf";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Aperçu avant impression";
            ((System.ComponentModel.ISupportInitialize)(this.pdfDoc)).EndInit();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF pdfDoc;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton TsbPrint;
        private System.Windows.Forms.ToolStripButton TsbClose;
    }
}