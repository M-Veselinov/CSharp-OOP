using System;

namespace Animals
{
    class Cat : Animal
    {
        new public void ProduceSound()
        {
            Console.WriteLine("I'm a Cat");
        }
    }
}
