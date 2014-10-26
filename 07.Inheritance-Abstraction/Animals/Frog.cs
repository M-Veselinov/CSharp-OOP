using System;
namespace Animals
{
    class Frog : Animal
    {
        new public void ProduceSound()
        {
            Console.WriteLine("I'm a Frog");
        }
    }
}
