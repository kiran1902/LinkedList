using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedLis<Gtype>
    {
        Node<Gtype> head = null;

        public void Add(Gtype Data)
        {
            //creating a temp variable and storing it the count in it  
            Node<Gtype> temp_node;

            //creating a node with data
            Node<Gtype> node = new Node<Gtype>(Data);

            if (head == null) 
            { 
                head = node;
            }
            else
            {
                temp_node = head;
                while (temp_node.next != null)
                {
                    temp_node = temp_node.next;
                }
                temp_node.next = node;
            }
        }

        public void Pat_Pos(Gtype Data, int Pos)
        {
            //creating a Temp variable
            Node<Gtype> temp_node = head;
            int size = Size();

            if(Pos > size + 1  || Pos < 1)
            {
                Console.WriteLine("Invalid Position");
                return;
            }

            //Creating new node
            Node<Gtype> node = new Node<Gtype>(Data);

            if (head == null)
            {
                Console.WriteLine("List is Empty");
                if (Pos == 1)
                {
                    head = node;
                }
                else
                {
                    Console.WriteLine("Invalid Position");
                }
            }
            else
            {
                int count = 1;
                while (Pos > count + 1)
                {
                    temp_node = temp_node.next;
                    count++;
                }
                Node<Gtype> temp_node2 = temp_node.next;
                temp_node.next = node;
                node.next = temp_node2;
            }

        }

        public void Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty");
               
            }
            else if (head.next == null)
            {
                head = null;
            }
            else
            {
                head = head.next;
            }
           
        }

        public void Pop_Last(int pos)
        {

            //variable
            Node<Gtype> temp_node = head;
            int size = Size();

            if (pos > size + 1 || pos < 1)
            {
                Console.WriteLine("Invalid Position");
                return;
            }
            if (pos == 1)
            {
                head = temp_node.next;

            }
            else
            {
                int count = 1;
                while (pos > count + 1)
                {
                    temp_node = temp_node.next;
                    count++;
                }
                Node<Gtype> temp_node2 = temp_node.next.next;
                temp_node.next = temp_node2;
            }
        }

        public bool IsEmpty()
        {
            if (head is null) return true;
            else return false;
        }

        public int Size()
        {

            if (head == null)
            {
                Console.WriteLine("List is Empty");
                return 0;
            }
            else
            {
                int count = 1;
                Node<Gtype> temp_node = head;
                Console.WriteLine(temp_node.val);
                while (temp_node.next != null)
                {
                    count++;
                    temp_node = temp_node.next;
                }
                return count;
            }
        }

        public int Search(int value)
        {
            Node<Gtype> node = head;

            while (node != null)
            {
                if (node.data == value)
                {
                    Console.WriteLine("Node is Present");
                    return value;
                }
                node = node.next;
            }
            return value;
        }

        public void Display()
        {
            if (head is null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            else
            {
                //created temp variable and the node display start from head 
                Node<Gtype> temp_node = head;
                Console.WriteLine(temp_node.val);

                while (temp_node.next != null)
                {
                    Console.WriteLine(temp_node.next.val);
                    temp_node = temp_node.next;
                }
            }

        }
    }


}
