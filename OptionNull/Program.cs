using System;

namespace OptionNull
{
    class Program
    {
        static void Main(string[] args)
        {
            var user1 = new User(1, None.Value);

            Console.WriteLine(user1.ToString());

            var user2 = new User(2, new PersonalInfo("Adres"));

            Console.WriteLine(user2.ToString());
        }
    }
}