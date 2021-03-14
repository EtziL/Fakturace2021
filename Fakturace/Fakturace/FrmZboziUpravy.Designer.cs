namespace Fakturace
{
    partial class FrmZboziUpravy
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
            this.btStorno = new System.Windows.Forms.Button();
            this.btAkce = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJmeno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btStorno
            // 
            this.btStorno.Location = new System.Drawing.Point(220, 106);
            this.btStorno.Name = "btStorno";
            this.btStorno.Size = new System.Drawing.Size(70, 32);
            this.btStorno.TabIndex = 16;
            this.btStorno.Text = "Storno";
            this.btStorno.UseVisualStyleBackColor = true;
            this.btStorno.Click += new System.EventHandler(this.btStorno_Click_1);
            // 
            // btAkce
            // 
            this.btAkce.Location = new System.Drawing.Point(119, 106);
            this.btAkce.Name = "btAkce";
            this.btAkce.Size = new System.Drawing.Size(67, 32);
            this.btAkce.TabIndex = 15;
            this.btAkce.Text = "OK";
            this.btAkce.UseVisualStyleBackColor = true;
            this.btAkce.Click += new System.EventHandler(this.btAkce_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cena Bez DPH";
            // 
            // txtJmeno
            // 
            this.txtJmeno.Location = new System.Drawing.Point(119, 12);
            this.txtJmeno.Name = "txtJmeno";
            this.txtJmeno.Size = new System.Drawing.Size(171, 20);
            this.txtJmeno.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nazev";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(119, 41);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(171, 20);
            this.numericUpDown1.TabIndex = 18;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(119, 67);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 17);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Na skladě";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FrmZboziUpravy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 353);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btStorno);
            this.Controls.Add(this.btAkce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtJmeno);
            this.Controls.Add(this.label1);
            this.Name = "FrmZboziUpravy";
            this.Text = "FrmZboziUpravy";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStorno;
        private System.Windows.Forms.Button btAkce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJmeno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}