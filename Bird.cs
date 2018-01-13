using System.Collections.Generic;

namespace EncapsulationTask
{
    public class Bird:Animal
    {
        public Bird(List<string> wordsList, List<string> foodList, string movementType, int movementSpeed) : base(wordsList, foodList, movementType, movementSpeed)
        {
        }

        public override string Greeting()
        {
            return "Chiric"+ WordsList[0] + "Chiric"+ WordsList[1] + WordsList[2];
        }

        public override string Parting()
        {
            return WordsList[2] + "Chiric"+ WordsList[1] + WordsList[0];
        }

        public override string Threatening()
        {
            return WordsList[1] + WordsList[1] + "Chiric"+ WordsList[1];
        }

    }
}