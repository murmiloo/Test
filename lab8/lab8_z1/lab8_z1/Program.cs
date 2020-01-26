using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_z1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] slowa = new string[]
            {
                // Indeks od początku od końca
                "Już północ", // 0 ^10
                "cień", // 1 ^9
                "ponury", // 2 ^8
                "pół", // 3 ^7
                "świata", // 4 ^6
                "okrywa", // 5 ^5
                "A jeszcze", // 6 ^4
                "serce", // 7 ^3
                "zmysłom", // 8 ^2
                "spoczynku nie daje"
            };
            Console.WriteLine($"{slowa[^1]}");
            // 1: spoczynku nie daje

            string[] sonet1 = slowa[2..6];
            foreach (var slowo in sonet1)
                Console.Write($"< { slowo} >");
            Console.WriteLine();
            // 2: <ponury><pół><świata><okrywa>

            string[] sonet2 = words[^3..^0];
            foreach (var word in sonet2)
                Console.Write($"{slowo}");
            Console.WriteLine();
            // 3: sercezmysłomspoczynku nie daje

            string[] sonet3 = slowa[..];
            foreach (var word in sonet3)
                Console.Write($"{word}");
            Console.WriteLine();
            // 4_1: Już północcieńponurypółświataokrywaA jeszczesercezmysłomspoczynku nie daje

            string[] sonet4 = slowa[..5];
            foreach (var word in sonet4)
                Console.Write($"{word}");
            Console.WriteLine();
            // 4_2: Już północcieńponurypółświata

            string[] sonet5 = slowa[7..];
            foreach (var word in sonet5)
                Console.Write($"{word}");
            Console.WriteLine();
            // 4_3: sercezmysłomspoczynku nie daje

            Index stri = ^5;
            Console.WriteLine(slowa[stri]);
            // 5: okrywa

            Range fraza = 2..7;
            string[] tekst = slowa[fraza];
            foreach (var slowo in tekst)
                Console.Write($" {tekst} ");
            Console.WriteLine();
            // 6: ponury  pół  świata  okrywa  A jeszcze
        }
    }
}
