using System;
using System.Linq;

namespace Animals
{
   interface ISound
   {
        void ProduceSound();
   }

    class Test
    {
        static void Main()
        {
            Kitten kitten1 = new Kitten();
            kitten1.Age = 15;
            Kitten kitten2 = new Kitten();
            kitten2.Age = 12;
            Kitten kitten3 = new Kitten();
            kitten3.Age = 20;
            Kitten kitten4 = new Kitten();
            kitten4.Age = 25;
            Kitten kitten5 = new Kitten();
            kitten5.Age = 27;
            Kitten[] arr = new Kitten[5] { kitten1, kitten2, kitten3, kitten4, kitten5 };

            int result = 0;
            var numQuery =
            from kitten in arr
            where kitten.Age != 0
            select kitten;

            foreach (Kitten kitten in numQuery)
            {
                result += kitten.Age;
            }

            result = result / numQuery.Count();
            Console.WriteLine(result);
            Console.WriteLine(kitten5.Gender);
            
        }
    }
}
