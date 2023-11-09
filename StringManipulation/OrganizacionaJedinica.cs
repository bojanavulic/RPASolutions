namespace StringManipulation
{
    public class OrganizacionaJedinica : Entity
    {
        public string Ime { get; set; }
        public string Oznaka { get; set; }
        public Adresa Adresa { get; set; }

        public override void LoadFromString(string content)
        {
            string[] contentParts = content.Split(',');
            string[] objectParts = contentParts[0].Split('-');
            this.Ime = objectParts[1].Split(':')[1];

            for (int i = 1; i < objectParts.Length; i++)
            {
                string[] keyValue = objectParts[i].Split(':');
                switch (keyValue[0])
                {
                    case "Oznaka":
                        this.Oznaka = keyValue[1];
                        break;
                }
            }
            int index = content.IndexOf("Adresa");
            string result = content.Substring(index, content.Length);

            this.Adresa.LoadFromString(result);

        }
    }
}