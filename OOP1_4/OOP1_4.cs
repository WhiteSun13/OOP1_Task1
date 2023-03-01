using System;

Animal animal1 = new Animal("dog");
Pet? beaver = animal1 as Pet; //? указывает что переменная может хранить null или Pet.
if (beaver == null) //Можно ли перевести animal к pet
{
Console.WriteLine("Преобразование провалено");
}
else
{
Console.WriteLine(beaver.Type);
}
//В обратную сторону
Pet cat = new Pet("Morgana", "Cat");
Animal? animal2 = cat as Animal; //Можно преобразовать переменную производного класса к базовому типу
if (animal2 == null)
{
Console.WriteLine("Преобразование прошло неудачно");
}
else
{
Console.WriteLine(animal2.Name);
}

Animal animal3 = new Animal("Lion"); //Переменная базового типа
if (animal3 is Pet pet) //Можно ли представить ее как переменную производного класса
{
Console.WriteLine(pet.Type);
}
else
{
Console.WriteLine("Преобразование не возможно"); //Не можно
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