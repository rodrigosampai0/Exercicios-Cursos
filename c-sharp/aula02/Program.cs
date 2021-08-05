using System;

namespace aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            if (args.Length > 0){
                Console.Write(args.GetValue(0));
            }
            // if (args.GetValue(0) > 0){
            //     Console.Write(args.GetValue(0));
            // }
        }
    }
}
