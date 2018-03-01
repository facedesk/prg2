using System;

namespace prg2._2_oop
{
    public class Node
    {
        public int data;
        public Node next;

        public Node root;
        public Node(int data,Node root)
        {
            this.data = data;
            this.root = root;
        }
        public Node(int data)//root constructor
        {
            this.root = this;
        }
        public void Print()
        {
            Node copy = this;
            this.Display(copy);
        }
        public void PrintAll()
        {
            Node copy = this.root;
            this.Display(copy);
        }
        private void Display(Node copy)
        {
            while(copy.next != null)
            {
                Console.WriteLine(copy.data);
                copy = copy.next;
            }
        }

    }
}