using System;
using System.Collections.Generic;

namespace EncapsulationTask
{
    public class Group<T> where T: Animal
    {
        private List<T> groupList;
        
        public Group()
        {
            groupList = new List<T>();
        }
        
        public Group(params T[] animal)
        {
            groupList = new List<T>(animal);
        }
        

        public List<T> GroupList
        {
            get => groupList;
            set => groupList = value;
        }
        
        
        public override string ToString()
        {
            return String.Join("\n",GroupList);
        }
    }
}