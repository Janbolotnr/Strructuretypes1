using System;

namespace Structure_types
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student("Bolot", "Nurman", 23, 168, false);
            Console.WriteLine(student1.Print());

            var student2 = new Student("Janbolot", "Nurman", 24, 170, true);
            Console.WriteLine(student2.Print());

        }

        readonly struct Student
        {
            public readonly string FirstName;
            public readonly string LastName;
            public readonly int Age;
            public readonly int Height;
            public readonly bool Expelled;
            private readonly string StringReprsentation;

            public Student(string firstname, string lastname, int age, int height, bool expelled)
            {
                StringReprsentation = $"First name: {firstname}, Last name: {lastname}, Age: {age}," +
                    $" Height: {height} cm, Expelled: {expelled}";

                FirstName = firstname;
                LastName = lastname;
                Age = age;
                Height = height;
                Expelled = expelled;
            }

            public string Print() => StringReprsentation;
           
        }
    }
}
