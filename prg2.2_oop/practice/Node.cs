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
        
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return 0;
        }

        //#region operator_overloading
       /* public static bool operator ==(Node<T> obj1, Node<T> obj2)
        {
           if((obj1 is null) && (obj2 is null))
           {
               return true;
           }

            bool dataEqual = obj1.data.Equals(obj2.data);
            bool baseEqual = obj1.Equals(obj2);
            return dataEqual && baseEqual;
        }


        public static bool operator !=(Node<T> obj1,Node<T> obj2)
        {
            return !(obj1 == obj2);
        }*/


        public static Node<T> operator ++(Node<T> n)
        {
            return n.next;
        }
        

        public Node<T> this[int key]
        {
            get
            {
                Node<T> iterator = root;
                for(int i = 0;i<key;i++)
                {
                    if(iterator == null)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    iterator = iterator.next;
                }
                return iterator;
               // return new Node<T>(this.data);
            }
            set
            {
                ;
            }
        }

        public static Node<T> operator+(Node<T> a1, Node<T> a2)
        {
            //perform the addition
            return a1;
        }
        
      


    }
}