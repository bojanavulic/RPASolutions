namespace StringManipulation
{
    public class Platilac : Entity
    {
        public string BrojPlatioca { get; set; }
        public string PIB { get; set; }
        public string MB { get; set; }
        public string GLN { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }

        public override void LoadFromString(string content)
        {
            string[] contentParts = content.Split(',');
            string[] objectParts = contentParts[0].Split('-');
            this.BrojPlatioca = objectParts[1].Split(':')[1];

            for(int i = 1; i < objectParts.Length; i++)
            {
                string[] keyValue = objectParts[i].Split(':');
                switch (keyValue[0])
                {
                    case "PIB":
                            this.PIB = keyValue[1];
                break;
                        case "MB":
                            this.MB = keyValue[1];
                break;
                        case "GLN":

                            this.GLN = keyValue[1];
                break;
                        case "Naziv":

                            this.Naziv = keyValue[1];
                break;
                    case "Adresa":

                        this.Adresa = keyValue[1];
                        break;
                }
            }
        }
    }
}