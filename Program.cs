using System;
namespace bai_tap
{
    class Program
    {
        public static void Main()
        {
            Cercle cercle=new Cercle(4);
            Console.Write($"\n {cercle.GetArea()}");
            Console.WriteLine();
            Console.Write($"\n {cercle.GetPerimeter()}");
        }
    }
}
