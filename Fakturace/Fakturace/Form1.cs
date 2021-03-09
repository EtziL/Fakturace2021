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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnZakaznik_Click(object sender, EventArgs e)
        {
            FrmZakaznik frmZakaznik = new FrmZakaznik();
            frmZakaznik.ShowDialog();
        }

        private void BtnZbozi_Click(object sender, EventArgs e)
        {
            FrmZbozi frmZbozi = new FrmZbozi();
            frmZbozi.ShowDialog();
        }

        private void BtnFakturace_Click(object sender, EventArgs e)
        {
            FrmFakturace frmFakturace = new FrmFakturace();
            frmFakturace.ShowDialog();
        }
    }
    
}
