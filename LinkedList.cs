using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21julyLinkedListEx
{
    public class LinkedList
    {
        public Node head;
        public LinkedList()
        {
            head = null;
        }
        public void PrintLList()
        {
            Node temp = new Node();
            temp = this.head;
            if(temp!=null)
            {
                Console.WriteLine("The List Contains");
                while(temp != null)
                {
                    Console.WriteLine(temp.data +" ");
                    temp = temp.next;
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("This L List is empty");
            }
        }
    }
}
