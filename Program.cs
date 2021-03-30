using System;
using System.Collections.Generic;
using System.Globalization;

namespace getInShape
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Kata k = new Kata();

            //Console.WriteLine(k.Narcissistic(1));
            //Console.WriteLine(k.Narcissistic(3));
            //Console.WriteLine(k.Narcissistic(154));
            //Console.WriteLine(k.Narcissistic(378));
            //Console.WriteLine(k.Narcissistic(371));
            //Console.WriteLine(k.Narcissistic(999)); 
            //Console.WriteLine(k.Narcissistic(1938));

            CountDig cd = new CountDig();
            Console.WriteLine(cd.NbDig(5750, 0));

        }
    }
}
