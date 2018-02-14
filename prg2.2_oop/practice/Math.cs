namespace prg2._2_oop
{
    public class QuickMath
    {
        int a;
        int b;

        public QuickMath(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int Add()
        {
            int c = a+b;
            return c;
        }
        public int Subtract()
        {
            int c = a-b;
            return c;
        }
        public int Divide()
        {
            int c = a/b;
            return c;
        }
        public int Multiply()
        {
            int c = a*b;
            return c;
        }

    }
}