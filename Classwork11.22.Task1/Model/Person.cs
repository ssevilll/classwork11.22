using System;

public abstract class Person
{
    private int _id;
    public int Id;
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public Person(string name, string surname)
    {
        _id++;
        Id = _id;
        Name = name;
        Surname = surname;
        Age = Age;
    }

    public virtual string ShowInfo()
    {
        return $"ID: {Id}, Name: {Name}, Surname: {Surname}, Age: {Age}";
    }

}
