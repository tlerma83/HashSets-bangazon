using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> Showroom = new HashSet<string>() {
                "Pinto", "Fiesta", "Malibu", "Altima"
            };
            
            // the count will show 4
            // Console.WriteLine(Showroom.Count);

            // adding same string item 
            Showroom.Add("Pinto");

            // if Count were logged out it, the Count would still be 4
            // Looping over Showroom shows no duplicates of the same name were created
            // foreach (string car in Showroom)
            // {
            //     Console.WriteLine(car);      
            // }

            HashSet<string> UsedLot = new HashSet<string>(){
                "Cherokee", "Mustang"
            };


            // Combines Showrrom HashSet with UsedLot HashSet, Showroom. Count will now be 6
            Showroom.UnionWith(UsedLot);
            Showroom.Remove("Cherokee");
            // Count will now be 5
            // Console.WriteLine(Showroom.Count);

            HashSet<string> JunkYard = new HashSet<string>(){
                "Malibu", "Pinto", "Sol", "Clubman"
            };

            // Showroom.IntersectWith(JunkYard);
            // Loop through Showroom to see which car-strings were the same, can also check the count of the overlapping
            // foreach (string item in Showroom) {
            //     Console.WriteLine(item);
            //     Console.WriteLine(Showroom.Count);
            // }

            JunkYard.Remove("Sol");

            Showroom.UnionWith(JunkYard);

            // Had to comment out the IntersectWith in order for the UnionWith to console out
            foreach (string car in Showroom) {
                Console.WriteLine(car);
            }
        }
    }
}
