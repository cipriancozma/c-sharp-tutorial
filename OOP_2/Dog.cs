using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    public class Dog :  Animal
    {
        public void AboutDog()
        {
            SetAnimalColor("white");
            SetAnimalAge(4);
            Eat("bones");
        }
    }
}
