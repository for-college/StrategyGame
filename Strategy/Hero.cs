using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Hero
    {
        public int Id { get; set; }
        public int TeamId { get; set; }

        public int lvl = 1;

        Random rand = new Random(DateTime.Now.Millisecond);
        public Hero() => Id = rand.Next();
        public Hero(int teamId) 
        {
            Id = rand.Next();
            System.Threading.Thread.Sleep(1);
            TeamId = teamId;
        }
        public void LevelUp() => lvl++;
    }
}
