using System;

namespace Animals
{
    class Kitten : Cat
    {
        new public string Gender = "female";
        new public void ProduceSound()
        {
            Console.WriteLine("I'm a Kitten");
        }
    }
}
