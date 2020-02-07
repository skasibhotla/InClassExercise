using System;
using System.Collections.Generic;
using System.Text;

namespace InClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car Ford = new Car();
            //Ford.model = "Mustang";
            //Ford.color = "red";
            //Ford.year = 1969;

            //Car Opel = new Car();
            //Opel.model = "Astra";
            //Opel.color = "white";
            //Opel.year = 2005;

            Car Ford = new Car("Mustang", "Red", 1969);
            Car Opel = new Car("Astra", "White", 2005);
            Person me = new Person();
            Console.WriteLine(me.Name);

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);
        }
    }
}
