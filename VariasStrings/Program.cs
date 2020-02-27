using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 45;
            string e = "a " + 2;
            string w = String.Format("O valor é de : {0}", 45); 
            string h = $"Numero {i}";
            string s = "Um tab\t e um copyright\u03A9";
            string r = @"Nao e’ um codigo Unicode \u1234, nao e’ nova linha \n";
            Console.WriteLine(s);
            Console.WriteLine(r);
            Console.WriteLine(e);
            Console.WriteLine(w);
            Console.WriteLine(h);
            Console.WriteLine(@"tenho {0}", i);
        }
    }
}
