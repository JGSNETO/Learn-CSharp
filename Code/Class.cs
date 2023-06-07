using System;

class Person{
    private string name;
    private int age;

    public Person(string name, int age){
        this.name = name;
        this.age = age;
    }

    public void DisplayInfo(){
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class Program{
    static void Main(string[] args){
        Person person = new Person("John Doe", 30);
        person.DisplayInfo();
    }
}