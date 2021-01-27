using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main()
        {
            LinkedList<string> list = new LinkedList<string>();

            list.AddFirst("первый");
            list.AddAfter(list.Last, "второй");
            list.AddAfter(list.Last, "третий");
            list.AddAfter(list.Last, "пятый");
            list.AddBefore(list.Last, "четвёртый");
            list.AddAfter(list.Last, "шестой");
            list.AddAfter(list.Last, "седьмой");
            list.AddAfter(list.Last, "восьмой");
            list.AddAfter(list.Last, "девятый");
            list.AddLast("десятый");

            list.Remove("пятый"); //удаление конкретного значения

            foreach (var lists in list)
            {
                Console.WriteLine(lists);
            }
            Console.ReadKey();
        }
    }
}
