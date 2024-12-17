namespace DobbelGame.Models
{
    internal class Beker
    {
        public List<Dobbelsteen> Dobbelstenen { get; private set; }
        
        public Beker()
        {
            Dobbelstenen = new List<Dobbelsteen> { 
                new Dobbelsteen(1, 6),
                new Dobbelsteen(1, 6),
                new Dobbelsteen(1, 6),
                new Dobbelsteen(1, 6),
                new Dobbelsteen(1, 6)
            }; 
        }

        public int Schudden()
        {
            int totaal = 0;
            foreach (var dobeelSteen in Dobbelstenen)
            {
                totaal += dobeelSteen.Dobbel();
            }
            return totaal;
        }
    }
}
