using System;

namespace gymTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List Test");
            LinkedList list = new LinkedList();
            Node node = new Node(1);
            list.head = node;
            for (int i = 0; i <= 69; i++)
            {
                node = new Node(i);
                list.addNode(node);
            }
                

            list.printList();
        }
    }
}
