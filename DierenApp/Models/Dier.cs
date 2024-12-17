namespace DierenApp.Models
{
    internal class Dier
    {
        public string Naam { get;  set; }
        public int AantalPoten { get; set; }
        public string Geluid { get;  set; }
        public bool HeeftStaart { get;  set; }
        public Dier()
        {
            
        }

        public Dier(string naam, int aantalPoten, string geluid, bool heeftStaart)
        {
            this.Naam = naam;
            this.Geluid = geluid;
            this.HeeftStaart = heeftStaart;
            this.AantalPoten = aantalPoten;
        }
    }
}
