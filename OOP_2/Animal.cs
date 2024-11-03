using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    public class Animal
    {
        public void Eat(string foodType)
        {
            Console.WriteLine("This animal eat " + foodType);
        }

        public void SetAnimalColor(string color)
        {
            Console.WriteLine("The animal color is: " + color);
        }

        public void SetAnimalAge(int age)
        {
            Console.WriteLine("Animal age is: " + age);
        }

    }
}
