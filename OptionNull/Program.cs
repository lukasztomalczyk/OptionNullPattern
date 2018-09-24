using System;

namespace OptionNull
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var test = new User(1, None.Value);
            
            Console.WriteLine(test.ToString());
            
            var test2 = new User(2, new PersonalInfo("Adres"));
            
            Console.WriteLine(test2.ToString());


        }
    }
 
}