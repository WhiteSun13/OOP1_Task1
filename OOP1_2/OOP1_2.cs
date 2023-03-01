using System;

object obj = new Pet("Fido", "Dog");
//Приводим объект к типу Pet
Pet dog = (Pet)obj;
Console.WriteLine(dog.Type);
//WildAnimal представляет тип Animal
Animal animal = new WildAnimal("Lion", "Desert");
//Преобразование типа Animal к WildAnimal
WildAnimal hab = (WildAnimal)animal;
Console.WriteLine(hab.Habitat);

namespace OOP1_2
{
    class OOP1_2
    {
        static void Main(string[] args)
        {
            //Явное преобразование простых типов и массивов
            float fl1 = 3.14f;
            double ost = 3.2345;
            int fl = (int)fl1 / 330; //float в int
            fl = (int)(ost + fl1);
            short a1 = (short)'5'; //char в short
            int[] arr = new int[4];
            double[] arrd = new double[4];
            arr[1] = (int)arrd[1];
            /*sbyte - byte, ushort, uint, ulong или char
              byte - Sbyte или char
              short - sbyte, byte, ushort, uint, ulong или char
              ushort - sbyte, byte, short или char 
              int - sbyte, byte, short, ushort, uint, ulong или char
              uint - sbyte, byte, short, ushort, uint, ulong или char
              long - sbyte, byte, short, ushort, int, uint, ulong или char
              char - sbyte, byte или short 
              float - sbyte, byte, short, ushort, int, uint, long, ulong, char или decimal
              double - sbyte, byte, short, ushort, int, uint, long, ulong, char, float, decimal 
              double - sbyte, byte, short, ushort, int, uint, long, ulong, char, float, decimal 
              ulong - sbyte, byte, short, ushort, int, uint, long или char*/
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
class Pet : Animal
{
    public string Type { get; set; }
    public Pet(string name, string pet) : base(name)
    {
        Type = pet;
    }
}
class WildAnimal : Animal
{
    public string Habitat { get; set; }
    public WildAnimal(string name, string habitat) : base(name)
    {
        Habitat = habitat;
    }
}