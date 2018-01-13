using System;
using System.Collections.Generic;

namespace EncapsulationTask
{
    public class Bear:Animal
    {
        private string _color;

        public Bear(List<string> wordsList, List<string> foodList, string movementType, int movementSpeed, string color) : base(wordsList, foodList, movementType, movementSpeed)
        {
            _color = color;
        }


        public string Color
        {
            get => _color;
            set => _color = value;
        }

        public override string Greeting()
        {
            return "Rrrr" + "Rrrr"+WordsList[0] + WordsList[1] + WordsList[2];
        }

        public override string Parting()
        {
            return WordsList[2] + "Rrrr" + WordsList[1] + "Rrrr" + WordsList[0];
        }

        public override string Threatening()
        {
            return "Rrrr" + WordsList[1] + WordsList[1] + WordsList[1];
        }

        public override string ToString()
        {
            return "Color: " + Color + base.ToString();
        }
    }
}