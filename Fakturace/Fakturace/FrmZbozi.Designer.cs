namespace Fakturace
{
    partial class FrmZbozi
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
            this.listView2 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nazev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CenaBezDPH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NaSklade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Nazev,
            this.CenaBezDPH,
            this.NaSklade});
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(0, 3);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(788, 426);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Nazev
            // 
            this.Nazev.Text = "Název";
            this.Nazev.Width = 194;
            // 
            // CenaBezDPH
            // 
            this.CenaBezDPH.Text = "CenaBezDPH";
            this.CenaBezDPH.Width = 133;
            // 
            // NaSklade
            // 
            this.NaSklade.Text = "Na skladě";
            // 
            // FrmZbozi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView2);
            this.Name = "FrmZbozi";
            this.Text = "FrmZbozi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Nazev;
        private System.Windows.Forms.ColumnHeader CenaBezDPH;
        private System.Windows.Forms.ColumnHeader NaSklade;
    }
}