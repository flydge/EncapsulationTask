using System;
using System.Collections.Generic;

namespace EncapsulationTask
{
    public class Fish: Animal
    {
        private List<string> _waterList;
        
        public Fish(List<string> wordsList, List<string> foodList, string movementType, int movementSpeed, List<string> water) : base(wordsList, foodList, movementType, movementSpeed)
        {
            _waterList = water;
        }
        
        public List<string> WaterList
        {
            get => _waterList;
            set => _waterList = value;
        }

        public override string Greeting()
        {
            return WordsList[0] + WordsList[1] + WordsList[2];
        }

        public  override string Parting()
        {
            return WordsList[2] + WordsList[1] + WordsList[0];
        }

        public override string Threatening()
        {
            return WordsList[1] + WordsList[1] + WordsList[1];
        }


        public override string ToString()
        {
            return "Water: " + String.Join(";",WaterList) + base.ToString();
        }
    }
}