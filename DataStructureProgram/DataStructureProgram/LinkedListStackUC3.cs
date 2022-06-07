using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems
{
    public class LinkedListQueue
    {
        private Node front;
        private Node rear;
        public LinkedListQueue()
        {
            this.front = this.rear = null;
        }
        internal void Enqueue(int value)
        {
            Node node = new Node(value);
            if (this.rear == null)
            {
                this.front = this.rear = node;
            }
            else
            {
                this.rear.next = node;
                this.rear = node;
            }

            Console.WriteLine("{0} inserted into Queue", value);
        }
        internal void Display()
        {
            Node temp = this.front;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }

    }
}