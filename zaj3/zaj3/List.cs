using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaj3
{
    public class List
    {
        public Node head;
        public Node tail;
        public int count;

        public void AddFirst(int num)
        {
            Node n = new Node(num);
            if(tail == null)
            {
                head = n;
                tail = n;   
            }
            else
            {
                head.prev = n;
                n.next = head;
                head = n;
            }
            count++;
        }

        public void AddLast(int num)
        {
            Node n = new Node(num);
            if (tail == null)
            {
                head = n;
                tail = n;
            }
            else
            {
                tail.next = n;
                n.prev = tail;
                tail = n;
            }
            count++;
        }
        public void RemoveFirst()
        {
            if(head == null)
            {
                head = null;
                tail = null;
            }
            else
            {
                head = head.next;
                head.prev = null;
            }
            count--;
        }
        public void RemoveLast()
        {
            if (tail == null){
                head = null;
                tail = null;
            }
            else {
                tail = tail.prev;
                tail.next = null;
            }
            count-- ;
        }

        public int Get(int index)
        {
            Node current = head;
            if (head == null) { return 0;}
            int currentIndex = 0;
            while(current != null)
            {
                if (currentIndex == index)
                {
                    return current.data;
                }
                current = current.next;
                currentIndex++;
            }
            throw new ArgumentOutOfRangeException("Out of range");
        }



        //    AddFirst(int data){return }
        //    AddLast(int data)
        //    Node/RemoveFirst()
        //    Node/RemoveLast()
        //    Get(int n){return int}
    }
  
}
