using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    public class Present
    {
        private string name;

        private List<string> releventInterests;

        public Present(string name, List<string> releventInterests)
        {
            this.releventInterests = releventInterests;
            this.name = name;

        }

        public string getName()
        {
            return name;
        }

        public List<string> getReleventInterests()
        {
            return releventInterests;
        }
    }
}
