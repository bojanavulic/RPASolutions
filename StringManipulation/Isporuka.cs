namespace StringManipulation
{
    public class Isporuka : Entity
    {
        public string MestoIsporuke { get; set; }
        public string GLN { get; set; }
        public Firma Firma { get; set; }

        public override void LoadFromString(string content)
        {
            string[] contentParts = content.Split(',');
            string[] objectParts = contentParts[0].Split('-');
            this.MestoIsporuke = objectParts[1].Split(':')[1];

            for (int i = 1; i < objectParts.Length; i++)
            {
                string[] keyValue = objectParts[i].Split(':');
                switch (keyValue[0])
                {
                    case "GLN":
                        this.GLN = keyValue[1];
                        break;
                }
            }
            int index = content.IndexOf("Firma");
            string result = content.Substring(index, content.Length);

            this.Firma.LoadFromString(result);

        }
    }
}