using System;

class GenericTwoTypeDemo
{
    // Generic class with two data types
    public class MyGlobalType2<T, K>
    {
        public void MyGlobalFunction(T t, K k)
        {
            Console.WriteLine($"T = {t}, K = {k}");
        }
    }

    public static void Main(string[] args)
    {
        // Creating object using int and string
        MyGlobalType2<int, string> obj = new MyGlobalType2<int, string>();

        // Calling method
        obj.MyGlobalFunction(10, "Mukesh");
    }
}
