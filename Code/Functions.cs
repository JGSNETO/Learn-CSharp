using System;

class program{
    static void Main(string[] args){
        int resul1 = Multiply(5,3);
        string result2 = Greet("John");
        
        Console.WriteLine("Result of multiplication: " + result1);
        Console.WriteLine("Greeting: " + result2);
    }

    static int Multiply(int num1, int num2){
        return num1 * num2;
    }
    static string Greet(string name){
        return "Hello, " + name + "! How are you";
    }
}