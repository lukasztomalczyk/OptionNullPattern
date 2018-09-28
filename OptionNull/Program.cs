using System;
using System.Reflection.PortableExecutable;

namespace OptionNull
{
    class Program
    {
        static void Main(string[] args)
        {
            var user1 = new User("Lukasz", None.Value);
            var user2 = new User("Kate", new PersonalInfo("221 B Baker St, London, England"));

            Console.WriteLine("User: {1}, address is: {0}", user1.Info.Reduce(new PersonalInfo("default")).Address, user1.Name);
            Console.WriteLine("User: {1}, address is: {0}", user2.Info.Reduce(new PersonalInfo("default")).Address, user2.Name);
        }
    }
}