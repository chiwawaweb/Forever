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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsbPrint = new System.Windows.Forms.ToolStripButton();
            this.TsbClose = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pdfDoc)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pdfDoc
            // 
            this.pdfDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfDoc.Enabled = true;
            this.pdfDoc.Location = new System.Drawing.Point(0, 26);
            this.pdfDoc.Name = "pdfDoc";
            this.pdfDoc.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfDoc.OcxState")));
            this.pdfDoc.Size = new System.Drawing.Size(627, 616);
            this.pdfDoc.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbPrint,
            this.TsbClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(627, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TsbPrint
            // 
            this.TsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("TsbPrint.Image")));
            this.TsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbPrint.Name = "TsbPrint";
            this.TsbPrint.Size = new System.Drawing.Size(76, 22);
            this.TsbPrint.Text = "Imprimer";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 642);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pdfDoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderToPdf";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Aperçu avant impression";
            ((System.ComponentModel.ISupportInitialize)(this.pdfDoc)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF pdfDoc;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsbPrint;
        private System.Windows.Forms.ToolStripButton TsbClose;
    }
}