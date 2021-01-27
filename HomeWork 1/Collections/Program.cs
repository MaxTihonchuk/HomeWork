using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main()
        {
            #region ArrayList
            var list = new ArrayList();

            list.Add("for");
            list.Add("example");
            list.Add(1);
            list.Add(2);

            list.Remove(1); //удалить объект

            foreach (var lists in list)
            {
                Console.WriteLine(lists);
            }

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            #endregion

            #region HashTable
            //var email = new Hashtable();

            //email.Add("max@max.net", "Max");
            //email.Add("yen@yen.net", "Yen");
            //email.Add("parents@family.net", "Parents");


            //try
            //{
            //    email.Add("max@max.net", "Oly"); //добавляем хэш-пару с существующим Key
            //    //email.Add("maxim@max.net", "Max"); //добавляем хэш-пару с существующим Value
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //Console.WriteLine(new string('-', 10));

            //foreach (DictionaryEntry name in email)
            //{
            //    Console.WriteLine($"Key:{name.Key}, Value:{name.Value}");
            //}





            #endregion

            #region Queue
            //var queue = new Queue();

            //queue.Enqueue("Первый");
            //queue.Enqueue("Второй");
            //queue.Enqueue(3);

            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine("вывели первого удалили его из очереди \n");

            //Console.WriteLine(queue.Peek());
            //Console.WriteLine("показали кто первый в очереди и оставили его в очереди \n");

            //foreach (var queues in queue)
            //{
            //    Console.WriteLine(queues);
            //}

            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue()); //вывели всех из очереди (чередь пуста)
            //}
            #endregion

            #region Stack 

            //Stack stack = new Stack();

            //stack.Push("Первый");
            //stack.Push("Второй");
            //stack.Push(3);
            //stack.Push(4.22);

            //Console.WriteLine(stack.Pop()); //показывает первый объект в Stack и удаляет его
            //Console.WriteLine(stack.Peek()); //показывает первый объект в Stack и не удаляет его

            //Console.WriteLine(new string ('-', 10));

            //foreach (var stacks in stack)
            //{
            //    Console.WriteLine(stacks);
            //}


            #endregion

            Console.ReadKey();
        }
    }
}
