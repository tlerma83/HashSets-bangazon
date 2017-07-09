using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> Showroom = new HashSet<string>();
            Showroom.Add("Pinto");
            Showroom.Add("Fiesta");
            Showroom.Add("Malibu");
            Showroom.Add("Altima");

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

            HashSet<string> UsedLot = new HashSet<string>();
            UsedLot.Add("Cherokee");
            UsedLot.Add("Mustang");

            // Combines Showrrom HashSet with UsedLot HashSet, Showroom. Count will now be 6
            Showroom.UnionWith(UsedLot);
            // remove one string
            Showroom.Remove("Cherokee");
            // Count will now be 5
            // Console.WriteLine(Showroom.Count);

            HashSet<string> JunkYard = new HashSet<string>();
            JunkYard.Add("Malibu");
            JunkYard.Add("Pinto");
            JunkYard.Add("Sol");
            JunkYard.Add("Clubman");

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
                // Console.WriteLine(Showroom.Count);
            }
        }
    }
}
