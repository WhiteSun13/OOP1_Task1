using System;

namespace OOP1_3
{
    class OOP1_3
    {
        static void Main(string[] args)
        {
            try
            {
                long a = 555000000000;
                long b = 700000000000;
                int c = checked((int)(a + b)); //В int не поместится такое огромное число
                Console.WriteLine(c);
            }
            catch (OverflowException ex) //"Ловец" ошибки
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
