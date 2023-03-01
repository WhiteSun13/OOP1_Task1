using System;

Salary new_salary = new Salary {Rubles = 24130};
int x = (int)new_salary; //Явно указываем тип
Console.WriteLine($"Явный перевод: {x}");

Salary prev_salary = x;
Console.WriteLine($"Неявный перевод: {prev_salary.Rubles}");
//Класс, хранящий размер зарплаты и хранит ее в рублях в свойстве Rubles
class Salary
{
    public int Rubles {get; set;}
    //Неявное преобразование, число в объект
    public static implicit operator Salary(int x) //Salary - тип, во что преобразовываем
    //В скобках - что преобразовываем
    {
        return new Salary {Rubles = x};
    }
    //Явное преобразование
    //Позволяет получить число из объекта
    public static explicit operator int(Salary salary)
    {
        return salary.Rubles;
    }
}

