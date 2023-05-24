using System;
using System.Linq;
namespace HelloWorld {
    public class Program
    {
        public class Person(){
            public string name;
            public int age;

            public void GetDetails(){
                Console.Writeline("Name is " + name);
                Console.Writeline("Age is " + Age);

            }

        } 

        public static void Main(string[] args){
            //classes and objects
            Person P = new Person();
            P.name = "Brilliant";
            P.age = 25;   

            P.GetDetails(); 

        }
    }
}