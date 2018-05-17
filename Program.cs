using System;
using System.Dynamic;


namespace DynamicSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            dynamic  rfile = new ReadOnlyFile (@"TextFile1.txt");
            
            foreach (string line in rfile.Customer ) 
            {
                Console.WriteLine (line);
            }
            Console.WriteLine ("-------------------------------------");
            foreach (string line in rfile.Customer(StringSearchOption.Contains,true) ) 
            {
                Console.WriteLine (line);
            }
            
        }
    }
}
