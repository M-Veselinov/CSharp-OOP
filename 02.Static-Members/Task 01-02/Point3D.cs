using System;

    class Point
    {
        public int x;
        public int y;
        public int z;
        private static readonly Point startPoint;

        static Point()
        {
            Point.startPoint = new Point(0,0,0);
        }

        public Point(int X,int Y,int Z) 
        {
            this.x = X;
            this.y = Y;
            this.z = Z;
        }

        public static Point StartPoint
        {
            get { return startPoint; }
        }
        public override string ToString()
        {
            string result = "{";
            result += String.Format("{0}, {1}, {2}", this.x, this.y, this.z);
            result += "}";

            return result;
        }
    }

