using System;
using System.Collections.Generic;
using System.Linq;
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
            Bear bear4 = new Bear(wordList, foodList,"swim",10,"brown");
            Bear bear6 = new Bear(wordList, foodList,"swim",10,"brown");
            Bear bear5 = new Bear(wordList, foodList,"medium",45,"white");
            
            Group<Bear> bearsGroup = new Group<Bear>();
            bearsGroup.GroupList.Add(bear1);
            bearsGroup.GroupList.Add(bear2);
            bearsGroup.GroupList.Add(bear3);
            bearsGroup.GroupList.Add(bear4);
            bearsGroup.GroupList.Add(bear5);
            bearsGroup.GroupList.Add(bear6);
            // Console.WriteLine(bearsGroup);
            
            //fishes
            Fish fish1 = new Fish(wordList,foodList,"swim",30, new List<string>()
                {"river" , "lake"});
            Fish fish2 = new Fish(wordList,foodList,"swim",35, new List<string>()
                {"the western Atlantic Ocean"});
            
            Group<Fish> fishGroup = new Group<Fish>(fish1,fish2);
            //Console.WriteLine(fishGroup);
            
            //Data access task
           
            var whiteBears = bearsGroup.GroupList
                .Where(bear => bear.Color == "white")
                .OrderBy(bear=>bear.MovementSpeed);
            foreach (var whiteBear in whiteBears)
            {
                Console.WriteLine(whiteBear);
            }

            var notWhiteFastestBear = bearsGroup.GroupList
                .Where(bear => bear.Color != "white")
                .OrderBy(bear => -bear.MovementSpeed)
                .Select(bear => bear).First();

            Console.WriteLine("Not white fastest bear:\n"+notWhiteFastestBear);


            var top2SlowestBears = bearsGroup.GroupList
                .OrderBy(bear => bear.MovementSpeed)
                .Take(2);

            Console.Write("Top 2 slowest bears:\n" + String.Join("......\n",top2SlowestBears));


            var brownBearsMoveTypes =
                from bear in bearsGroup.GroupList
                where bear.Color == "brown"
                select bear.MovementType.ToUpper();

            Console.WriteLine("Types of movement of brown bears without duplicates: " 
                              + String.Join(", ",brownBearsMoveTypes.Union(brownBearsMoveTypes)));
            
            
            

        }
    }
}