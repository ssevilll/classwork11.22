namespace Classwork11._22.Task1.Model
{
    internal class Teacher : Person
    {
        public Teacher(string name, string surname) : base(name, surname)
        {
        }
        public decimal Salary { get; set; }
        public static bool operator <(Teacher teacher1, Teacher teacher2)
        {
            return teacher1.Salary < teacher2.Salary;
        }
        public static bool operator >(Teacher teacher1, Teacher teacher2)
        {
            return teacher1.Salary > teacher2.Salary;
        }
    }
}
