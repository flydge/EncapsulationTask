using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EncapsulationTask
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            List<string> wordList = new List<string>()
            {
                "hi", "bye bye", "i kill u"
            };
            
            List<String> foodList = new List<string>()
            {
                "meat", "fish", "berries"
            };
            
            //bears
            Bear bear1 = new Bear(wordList, foodList,"faster",54,"white");
            Bear bear2 = new Bear(wordList, foodList,"slowly",36,"black");
            Bear bear3 = new Bear(wordList, foodList,"medium",45,"brown");
            
            Group<Bear> bearsGroup = new Group<Bear>();
            bearsGroup.GroupList.Add(bear1);
            bearsGroup.GroupList.Add(bear3);
            bearsGroup.GroupList.Add(bear2);

            Console.WriteLine(bearsGroup);
            
            //fishes
            Fish fish1 = new Fish(wordList,foodList,"swim",30, new List<string>()
                {"river" , "lake"});
            Fish fish2 = new Fish(wordList,foodList,"swim",35, new List<string>()
                {"the western Atlantic Ocean"});
            
            Group<Fish> fishGroup = new Group<Fish>(fish1,fish2);
            Console.WriteLine(fishGroup);
            
            
        }
    }
}