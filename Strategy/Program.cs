using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countTeams = 2;
            int soldiersCount = 10;

            Random rand = new Random(DateTime.Now.Millisecond);

            List<Hero> heroes = new List<Hero>(countTeams);
            List<List<Soldier>> soldiers = new List<List<Soldier>>(countTeams);

            Soldier soldier = new Soldier();

            for (int i = 0; i < countTeams; i++)
            {
                heroes.Add(new Hero(i));
                soldiers.Add(new List<Soldier>());
            }
            for (int i = 0; i < soldiersCount; i++)
            {
                int teamId = rand.Next(0, countTeams);
                System.Threading.Thread.Sleep(1);

                soldier.FollowHero(heroes[teamId]);
                soldiers[teamId].Add(soldier);
            }
            int maxSoldiers = 0;
            int currentHero = 0;
            for (int i = 0; i < countTeams; i++)
            {
                int count = soldiers[i].Count;

                if (soldiers[i].Count > maxSoldiers)
                {
                    maxSoldiers = soldiers[i].Count; 
                    currentHero = i;
                }

                Console.WriteLine($"\nГерой #{i + 1}, ID {heroes[i].Id}, его команда:");
                for(int j = 0; j < count; j++) Console.WriteLine($"{j + 1}. ID солдата {soldiers[i][j].Id}");
            }

            if(maxSoldiers != 0) heroes[currentHero].LevelUp();
            else Console.WriteLine("Никто не повывил уровень.");

            // Отправьте одного из солдат первого героя следовать за ним.
            // Выведите на экран идентификационные номера этих двух юнитов.
            soldier.getFollowHero(heroes[0]);

            Console.ReadLine();
        }
    }
}