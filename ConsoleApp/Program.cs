using ConsoleApp.Logic;
using ConsoleApp.Logic.Interfaces;
using System;
using System.Linq;
using System.Collections.Generic;
using Unity;

namespace ConsoleApp
{
    class Program
    {
        static Func<Person, bool> lol;
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            container.RegisterType<IHouse, WoodenHouse>();


            HouseBuilder houseBuilder = new HouseBuilder(container.Resolve<IHouse>());
            houseBuilder.Build();

            List<Person> people = new List<Person>() { new Person("Test1", 10), new Person("Test2", 20) };

       
            people.Where(p => p.Age >= 8)
                .ToList()
                .ForEach(p => Console.WriteLine($"{p.ToString()}"));

            int[] mas = { 2, 5, 6, 6, 9 };

            mas.Reverse().ToList().ForEach(p => Console.WriteLine(p));

            Console.WriteLine(mas.Average());
            Console.WriteLine(lol);
            Console.ReadKey();
        }

    }
}
