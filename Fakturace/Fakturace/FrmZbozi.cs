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
    public partial class FrmZbozi : Form
    {
        private List<Zbz> zbozi;        
        private SqlRepository sqlRepository;
        private string[] sloupce = new string[] { "IdZbozi, Nazev, CenaBezDPH,NaSklade" };
        public FrmZbozi()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Etzler-Fakturace;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        private void FrmKnihy_Load(object sender, EventArgs e)
        {
            ZobrazData();
        }
        private void ZobrazData()
        {

            zbozi = sqlRepository.NactiZbozi();
            listView2.Items.Clear();
            foreach (var zbz in zbozi)
            {
                listView2.Items.Add(zbz.GetListViewItem());
            }

        }

        private void přidatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmZboziUpravy frmZboziUpravy = new FrmZboziUpravy(new Zbz("",0,true));
            if (frmZboziUpravy.ShowDialog() == DialogResult.OK)
            {
                sqlRepository.UlozZbozi(frmZboziUpravy.Zbz);
                //ctenari.Add(frmCtenariUpravy.Ctenar);
                ZobrazData();
            }
        }

        private void upravitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedIndices.Count > 0)
            {
                FrmZboziUpravy frmZboziUpravy = new FrmZboziUpravy(zbozi[listView2.SelectedIndices[0]]);
                if (frmZboziUpravy.ShowDialog() == DialogResult.OK)
                {
                    ZobrazData();
                }
            }
            else
            {
                MessageBox.Show("Vyberte záznam");
            }
        }
    }
}
