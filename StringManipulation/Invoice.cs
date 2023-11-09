using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    public class Invoice : Entity
    {
        public string Otpremnica { get; set; }
        public string MaticniBroj { get; set; }
        public string PIB { get; set; }
        public OrganizacionaJedinica OrganizacionaJedinica { get; set; }
        public Isporuka Isporuka { get; set; }
        public Platilac Platilac { get; set; }
        public string Dospece { get; set; }
        public string DokumentVeze { get; set; }
        public double OsnovicaZaPDV { get; set; }
        public double IznosPDV { get; set; }
        public double ZaPovracaj { get; set; }

        public override void LoadFromString(string content)
        {
            string[] lines = content.Split('\n');

            foreach (string line in lines)
            {
                string[] keyValues = line.Split(':');
                if (keyValues.Length == 2 && !keyValues.Contains("-"))
                {
                    switch (keyValues[0])
                    {
                        case "Otpremnica":
                            this.Otpremnica = keyValues[1];
                            break;
                        case "Matični broj":
                            this.MaticniBroj = keyValues[1];
                            break;
                        case "PIB":

                            this.PIB = keyValues[1];
                            break;
                        case "Dospeće":

                            this.Dospece = keyValues[1];
                            break;
                        case "Osnovica za PDV":

                            this.OsnovicaZaPDV = double.Parse(keyValues[1]);
                            break;
                        case "Iznos PDV":

                            this.OsnovicaZaPDV = double.Parse(keyValues[1]);
                            break;
                        case "Za povraćaj":

                            this.ZaPovracaj = double.Parse(keyValues[1]);
                            break;

                    }
                }
                else
                {
                    string[] nameParts = keyValues[0].Split('-');
                    switch (nameParts[0].Trim())
                    {
                        case "Organizacionajedinica":
                            this.OrganizacionaJedinica = new OrganizacionaJedinica();
                            this.OrganizacionaJedinica.LoadFromString(line);
                            break;
                        case "Isporuka":
                            this.Isporuka = new Isporuka();
                            this.Isporuka.LoadFromString(line);
                            break;
                        case "Platilac":

                            this.Platilac = new Platilac();
                            this.Platilac.LoadFromString(line);
                            break;
                    }
                }
            }
        }
    }
}
