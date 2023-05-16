using System;
using System.Linq;
namespace HelloWorld {
    class Program
    {
        public static void Main(string[] args){
            //Conditions 

            int age = 17;

            if(age>=18){
                Console.WriteLine("You are eligible to vote")
            }
            else if(age < 18 && > 0) {
                Console.WriteLine("You are not eligible to vote")
            }
            else{
                Console.WriteLine("Invalid age")
            }

        }
    }
}