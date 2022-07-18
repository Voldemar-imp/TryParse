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
            int number = EnterToConvert();
            Console.Clear();
            Console.WriteLine("Вы ввели число: " + number);
        }

        static int EnterToConvert()
        {             
            int number = 0;
            bool isContinue = true;

            while (isContinue)
            {
                Console.Write("Введите целое число: ");
                string userInput = Console.ReadLine();

                bool success = int.TryParse(userInput, out number);
                if (success== false)
                {              
                    Console.WriteLine($"Введенное значение: '{userInput}' не явлеяется целым числом, поробуйте еще раз.");
                }         
                
                isContinue = !success;
            }

            return number;
        }
    }
}
