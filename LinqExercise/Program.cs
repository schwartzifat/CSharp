using LinqExercise;

namespace LINQEXERCISE;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var universities = new List<University> {
            new University { ID = 1, Name = "TA", TotalStudents = 30000 },
            new University { ID = 2, Name = "UCLA", TotalStudents = 50000 },
            new University { ID = 3, Name = "Ivrit", TotalStudents = 25000 }
        };

        var students = new List<Student> {
            new Student { ID = 1718, Age = 31, Name = "Haim", UniversityID = 1 },
            new Student { ID = 4255, Age = 70, Name = "Hello", UniversityID = 2 },
            new Student { ID = 5000, Age = 26, Name = "Srulik", UniversityID = 2 },
            new Student { ID = 3006, Age = 52, Name = "Whasaaa", UniversityID = 1 },
            new Student { ID = 9022, Age = 22, Name = "Hello", UniversityID = 2 },
            new Student { ID = 8588, Age = 29, Name = "Avram", UniversityID = 3 },
            new Student { ID = 1099, Age = 25, Name = "Zen", UniversityID = 3 },
            new Student { ID = 4739, Age = 41, Name = "Srulik", UniversityID = 1 },
            new Student { ID = 3065, Age = 24, Name = "Tova", UniversityID = 1 },
            new Student { ID = 4466, Age = 32, Name = "Hello", UniversityID = 1 },
        };

        //3. Print students in reverse order
        students.OrderByDescending(s => s.ID)
                                      .ToList()
                                      .ForEach(s => Console.WriteLine($"ID: {s.ID}, Name: {s.Name}, Age: {s.Age}"));

        //4. Oldest and youngest student ages
        var oldest = students.Max(s => s.Age);
        var youngest = students.Min(s => s.Age);
        Console.WriteLine($"The oldest student age is: {oldest}");
        Console.WriteLine($"The youngest student age is: {youngest}");

        //5. Print the students aged between 30 and 40.Print how many are they.
        var studentsAge30To40 = students.Where(s => s.Age > 30 && s.Age < 40).ToList();
        Console.WriteLine($"Number of students aged between 30 to 40 are {studentsAge30To40.Count()} : ");
        foreach (var s in studentsAge30To40)
        {
            Console.WriteLine($"ID: {s.ID}, Name: {s.Name}, Age: {s.Age}");
        }

        //6. Total amount of students learning in all universities
        var totalAmountOfStudents = universities.Sum(u => u.TotalStudents);
        Console.WriteLine($"The total amount of students learning in all universities: {totalAmountOfStudents}");

        //7. Total amount of students learning in all universities except of a given one
        int universityToDismiss = 2;
        var totalAmountOfStudentsExeptUniversity = universities.Where(u => u.ID != universityToDismiss).Sum(u => u.TotalStudents);
        Console.WriteLine($"The total amount of students learning in all universities except of university ID {universityToDismiss}: {totalAmountOfStudentsExeptUniversity}");


        //8. Popular student name
        var mostPopularStudentName = students.GroupBy(s => s.Name)
                                             .OrderByDescending(g => g.Count())
                                             .First();
        Console.WriteLine($"The most popular name is {mostPopularStudentName.Key}, there are {mostPopularStudentName.ToList().Count} students with that name");

        //9. university without students between the ages 30 to 40

        var universityWithout30To40Students = universities.Where(u => !studentsAge30To40.Any(s => s.UniversityID == u.ID))
                                                     .Select(u => u.Name)
                                                     .ToList();
        //.FirstOrDefault();
        foreach (var u in universityWithout30To40Students)
        {
            Console.WriteLine($"University with no students between 30 and 40: {u}");
        }

        // 10. Minified student objects
        var minifiedStudents = students.Select(s => new { s.Name, UniversityName = universities.Where(u => u.ID == s.UniversityID).Select(u => u.Name) })
                                       .ToList();
        //11. Pagination
        List<Student> Page(int pageNumber, int pageSize = 3)
        {
            return students.Skip((pageNumber - 1) * pageSize)
                           .Take(pageSize)
                           .ToList();
        }

        int pageNumber = 1;
        List<Student> page;
        while ((page = Page(pageNumber)).Any())
        {
            Console.WriteLine($"Page #{pageNumber}, Students: {string.Join(", ", page.Select(s => s.Name))}");
            pageNumber++;
        }
    }
}











