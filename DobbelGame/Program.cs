using DobbelGame.Models;

namespace DobbelGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beker beker = new Beker();
            int totaal = beker.Schudden();
            Console.WriteLine($"Het totaal aantal ogen is: {totaal}");
        }
    }
}
