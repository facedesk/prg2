public sealed class SingletonThreadSafe
{
    private SingletonThreadSafe()
    {
    }

    public static SingletonThreadSafe Instance { get { return Nested.instance; } }
        
    private class Nested
    {
        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Nested()
        {
        }

        internal static readonly SingletonThreadSafe instance = new SingletonThreadSafe();
    }
}