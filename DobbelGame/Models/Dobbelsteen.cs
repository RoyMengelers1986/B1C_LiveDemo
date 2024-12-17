namespace DobbelGame.Models
{
    internal class Dobbelsteen
    {
        public int MinAantal { get; private set; }
        public int MaxAantal { get; private set; }

        public Dobbelsteen(int minAantal, int maxAantal)
        {
            MinAantal = minAantal;
            MaxAantal = maxAantal;
        }

        public int Dobbel()
        {
            Random ogen = new Random();
            return ogen.Next(MinAantal, MaxAantal + 1);
        }
    }
}
