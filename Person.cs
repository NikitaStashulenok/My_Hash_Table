namespace My_Hash_Table
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public override int GetHashCode()
        {
            return Name.Length + Age + Height + (int)Name[0];
        }
    }
}