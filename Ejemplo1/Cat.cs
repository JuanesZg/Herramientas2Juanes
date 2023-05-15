using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Cat : DomesticAnimal
    {
        //Implement abstract method - set the data for the abstract method with the override
        public override string sound()
        {
            return "Miau Miau";
        }

        public void view_sound_cat()
        {
            Console.WriteLine(sound());
        }
    }
}
