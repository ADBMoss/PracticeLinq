using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{VGamesOrganize()}"); 
        }

        public static string VGamesOrganize()
        {
            var vGames = new List<string>() {
                "Mortal Kombat",
                "Tekken",
                "Super Smash Bros",
                "The Last of Us",
                "Resident Evil",
                "GTA 5",
                "Need 4 Speed",
                "Madden",
                "NBA 2k"
            };

            foreach (var game in vGames)
            {
                var result = vGames.OrderByDescending(x => x.Length).ToList();
                foreach (var game2 in result)
                {
                    Console.WriteLine(game2);
                }
                break;
            }
            return null;
        }
    }
}
