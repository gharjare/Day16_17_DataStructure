using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrucureAlgorithm
{
    public class OrderdList
    {
        Node head;
        public class Node
        {
            int data;
            readonly Node next;

            public Node(int data)
            {    
                this.data = data;
                this.next = null;
            }
        }
        
        public void addfirst(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
            return;
        }
        public void sortByNumber()
        {

            
            Node currNode = head, index = null;

            int temp;

            if (head == null)
            {
                return;
            }
            else
            {
                while (currNode != null)
                {
                    index = currNode.next;

                    while (index != null)
                    {
                        if (currNode.data > index.data)
                        {
                            temp = currNode.data;
                            currNode.data = index.data;
                            index.data = temp;
                        }

                        index = index.next;
                    }
                    currNode = currNode.next;
                }
            }
        }
        
        public void printlist()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }
            Node currNode = head;
            while (currNode != null)
            {
                Console.WriteLine(currNode.data + "->");
                currNode = currNode.next;
            }
            Console.WriteLine("null");

        }
    }
}
