using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Soldier
    {
        public int Id { get; set; }
        public int TeamId { get; set; }


        Random rand = new Random(DateTime.Now.Millisecond);

        public Soldier() => Id = rand.Next();
        public Soldier(int teamId)
        {
            Id = rand.Next();
            TeamId = teamId;
        }
        public Hero FollowHero(Hero hero) => hero;
        public void getFollowHero(Hero hero) => Console.WriteLine($"\nСолдат с ID = {Id} следует за героем с ID = {hero.Id}");
    }
}