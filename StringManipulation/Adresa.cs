namespace StringManipulation
{
    public class Adresa : Entity
    {
        public string Grad { get; set; }
        public string Ulica { get; set; }
        public string PostanskiBroj { get; set; }
        public string Zemlja { get; set; }

        public override void LoadFromString(string content)
        {
            string[] contentParts = content.Split(',');
            string[] objectParts = contentParts[0].Split('-');
            this.Grad = objectParts[1].Split(':')[1];

            for (int i = 1; i < objectParts.Length; i++)
            {
                string[] keyValue = objectParts[i].Split(':');
                switch (keyValue[0])
                {
                    case "Ulica":
                        this.Ulica = keyValue[1];
                        break;
                    case "Postanski broj":
                        this.PostanskiBroj = keyValue[1];
                        break;
                    case "Zemlja":

                        this.Zemlja = keyValue[1];
                        break;
                   
                }
            }
        }
    }
}