using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Привествую тебя в моей мини-стратегии!\n");
            int countTeams = 0;
            int soldiersCount = 0;
            try
            {
                Console.Write("Введи количество команд: ");
                countTeams = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введи общее количество солдат: ");
                soldiersCount = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine($"\nОшибка: {ex.Message}\n");
                return;
            }

            Random rand = new Random();

            List<Hero> heroes = new List<Hero>(countTeams);
            List<List<Soldier>> soldiers = new List<List<Soldier>>(countTeams);

            for (int i = 0; i < countTeams; i++)
            {
                heroes.Add(new Hero(i));
                soldiers.Add(new List<Soldier>());
            }
            for (int i = 0; i < soldiersCount; i++)
            {
                Soldier soldier = new Soldier();
                int teamId = rand.Next(0, countTeams);

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

                Console.WriteLine($"\nГерой #{i + 1}, ID = {heroes[i].Id}, кол-во солдат в его отряде = {soldiers[i].Count}, его команда:");

                for(int j = 0; j < count; j++) Console.WriteLine($"{j + 1}. ID солдата {soldiers[i][j].Id}");
            }

            if(maxSoldiers != 0)
            {
                Console.WriteLine("\nОдин из героев поднял свой уровень!");
                heroes[currentHero].LevelUp();
                Console.WriteLine($"ID героя = {heroes[currentHero].Id}. Уровень героя = {heroes[currentHero].lvl}.");
            }
            else Console.WriteLine("Никто не повывил уровень.");

            // Отправьте одного из солдат первого героя следовать за ним.
            // Выведите на экран идентификационные номера этих двух юнитов.

            try
            {
                soldiers[0][1].getFollowHero(heroes[0]);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nОшибка: {ex.Message}\n");
                return;
            }

            Console.ReadLine();
        }
    }
}