using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticVoid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = GetNumber();
            Console.Clear();
            Console.WriteLine("Вы ввели число: " + number);
        }

        static int GetNumber()
        {             
            int number = 0;
            bool success = false;

            while (success == false)
            {
                Console.Write("Введите целое число: ");
                string userInput = Console.ReadLine();

                success = int.TryParse(userInput, out number);
                if (success == false)
                {              
                    Console.WriteLine($"Введенное значение: '{userInput}' не явлеяется целым числом, поробуйте еще раз.");
                }
            }

            return number;
        }
    }
}
