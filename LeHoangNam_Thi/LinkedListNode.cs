using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeHoangNam_ThiFinalTest
{
    internal class LinkedListNode
    {

        public string Meaning;
        public LinkedListNode Next;
        public LinkedListNode(string Meaning)
        {
            this.Meaning = Meaning;
            Next = null;
        }
    }
}
