// Задача 41.


/*
Console.Write("Введите элементы(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Кол-во элементов > 0: {count}");
*/


// Задача 42

/*
using System;
 
class Convert
{
    static void Main()
    {
        int num10 = 45; // число в десятичной системе исчисления
        int a = 0; // a - остаток после % деления из которого формируется число в 
                     //    двоичной системе исчисления
        int i = 0;
 
        int[] b = new int[10]; // массив с помощью которого двоичное число позже 
                                 //будет выведено с конца для правильного отображения 
 
        while (num10 >= 1)
        {
            a = num10 % 2;
            b[i] = a;
            i++;
 
            num10 = num10 / 2;
 
            Console.Write(a);
        };
 
        Console.WriteLine();
 
        for (i = (b.Length - 1); i >= 0; i--)
        {
            Console.Write(b[i]);
        }
 
        Console.ReadKey();
    }      
}        
*/     








        