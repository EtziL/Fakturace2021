using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fakturace
{
    public partial class FrmZboziUpravy : Form
    {
        public Zbz Zbz { get; set; }
        public FrmZboziUpravy(Zbz zbz)
        {
            InitializeComponent();
            Zbz =zbz;
        }
        private void FrmZboziUpravy_Load(object sender, EventArgs e)
        {
            txtJmeno.Text = Zbz.Nazev;
            numericUpDown1.Value = Zbz.CenaBezDPH;
            checkBox1.Checked = Zbz.NaSklade;
        }

        private void btStorno_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btAkce_Click_1(object sender, EventArgs e)
        {
            Zbz.Nazev = txtJmeno.Text;
            Zbz.CenaBezDPH = Convert.ToInt32(numericUpDown1.Value);
            Zbz.NaSklade = checkBox1.Checked;
            DialogResult = DialogResult.OK;
        }
    }
}
