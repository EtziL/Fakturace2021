using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fakturace
{
    public class Zakaz
    {
        public int Id { get; set; }
        public string TypZak { get; set; }
        public string Adresa { get; set; }
        public int ICO { get; set; }
        public string Email { get; set; }
        public int Telefon { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        
        

        public Zakaz(string typZak,string adresa, int ico, string email, int telefon, string jmeno, string prijmeni)
        {
            TypZak = typZak;
            Adresa = adresa;
            ICO = ico;
            Email = email;
            Telefon = telefon;
            Jmeno = jmeno;
            Prijmeni = prijmeni;         
            
            
        }

        public Zakaz(int id,string typZak, string adresa, int ico, string email, int telefon, string jmeno, string prijmeni)
        {
            Id = id;
            TypZak = typZak;
            Adresa = adresa;
            ICO = ico;
            Email = email;
            Telefon = telefon;
            Jmeno = jmeno;
            Prijmeni = prijmeni;
        }
        public ListViewItem GetListViewItem()
        {
            return new ListViewItem(new string[] { Id.ToString(), TypZak, Adresa, ICO.ToString(), Email, Telefon.ToString(),Jmeno, Prijmeni });
        }
    }
}
