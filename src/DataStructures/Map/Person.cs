using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Map
{
    public class Person
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public string Reward { get; set; }

        public Person(string name, int score, string reward)
        {
            Name = name;
            Score = score;
            Reward = reward; 
        }
    }
}
