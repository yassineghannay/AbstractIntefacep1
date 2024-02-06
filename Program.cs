using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInterfaces
{
    internal class Program
    {
        static void Main(string[] args)

        {
            

            Console.Write("name for your dog: ");
            string dogName = Console.ReadLine();

           
            Dog dog = new Dog ();
            dog.Age = 13;
            dog.Name = dogName;
            dog.Colour = "white";

            Console.WriteLine($"your dogs age is { dog.Age} his name is  { dog.Name} , and his colour is  { dog.Colour} " );
            Console.ReadLine();




            Console.Write("name for your dog: ");
            string catName = Console.ReadLine();


            Cat cat  = new Cat();
            cat.Age = 6;
            cat.Name = catName;
            cat.Colour = "orange";

            Console.WriteLine($"your cats age is {cat.Age} his name is  {cat.Name} , and his colour is  {cat.Colour} ");
            Console.ReadLine();
        }
    }
}
