namespace OptionNull
{
    public class PersonalInfo
    {
        public string Address { get; set; }

        public PersonalInfo(string info)
        {
            Address = info;
        }

        public override string ToString()
        {
            return Address;
        }
    }
}