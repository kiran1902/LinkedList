using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node<Gtype>
    {
        public Gtype val;
        public Node<Gtype> next;

        public Node(Gtype Data)
        {
            this.val = Data;
            this.next = null;
        }
    }
}
