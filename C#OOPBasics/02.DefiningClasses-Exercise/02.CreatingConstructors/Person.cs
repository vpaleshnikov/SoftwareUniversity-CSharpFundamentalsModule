﻿public class Person
{
    private string name;
    private int age;

    public string Name
    {
        get { return name;}
        set { this.name = value; }
    }

    public int Age
    {
        get { return age; }
        set { this.age = value; }
    }


    public Person()
    {
        this.name = "No name";
        this.age = 1;
    }

    public Person(int age) : this()
    {
        this.Age = age;
    }

    public Person(string name, int age) : this(age)
    {
        this.Name = name;
    }
}