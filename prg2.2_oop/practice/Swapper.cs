using System;

namespace prg2._2_oop
{
    public static class Swapper<T>
    {
        public static void Swap(Node<T> a, Node<T> b)
        {
            Node<T> tempa = new Node<T>(a.data);
            Node<T> tempb = new Node<T>(a.data);
            
            if(NodesAreInSameList(a,b))
            {
            if(a==a.root)
            {
                Node<T> iterator = a.root;
                while(iterator != null)
                {
                    iterator.root = b;
                    iterator++;
                }
            }
            else if(b == b.root)
            {
                Node<T> iterator = b.root;
                while(iterator != null)
                {
                    iterator.root = a;
                    iterator++;
                }
            }
            
            tempa = a;
            tempb = b;            
            a = b;
            b = tempa;

            a.next = tempb.next;
            b.next = tempa.next;

            }
            
        }

        private static bool NodesAreInSameList(Node<T> a, Node<T> b)
        {
            Node<T> iteratora = a.root;
            Node<T> iteratorb = b.root;
            while(iteratora != null && iteratorb != null)
            {
                if(iteratora != iteratorb)
                {
                    return false;
                }
                iteratora++;
                iteratorb++;
            }
            if(iteratora == null && iteratorb != null || 
            iteratorb == null && iteratora != null)
            {
                return false;
            }
            return true;
        }
    }
}