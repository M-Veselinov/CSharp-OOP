using System;


    class EnterNumbers
    {
        public static int ReadNumber(int start, int end)
        {

            string input = Console.ReadLine();
            int a = 0; ;
            try
            {
                a = Convert.ToInt32(input);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Invalid Number");
            }

            if (a < start)
            {
                throw new Exception("Number must be between interval start-end");
            }
            if (a > end)
            {
                throw new Exception("Number must be between interval start-end");
            }
            return a;
        }
        static void Main()
        {
            try
            {
                ReadNumber(5, 10);
                ReadNumber(2, 10);
                ReadNumber(15, 20);
                ReadNumber(20, 30);
                ReadNumber(30, 40);
                ReadNumber(50, 60);
                ReadNumber(70, 180);
                ReadNumber(90, 110);
                ReadNumber(100, 120);
                ReadNumber(110, 130);
            }
            catch (Exception ex) 
            {
                Console.WriteLine("You entered invalid number.Please try again");
                ReadNumber(5, 10);
            }
        }
    }

