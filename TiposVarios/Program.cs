using System;
using System.Text;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int p = 3;
            float a = 4.56f;
            double r = 5.67;

            char smile = '\u2661';
            
            Console.WriteLine(p);
            Console.WriteLine(a);
            Console.WriteLine(r);

            Console.Write(smile);
            Console.Write(smile);
            Console.Write(smile);
            Console.Write(smile);

        }
    }
}
