using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    abstract class DomesticAnimal
    {
        //Properties
        public string ID { get; set; }
        //public short Age { get; set; }
        short age;
        public short Age
        {
            get
            {
                return age;
            }

            set
            {
                if(value >= 1 && value <= 5)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age not valid");
                }
            }
        }


        //Methods
        public void to_run()
        {
            //Return "Is running"
            Console.WriteLine("is running");
        }

        //Structure definition for child classes
        public abstract string sound();

        //Set the method for all classes 
        /* public string sound()
         * {
         *  return "?";
         * }
         */
    }
}
