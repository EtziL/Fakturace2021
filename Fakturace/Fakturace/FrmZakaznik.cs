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
    public partial class FrmZakaznik : Form
    {
        private List<Zakaz> zakaznik;
        private SqlRepository sqlRepository;
        private string[] sloupce = new string[] { "IdZakaznik, TypZak, Adresa, ICO, Email,Telefon,Jmeno,Prijmeni" };
        public FrmZakaznik()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Etzler-Fakturace;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        private void FrmZakaznik_Load(object sender,EventArgs e)
        {
            ZobrazData();
        }

        private void ZobrazData()
        {

            zakaznik = sqlRepository.NactiZakaznik();
            listView1.Items.Clear();
            foreach (var zakaz in zakaznik)
            {
                listView1.Items.Add(zakaz.GetListViewItem());
            }

        }

        
        
    }
}
