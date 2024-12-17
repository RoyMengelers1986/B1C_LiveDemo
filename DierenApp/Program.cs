using DierenApp.Models;

namespace DierenApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dier olifant = new Dier();
            olifant.Naam = "Hendrik";
            olifant.AantalPoten = 4;
            olifant.HeeftStaart = true;
            olifant.Geluid = "PFFVVOOOEEEWW";

            Console.WriteLine($"{olifant.Naam}, {olifant.AantalPoten}");
            Console.ReadLine();

            //Dier hond = new Dier { 
            //     Naam = "Max",
            //     AantalPoten = 4,
            //     Geluid = "Woef Woef!",
            //     HeeftStaart = true,
            //};

            //Console.WriteLine($"{hond.Naam}, {hond.Geluid}");
            //Console.ReadLine();

            Dier kat = new Dier("Felix", 4, "Miauw, Miauw!", true);

            Console.WriteLine($"{kat.Naam}, {kat.Geluid}");

            olifant.AantalPoten = 2;

            Console.WriteLine($"{olifant.Naam}, {olifant.AantalPoten}");
            Console.ReadLine();

            //List<string> kleuren = new List<string>();
            //kleuren.Add("rood");
        }
    }
}
