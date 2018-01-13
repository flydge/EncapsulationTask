using System;
using System.Collections.Generic;

namespace EncapsulationTask
{
    public class Animal:ICommunication,IFood,IMovement
    {
        public Animal(List<string> wordsList, List<string> foodList, string movementType, int movementSpeed)
        {
            WordsList = wordsList;
            FoodList = foodList;
            MovementType = movementType;
            MovementSpeed = movementSpeed;
        }

        public List<string> WordsList { get; set; }
        
        public virtual string Greeting()
        {
            throw new System.NotImplementedException();
        }

        public virtual string Parting()
        {
            throw new System.NotImplementedException();
        }

        public virtual string Threatening()
        {
            throw new System.NotImplementedException();
        }

        public List<string> FoodList { get; set; }
        public string MovementType { get; set; }
        public int MovementSpeed { get; set; }

       

        public override string ToString()
        {
            return "\n" + "Food: " + String.Join(";",FoodList) + "\n" + "Movement type: " + MovementType +
                   "\n" + "Movement speed: " + MovementSpeed + "\n" + "Greeting: " + Greeting() +
                   "\n" + "Parting: " + Parting() + "\n" + "Threating: " + Threatening() + "\n";

        }
    }
}