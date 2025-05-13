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
        static List<int> numbers;
        static List<int> chekinArgs(string[] args1)
            {
                List<int> numbers;

                while(true)
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
            Console.WriteLine("\nmenu:\na.Input a Series. (Replace the current series)");
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
        static void start()
        {
            string choose = "";
            while (choose != "j")
            {
                showMenu(numbers);
                choose = Console.ReadLine();
                switch (choose)
                {
                    case "a":
                        changeSeries();
                        break;
                    case "b": 
                        showSereies();
                        break;
                    case "c":
                        revers();
                        break;
                    case "d":
                        sorted();
                        break;
                    case "e":
                        maxNum();
                        break;
                    case "f":
                        minNum();
                        break;
                    case "g":
                        average();
                        break;
                    case "h":
                        somNumbers();
                        break;
                    case "i":
                        totalnumbers();
                        break;
                    case "j":
                        exit();
                        break;
                    default:
                        Console.WriteLine("You have to choose only the letters 'a-j'");
                        break;
                }   

            }
        }
        static void changeSeries()

        {
            Console.WriteLine("entar new series");
            string[] input = Console.ReadLine().Split(' ');
            numbers = chekinArgs(input);
        }
        static void showSereies()
        {
            foreach (int number in numbers)
            {
                Console.Write(" " + number);
            }
        }
        static void revers()
        {
            for (int i = numbers.Count  -1; i >= 0; i--)
            {
                Console.Write(" " + numbers[i]);
            }
        }
        static void sorted()
        {
            for (int i = 0; i < numbers.Count-1; i++)
            {
                bool flags = false;
                for (int j = 0; j < numbers.Count - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                        flags = true;
                    }
                }if (!flags)
                {
                    break;
                }
       
            }

            foreach (int num in numbers)
                Console.Write(" "  + num);
        }
        static void maxNum()
        {
            int max = 0;
            foreach (int num in numbers) 
            {
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine($"the hight num is:{max}");
        }
        static void minNum()
        {
            int min = numbers[0];
            foreach(int num in numbers)
                if (num < min)
                {
                    min = num;
                }
            Console.WriteLine($"the lwo num is:{min}");  
        }
        static void average()
        {
            int number = 0;
            foreach (int num in numbers)
            {
                number += num;
            }    
            int total = number / numbers.Count;
            Console.WriteLine($" the averege is:{total}");


     
        }
        static void somNumbers()
        {
            int number = 0;
            foreach(int num in numbers)
                { 
                number += 1;
            }
            Console.WriteLine($"the som of numbers is:{ number}");
        }
        static void totalnumbers()
        {
            int som = 0;
            foreach(int num in numbers)
            {
                som += num;
            }
            Console.WriteLine($"the som all num is:{som}");
        }
        static void exit()
        {
            Console.WriteLine("good lack");
            Console.ReadLine();
        }
        
        static void Main(string[] args)
        {
            numbers = chekinArgs(args);
            start();
        }   
    }      
}


