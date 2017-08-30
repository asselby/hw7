/*2.	Написать программу, которая обращается к элементам массива по индексу и выходит за его пределы. После обработки исключения вывести в финальном блоке сообщение
 * о завершении обработки массива.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[10];
            try
            {
                mas[9] = 12;
                mas[10] = 13;
                mas[11] = 100;
                foreach (int i in mas)
                {
                    Console.WriteLine(i);

                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Обработка массива завершена!");
            }
            Console.ReadLine();
        }
    }
}
