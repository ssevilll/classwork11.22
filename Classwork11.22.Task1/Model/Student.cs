using System;

public class Student : Person
{
	public decimal Point { get; set; }

    public Student(string name, string surname, decimal point) : base(name, surname)
    {
        Point = point;
    }
    public override string ShowInfo()
    {
        return base.ShowInfo() + $", Point: {Point}";
    }

    public static bool operator < (Student student1, Student student2)
    {
        return student1.Point < student2.Point;
    }
    public static bool operator > (Student student1, Student student2)
    {
        return student1.Point > student2.Point;
    }

}
