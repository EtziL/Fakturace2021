using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fakturace
{
    public class Zbz
    {
        public int Id { get; set; }
        public string Nazev { get; set; }
        public int CenaBezDPH { get; set; }
        public bool NaSklade { get; set; }

        public Zbz (string nazev, int cenaBezDPH, bool naSklade)
        {
            Nazev = nazev;
            CenaBezDPH = cenaBezDPH;
            NaSklade = naSklade;
        }
        public Zbz(int id,string nazev, int cenaBezDPH, bool naSklade)
        {
            Id = id;
            Nazev = nazev;
            CenaBezDPH = cenaBezDPH;
            NaSklade = naSklade;
        }

        public ListViewItem GetListViewItem()
        {
            return new ListViewItem(new string[] { Id.ToString(), Nazev, CenaBezDPH.ToString(), NaSklade.ToString() });
        }
        
    }
}
