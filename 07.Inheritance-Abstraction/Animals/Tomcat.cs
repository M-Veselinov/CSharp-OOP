using System;

namespace Animals
{
    class Tomcat : Cat
    {
        new public string Gender = "male";
        new public void ProduceSound()
        {
            Console.WriteLine("I'm a Tomcat");
        }
    }
}
