using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace series_analyzer
{
    internal class Program
    {
        static List<int> chekinArgs(string[] args1)
            {
                List<int> numbers;

                while (true)
                {
                    numbers = new List<int>();

                    foreach (string arg in args1)
                    {

                        if (int.TryParse(arg, out int num) && num > 0)
                        {
                            numbers.Add(num);
                        }
                    }

                    if (numbers.Count >= 3)
                        {
                            return numbers;
                        }
                    Console.WriteLine("The numbers are invalid, please enter again.");
                    args1 = Console.ReadLine().Split(' ');
                }
            }
        static void showMenu(List<int> number)


        {
            Console.WriteLine("menu:\na.Input a Series. (Replace the current series)");
            Console.WriteLine("b. Display the series in the order it was entered. ");
            Console.WriteLine("c. Display the series in the reversed order it was entered. ");
            Console.WriteLine("d. Display the series in sorted order (from low to high). ");
            Console.WriteLine("e. Display the Max value of the series. ");
            Console.WriteLine("f. Display the Min value of the series. ");
            Console.WriteLine("g. Display the Average of the series. ");
            Console.WriteLine("h. Display the Number of elements in the series. ");
            Console.WriteLine("i. Display the Sum of the series. ");
            Console.WriteLine("j. Exit. ");
        }
        static void Main(string[] args)
        {
           List<int> numbers = chekinArgs(args);
           showMenu(numbers);
        }
    }
       
}
