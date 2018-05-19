namespace _01.SquareRoot
{
    using System;

    public class SquareRoot
    {
        public static void Main()
        {
            Console.Write("Insert an integer number: ");
            string str = Console.ReadLine();
            int num;

            try
            {
                num = int.Parse(str);

                if (num < 0)
                {
                    throw new ArithmeticException();
                }                     
                
                Console.WriteLine("Square root of {0} = {1}", num, Math.Sqrt(num));
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Number is negative!");
            }
            catch (FormatException) 
            {
                Console.WriteLine("Invalid number!");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
