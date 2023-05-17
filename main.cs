using System;
using System.Linq;
namespace HelloWorld {
    class Program
    {
        public static void Main(string[] args){
            //Loops

            int n = 2;
            int i = 0;

            while(i<=12){
                int f = n * i;
                Console.WriteLine(f);
                i++;
            }
        }
    }
}