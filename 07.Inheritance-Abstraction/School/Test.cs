using System;

namespace School
{
    class Test
    {
        static void Main()
        {
            Discipline math = new Discipline();
            math.NumberLectures = 15;
            math.name = "Mathematics";
            Teacher Penka = new Teacher();
            Penka.name = "Penka";

            Console.WriteLine(Penka.name + math.name);
            
        }
    }
}
