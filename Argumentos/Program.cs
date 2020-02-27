using System;

namespace Argumentos
{
    /// <summary>
    /// Prints on the console the argumets passed
    /// </summary>
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// Stores the arguments passed
        /// </param>
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }
    }
}
