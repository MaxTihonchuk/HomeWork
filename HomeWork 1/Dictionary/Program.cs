using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main()
        {
            //я не знаю как реализовать через интерфейсы

            Dictionary<int, string> number = new Dictionary<int, string>();

            number.Add(1, "первый");
            number.Add(2, "второй");
            number.Add(3, "третий");
            number.Add(4, "четвёртый");
            number.Add(5, "пятый");
            number.Add(6, "шестой");

            foreach (var numbers in number)
            {
                Console.WriteLine(numbers);
                //Console.WriteLine($"Key:{number.Keys} \tValue:{number.Values}");
            }
            Console.ReadKey();
        }
    }
}
