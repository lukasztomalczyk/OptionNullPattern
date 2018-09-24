using System;

namespace OptionNull
{
    public class User
    {
        public int Id { get; set; }
        
        public Option<PersonalInfo> Info { get; set; }

        public override string ToString()
        {
            var test = Info.Reduce(new PersonalInfo("default"));
            
            return $"ID: {Id}, personal info: {Info.Reduce(new PersonalInfo("default"))}";
        }

        public User(int id, Option<PersonalInfo> info)
        {
            Id = id;
            Info = info;
        }
    }
}