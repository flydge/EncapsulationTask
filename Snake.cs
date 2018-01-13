using System.Collections.Generic;

namespace EncapsulationTask
{
    public class Snake:Animal
    {
        public Snake(List<string> wordsList, List<string> foodList, string movementType, int movementSpeed) : base(wordsList, foodList, movementType, movementSpeed)
        {
        }

        public override string Greeting()
        {
            return "SSsSsS"+WordsList[0] + WordsList[1] + WordsList[2];
        }

        public override string Parting()
        {
            return WordsList[2] + WordsList[1] + WordsList[0] + "SSsSsS";
        }

        public override string Threatening()
        {
            return WordsList[1] + "SSsSsS"+WordsList[1] + "SSsSsS" + WordsList[1];
        }

    }
}