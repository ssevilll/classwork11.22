using Classwork11._22.Task1.Model;

namespace Classwork11._22.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = {
                new Student("Ali", "Mammadov", 85.5m),
                new Teacher("Aysel", "Hasanova") { Salary = 2500m },
                new Student("Leyla", "Aliyeva", 92.0m),
                new Teacher("Rashad", "Ibrahimov") { Salary = 3000m },
                new Student("Kamran", "Qasimov", 78.3m),
                new Student("Nigar", "Huseynova", 88.7m)
            };
            
            var students = new List<Student>();
            foreach (Person person in persons)
            {
                if (person is Student student)
                {
                    students.Add(student);
                }
            }
            
            var groupMate = new GroupMate(students.Count);
            
            Console.WriteLine("Adding students to GroupMate using indexer:");
            for (int i = 0; i < students.Count; i++)
            {
                groupMate[i] = students[i];
                Console.WriteLine($"Added: {students[i].ShowInfo()}");
            }
            
            Console.WriteLine("\nAll students in GroupMate:");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"Index {i}: {groupMate[i].ShowInfo()}");
            }
            
            Console.WriteLine("\nSorting students by points...");
            GroupMate.Sort(groupMate.Students);
            
            Console.WriteLine("\nStudents after sorting:");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"Index {i}: {groupMate[i].ShowInfo()}");
            }
        }
    }
}
