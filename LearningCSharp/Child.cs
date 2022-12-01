using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    public class Child
    {
        private int age;
        private string name;
        private List<string> interests;

        public Child (int age, string name, List<string> interests)
        {
            this.age = age;
            this.name = name;
            this.interests = interests;
        }

        public int getAge()
        {
            return age;
        }
        public string getName()
        {
            return name;
        }
        public List<string> getInterests()
        {
            return interests;
        }

        private List<Present> matchPresents(List<Present> presents)
        {
            List<Present> thisChildsPresents = new List<Present>();


            foreach (Present present in presents)
            {
                if (present.getReleventInterests().Intersect(interests) != null)
                {
                    thisChildsPresents.Add(present);
                }
            }
            return thisChildsPresents;
        }

        public void printPresents(List<Present> presents)
        {
            foreach (Present present in matchPresents(presents)) 
            {
                Console.WriteLine(present.getName());
            }
        }


    }
}
