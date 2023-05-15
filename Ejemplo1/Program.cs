// See https://aka.ms/new-console-template for more information
using Ejemplo1;

Console.WriteLine("Hello, World!");

Console.WriteLine("Enter an Animal Code (1. Dog, 2. Cat or 0. Exit)");
short AnimalCode = short.Parse(Console.ReadLine());

while (AnimalCode != 0)
{
    Console.WriteLine("Type an ID");
    string animalId = Console.ReadLine();

    Console.WriteLine("Type an age");
    short animalAge = short.Parse(Console.ReadLine());
    switch (AnimalCode)
    {
        case 1:
            var MyDog = new Dog()
            {
                ID = animalId,
                Age = animalAge
            };
            Console.WriteLine($"The Dog data is Id {MyDog.ID} and Age {MyDog.Age}");
            MyDog.view_sound_dog();
            break;
        case 2:
            var MyCat = new Cat()
            {
                ID = animalId,
                Age = animalAge
            };
            Console.WriteLine($"The Cat data is Id {MyCat.ID} and Age {MyCat.Age}");
            MyCat.view_sound_cat();
            break;
        default:
            Console.WriteLine("Domestic Animal does not exist");
            break;
    }

}