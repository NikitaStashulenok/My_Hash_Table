using System;

namespace My_Hash_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var correct_hash_table = new Correct_Hash_Table<Person>(10);
            var person = new Person() { Name = "Nikita", Age = 17, Height = 173 };

            correct_hash_table.Add(person);
            correct_hash_table.Add(new Person() { Name = "Gena", Age = 7, Height = 120 });
            correct_hash_table.Add(new Person() { Name = "Lena", Age = 15, Height = 160 });

            Console.WriteLine(correct_hash_table.Search(person));
            Console.WriteLine(correct_hash_table.Search(new Person() { Name = "Gena", Age = 7, Height = 120 }));
            Console.ReadKey();


            var hash_table = new Hash_Table<int, string>(100);

            hash_table.Add(1, "Hello");
            hash_table.Add(26, "World");
            hash_table.Add(666, "Hi");
            hash_table.Add(6, "Guy");

            Console.WriteLine(hash_table.Search(1, "Hello"));
            Console.WriteLine(hash_table.Search(2, "Hello"));
            Console.ReadKey();
        }
    }
}
