using System

class Animal{
    protected string name;

    public Animal(string name){
        this.name = name;
    }
    public void Eat(){
        Console.WriteLine(name + " is eating");
    }
}

class Dog : Animal{
    public Dog(string name) : base(name){

    }

    public void Bark(){
        Console.WriteLine(name + " is barking");
    }
}

class Cat : Animal {
    public Cat(string name) : base(name){

    }

    public void Meow(){
        Console.WriteLine(name + " is meowing");
    }
}

class Program{
    static void Main(string[] args){
        Dog dog = new Dog("Buddy");
        dog.Eat();
        dog.Bark();

        Cat cat = new Cat("Whiskers");
        cat.Eat();
        cat.Meow();
    }
}