using System;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;

namespace Queues
{
    public class Queue
    {
        private int _count;
        private int _max;
        private int _headPointer;
        private int _tailPointer = -1;
        public string[] queue;

        public Queue(string[] Queue, int length)
        {
            queue = Queue;
            _max = length;
        }

        public void Enqueue(string item)
        {
            if (_count == _max)
            {
                Console.WriteLine("Queue Overflow");
            }
                
            else
            {
                _tailPointer = (_tailPointer +1) % _max;
                queue[_tailPointer] = item;

                _count++;
            }
        }

        public void Dequeue()
        {
            if (_count == 0)
            {
                Console.WriteLine("Queue Underflow");
            }

            else
            {
                var output = queue[_headPointer];
                queue[_headPointer] = null;
                _headPointer = (_headPointer + 1) % _max;

                _count--;
                Print(output);
            }
        }

        private void Print(string output)
        {
            Console.WriteLine(output);
        }
    }
}