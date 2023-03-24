using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_340_F22SD_LABS
{
    public class LinkedList<T>
    {
        public Node<T> Head { get; set; }

        public void AddData(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = Head;
            Head = newNode;
        }

        
        public void PrintData()
        {
            Node<T> current = Head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
        }
    }
}
