// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int N;
int i = 1;

Console.Write("Введите число N: ");
N = Convert.ToInt16(Console.ReadLine());
while (i<=N)
{
    if (i%2 ==0) Console.WriteLine(i);
    i++;
};