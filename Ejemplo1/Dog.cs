using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Dog : DomesticAnimal
    {
        //Implement abstract method - set the data for the abstract method with the override
        public override string sound()
        {
            return "Guau guau";
        }

        public void view_sound_dog()
        {
            Console.WriteLine(sound());
        }
    }
}
