using System;

namespace prg2._2_oop
{
    public class Node<T>
    {
        public T data;
        public Node<T> next;

        public Node<T> root;
        public Node(T data,Node<T> root)
        {
            this.data = data;
            this.root = root;
        }
        public Node(T data)//root constructor
        {
            this.data = data;
            this.root = this;
        }
        public void Print()
        {
            Node<T> copy = this;
            this.Display(copy);
        }
        public void PrintAll()
        {
            Node<T> copy = this.root;
            this.Display(copy);
        }
        private void Display(Node<T> copy)
        {
            while(copy.next != null)
            {
                Console.WriteLine(copy.data);
                copy = copy.next;
            }
        }

    }
}