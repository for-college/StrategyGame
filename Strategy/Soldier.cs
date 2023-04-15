using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Strategy
{
    public class Soldier : Person
    {
        public int TeamId { get; set; }

        public Soldier() : base() { }

        public Hero FollowHero(Hero hero) => hero;
        public void getFollowHero(Hero hero) => Console.WriteLine($"\nСолдат с ID = {Id} следует за героем с ID = {hero.Id}.");
    }
}