using System;

namespace Palindrome
{
    class Program
    {
        static void isPlaindromo(string args)
        {
            if (args == null)
            {
                throw new ArgumentNullException(args);
            }
            
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
                if (arg.Length < 2)
                {
                    //return true;
                    Console.WriteLine("true");
                }
                else
                {
                    isPlaindromo(arg);
                }
            }
        }

        static void Main(string[] args)
        {   
                     
            isPlaindromo(args);
            

        }
    }
}
