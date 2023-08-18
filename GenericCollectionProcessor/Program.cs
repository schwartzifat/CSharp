namespace GenericCollectionProcessor;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        List<Person> persons = new List<Person>
        {
            new Person { Name = "Ifat", Salary = 25000 },
            new Person { Name = "Eran", Salary = 30000 },
            new Person { Name = "Michael", Salary = 15000 },
            new Person { Name = "Jane", Salary = 9000 },
            new Person { Name = "Robert", Salary = 8000 },
        };

        List<Student> students = new List<Student>
    {
        new Student { Id = 1, FirstName = "Ifat", LastName = "Schwartz", Course = "Angular", Grade = 95 },
        new Student { Id = 2, FirstName = "Jane", LastName = "Smith", Course = "React", Grade = 90 },
        new Student { Id = 3, FirstName = "Ido", LastName = "levy", Course = "Angular", Grade = 78 },
        new Student { Id = 1, FirstName = "Eran", LastName = "Schwartz", Course = "Angular", Grade = 90 },

    };

        CollectionProcessor.Process(
            persons,
            person => person.Name.Length >= 5,
            person => { person.Name = person.Name.ToUpper(); return person; },
            person => Console.WriteLine(person.Name));

        CollectionProcessor.Process(
            persons,
            person => person.Salary > 10000,
            person => { person.Salary = person.Salary + (person.Salary * 0.1) + (person.Salary * 0.1); return person; },
            person => Console.WriteLine($"Salary after TAX and bonus for {person.Name}: {person.Salary}")
            );

        CollectionProcessor.Process(
            students,
            student=>student.Course == "Angular" && student.Grade > 80,
            student=> new { FullName = $"{student.FirstName} {student.LastName}", Grade = student.Grade },
            student => Console.WriteLine($"Full Name: {student.FullName}, Grade: {student.Grade}"));
    }
}

