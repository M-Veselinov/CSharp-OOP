using System;

namespace Animals
{
    abstract class Animal : ISound
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm an Animal");
        }
    }
}
