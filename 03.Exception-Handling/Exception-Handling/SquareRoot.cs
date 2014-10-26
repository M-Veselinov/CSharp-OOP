using System;


    class Program
    {
        static void Main()
        {
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                double sqrt = Math.Sqrt(a);
                Console.WriteLine(sqrt);
            }
            catch (System.FormatException) // Catches exception if the input is not a number
            {
                Console.WriteLine("Invalid number");
            }
            catch (System.OverflowException) // Catches exception if the input out of integer scope
            {
                Console.WriteLine("Invalid number");
            }
            catch (System.ArgumentNullException) // Catches exception if the input is null
            {
                Console.WriteLine("Invalid number");
            }
            catch (System.ArithmeticException) // Catches exception if the input is negative integer
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }

