using System;

namespace OOP1_6
{
    class OOP1_6
    {
        static void Main(string[] args)
        {
            int f = 50;
            string conv = f.ToString(); //Число в строку
            conv = "546";
            f = int.Parse(conv); //Строку в число при помощи Parse
            conv = Console.ReadLine();
            bool result = int.TryParse(conv, out var number); //Преобразование строки в число TryParse
            if (result == true)
                Console.WriteLine($"Преобразование завершено. Число: {number}");
            else
                Console.WriteLine("Преобразование не удалось.");
            //Преобразование числа в логический тип Convert
            int tru = 2;
            bool d = Convert.ToBoolean(tru);
            Console.WriteLine(d);
        }
    }
}
