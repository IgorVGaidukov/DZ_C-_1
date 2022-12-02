// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

int num;

Console.Write("Введите число: ");
num = Convert.ToInt16(Console.ReadLine());
if (num==0) Console.Write($"Число {num} - ноль!");
else
    if (num%2 == 0)
        Console.Write($"Число {num} - четное!");
    else
        Console.Write($"Число {num} - нечетное!");