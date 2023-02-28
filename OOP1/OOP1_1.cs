using System;

Pet cat = new Pet("Lypus", "cat");
Animal home_animal = cat;   // преобразование от Pet к Animal
Console.WriteLine(home_animal.Name);
namespace OOP1_1
{
    class OOP1_1
    {
        static void Main(string[] args)
        {
            //Неявное преобразование простых типов
            float Pi = 3.14F;
            double P = Pi; //float в double
            int t = 3;
            P = t; //int в double
            char i = '5';
            t = i; //char в int
        }
    }
}

class Animal
{
    public string Name { get; set; }
    public Animal(string name)
    {
        Name = name;
    }
    public void Print()
    {
        Console.WriteLine($"Animal {Name}");
    }
}

//Наследник класса Animal
class Pet : Animal
{
    public string Type { get; set; }
    public Pet(string name, string pet) : base(name)
    {
        Type = pet;
    }
}
