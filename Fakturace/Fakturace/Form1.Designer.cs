namespace Fakturace
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnZakaznik = new System.Windows.Forms.Button();
            this.BtnZbozi = new System.Windows.Forms.Button();
            this.BtnFakturace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnZakaznik
            // 
            this.BtnZakaznik.Location = new System.Drawing.Point(74, 39);
            this.BtnZakaznik.Name = "BtnZakaznik";
            this.BtnZakaznik.Size = new System.Drawing.Size(144, 68);
            this.BtnZakaznik.TabIndex = 0;
            this.BtnZakaznik.Text = "Zákazníci";
            this.BtnZakaznik.UseVisualStyleBackColor = true;
            this.BtnZakaznik.Click += new System.EventHandler(this.BtnZakaznik_Click);
            // 
            // BtnZbozi
            // 
            this.BtnZbozi.Location = new System.Drawing.Point(224, 39);
            this.BtnZbozi.Name = "BtnZbozi";
            this.BtnZbozi.Size = new System.Drawing.Size(144, 68);
            this.BtnZbozi.TabIndex = 1;
            this.BtnZbozi.Text = "Zboží";
            this.BtnZbozi.UseVisualStyleBackColor = true;
            this.BtnZbozi.Click += new System.EventHandler(this.BtnZbozi_Click);
            // 
            // BtnFakturace
            // 
            this.BtnFakturace.Location = new System.Drawing.Point(374, 39);
            this.BtnFakturace.Name = "BtnFakturace";
            this.BtnFakturace.Size = new System.Drawing.Size(144, 68);
            this.BtnFakturace.TabIndex = 2;
            this.BtnFakturace.Text = "Fakturace";
            this.BtnFakturace.UseVisualStyleBackColor = true;
            this.BtnFakturace.Click += new System.EventHandler(this.BtnFakturace_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnFakturace);
            this.Controls.Add(this.BtnZbozi);
            this.Controls.Add(this.BtnZakaznik);
            this.Name = "Form1";
            this.Text = "Menu Fakturace";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnZakaznik;
        private System.Windows.Forms.Button BtnZbozi;
        private System.Windows.Forms.Button BtnFakturace;
    }
}

