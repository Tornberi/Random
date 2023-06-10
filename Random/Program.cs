using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace RandomQuest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] massOrderBy;
            Random range = new Random();
            int rang = range.Next(20, 100);

            int[] mass = new int[rang];

            Random rnd = new Random();

            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(-100, 100);
            }

            Console.Write("Получаем последовательность случайных чисел: ");
            foreach (int i in mass)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine("");
            Random type = new Random();
            int typeId = type.Next(2);
            Console.WriteLine(typeId);

            if (typeId == 0)
            {
                Console.Write("Сортируем получееную выше последовательность по возрастанию: ");
                massOrderBy = mass.OrderBy(x => x).ToArray();
                foreach (int i in massOrderBy)
                {
                    Console.Write("{0} ", i);
                }
            }
            else
            {
                Console.Write("Сортируем полученную выше последовательность по убыванию: ");
                massOrderBy = mass.OrderByDescending(x => x).ToArray();
                foreach (int i in massOrderBy)
                {
                    Console.Write("{0} ", i);
                }
            }

            RestClient client = new RestClient();
            client.AddDefaultHeader("KeyDB", Convert.ToString(massOrderBy));
            // Данный пункт реализовать не вышло :(

            Console.Read();
        }
    }
}
