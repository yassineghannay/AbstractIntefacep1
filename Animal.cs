using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Part 1
namespace LabInterfaces
{
    abstract class Animal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Age { get; set; }

        public abstract void Eat();
        

    }


    class Dog:Animal
    {


        public override void Eat()
        {
            Console.WriteLine("Dog eats meat");
        }
    }

    class Cat : Animal 
    {
        public override void Eat()
        {
            Console.WriteLine("Cat eats mice");
        }
    }




}
