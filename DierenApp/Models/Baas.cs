namespace DierenApp.Models
{
    internal class Baas
    {
        public string Naam { get; private set; }
        public List<Dier> HuisDieren { get; private set; }

        public Baas(string naam,  List<Dier> huisDieren)
        {
            Naam = naam;
            HuisDieren = huisDieren;
        }
    }
}
