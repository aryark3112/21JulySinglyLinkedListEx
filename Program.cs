using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21julyLinkedListEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Singly Linked List
            LinkedList linkedList = new LinkedList();
            Node first = new Node            //If I make it as Cooment From This Line to
            {
                data = 12,
                next = null
            };
            linkedList.head = first;
            Node second = new Node
            {
                data = 20,
                next = null
            };
            first.next = second;
            Node third = new Node
            {
                data = 30,
                next = null
            };
            second.next = third;             //This Line Then in Output Screen shows that the list is empty
            linkedList.PrintLList();
            Console.ReadKey();
        }
    }
}
