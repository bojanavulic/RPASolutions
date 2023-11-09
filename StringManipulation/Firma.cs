namespace StringManipulation
{
    public class Firma: Entity

    {
        public string Naziv { get; set; }
        public string AdresaFirme { get; set; }

        public override void LoadFromString(string content)
        {
            string[] contentParts = content.Split(',');
            string[] objectParts = contentParts[0].Split('-');
            this.Naziv = objectParts[1].Split(':')[1];

            for (int i = 1; i < objectParts.Length; i++)
            {
                string[] keyValue = objectParts[i].Split(':');
                if (keyValue[0].Contains("Adresa firme"))
                {
                    this.AdresaFirme = keyValue[1];
                }
                
            }
        }
    }
}