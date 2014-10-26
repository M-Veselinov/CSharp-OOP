using System;

namespace Animals
{
    class Dog : Animal
    {
        
        new public void ProduceSound()
        {
            Console.WriteLine("I'm a Dog");
        }
    }
}
