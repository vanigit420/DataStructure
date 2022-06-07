using System.Collections;
using System.Collections.Generic;
namespace DataStructureProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Solving Problems on Stack and Queue");

            //LinkedListStack obj = new LinkedListStack();
            //obj.Push(70);
            //obj.Push(30);
            //obj.Push(56);

            //obj.Display();
            //obj.IsEmpty();

            LinkedListQueue queue = new LinkedListQueue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);

            queue.Display();
        }
    }
}