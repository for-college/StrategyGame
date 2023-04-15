using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Hero : Person
    {
        public int TeamId { get; set; }

        public int lvl = 1;

        public Hero() : base() { }
        public Hero(int teamId) 
        {
            System.Threading.Thread.Sleep(1);
            TeamId = teamId;
        }
        public void LevelUp() => lvl++;
    }
}
