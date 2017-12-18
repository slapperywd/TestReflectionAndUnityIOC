using ConsoleApp.Logic.Attributes;
using System;
using System.Linq;
using System.Reflection;

namespace ConsoleApp.Logic
{

    public class Person
    {
        [RegExp("blabla$")]
        public string Name { get; set; }

        [RegExp("^[1-9][0-8]$")]
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            Type person = this.GetType();

            //Get properties attributes
            var propertyAttr = person.GetProperties().Select(prop => prop.GetCustomAttribute(typeof(RegExpAttribute)));
            foreach (var attr in propertyAttr)
            {
                //write your logic here to handle 
                //propreties values 

                Console.WriteLine(((RegExpAttribute)attr).Expression);
            }
            return $"Name:{Name}\nAge:{Age}";
        }
    }
}
