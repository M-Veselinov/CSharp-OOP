using System;

namespace CompanyHierarchy
{
    class Test
    {
        static void Main()
        {
            
            Sale Stanka = new Sale("Shokolad",24,"24.02.2014");
            Sale[] arr = { Stanka };
            SalesEmployee Mario = new SalesEmployee(arr);
            double salary = Mario.arr[0].Price;
            Console.WriteLine(salary);
            Project Game = new Project("Tower Defense","15.04","RPG Game");
            Console.WriteLine(Game.State);
            Project[] projArr = { Game };
            Developer Marioo = new Developer(projArr);
            Console.WriteLine(Marioo.arr[0].State);
        }
    }
}
