using System;

namespace OptionNull
{
    public class User
    {
        public string Name { get; }
        
        public Option<PersonalInfo> Info { get; }


        public User(string name, Option<PersonalInfo> info)
        {
            Name = name;
            Info = info;
        }
    }
}