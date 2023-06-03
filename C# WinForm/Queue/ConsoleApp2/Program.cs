using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.Enqueue(100);
            queue.Enqueue(-25);
            queue.Enqueue(33);
            Console.WriteLine($"{queue.Dequeue()}");
            Console.WriteLine($"{queue.Dequeue()}");
            Console.WriteLine($"{queue.Dequeue()}");
        }
        class Queue
        {
            private const int DEFAULTQUESIZE = 100;
            private int[] data;
            private int head = 0, tail = 0;
            private int numElements = 0;
            public Queue()  => this.data = new int[DEFAULTQUESIZE];
            public Queue(int size)
            {
                if (size > 0) this.data = new int[size];
                else throw new ArgumentOutOfRangeException("size", "Must be greater than zero");
            }
            
            public void Enqueue(int item)
            {
                if(this.numElements == this.data.Length)
                {
                    throw new Exception("Queue Full");
                }
                this.data[this.head] = item;
                this.head++;
                this.head %= DEFAULTQUESIZE;
                this.numElements++;
            }

            public int Dequeue()
            {
                if(this.numElements ==  0)
                {
                    throw new Exception("Queuw empty");
                }

                int queueItem = this.data[this.tail];
                this.tail++;
                this.tail %= this.data.Length;
                this.numElements--;
                return queueItem;
            }
        }
    }
}
