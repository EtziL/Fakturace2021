namespace Fakturace
{
    partial class FrmZakaznik
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.IdZakaznik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypZak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ICO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Jmeno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prijmeni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdZakaznik,
            this.TypZak,
            this.Adresa,
            this.ICO,
            this.email,
            this.telefon,
            this.Jmeno,
            this.Prijmeni});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(5, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(783, 445);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // IdZakaznik
            // 
            this.IdZakaznik.Text = "Id";
            // 
            // TypZak
            // 
            this.TypZak.Text = "Typ Zákazníka";
            // 
            // Adresa
            // 
            this.Adresa.Text = "Adresa";
            // 
            // ICO
            // 
            this.ICO.Text = "IČO";
            // 
            // email
            // 
            this.email.Text = "e-mail";
            // 
            // telefon
            // 
            this.telefon.Text = "Telefon";
            // 
            // Jmeno
            // 
            this.Jmeno.Text = "Jméno";
            // 
            // Prijmeni
            // 
            this.Prijmeni.Text = "Příjmení";
            // 
            // FrmZakaznik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Name = "FrmZakaznik";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader IdZakaznik;
        private System.Windows.Forms.ColumnHeader TypZak;
        private System.Windows.Forms.ColumnHeader Adresa;
        private System.Windows.Forms.ColumnHeader ICO;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader telefon;
        private System.Windows.Forms.ColumnHeader Jmeno;
        private System.Windows.Forms.ColumnHeader Prijmeni;
    }
}