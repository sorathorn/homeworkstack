using System;

namespace hwstackqueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue AP = new Queue();
            Queue AQ = new Queue();
            Queue BP = new Queue();
            Queue CR = new Queue();
            Queue AP = new Queue();
            Queue AR = new Queue();
            Queue AS = new Queue();
            Queue AQ = new Queue();
            Queue ER = new Queue();

            AP.Enqueue(1);
            AQ.Enqueue(2);
            BP.Enqueue(3);
            CR.Enqueue(4);
            AP.Enqueue(5);
            AR.Enqueue(6);
            AS.Enqueue(7);
            AQ.Enqueue(8);
            ER.Enqueue(9);
        }
    }

    class Node
    {
        public char data;
        public Node()
        {

        }
    }

    class Queue
    {
        public Queue Left;
        public Queue Right;
        
        public Queue()
        {

        }
    }

    class Pop
    {

    }
}
