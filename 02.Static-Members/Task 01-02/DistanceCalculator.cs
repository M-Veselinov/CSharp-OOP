using System;


    static class DistanceCalculator
    {
        public static double Distance(Point p1,Point p2)
        {
            double deltaX = p1.x - p2.x;
            double deltaY = p1.y - p2.y;
            double deltaZ = p1.z - p2.z;
            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
            return distance;
        }
    }

