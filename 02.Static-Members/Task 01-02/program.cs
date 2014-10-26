using System;

    class program
    {
        static void Main()
        {
            Point point = new Point(5, 10, 15);
            Point point2 = new Point(10, 15, 20);

            double distance = DistanceCalculator.Distance(point,point2);

            Console.WriteLine(distance);
        }
    }

