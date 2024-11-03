using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    public class Cat : Animal
    {
        public void AboutCat()
        {
            SetAnimalColor("black");
            SetAnimalAge(2);
            Eat("mouses");
        }
    }
}
