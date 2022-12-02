// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int num1, num2;

Console.Write("Введите первое число: ");
num1 = Convert.ToInt16(Console.ReadLine());

Console.Write("Введите второе число: ");
num2 = Convert.ToInt16(Console.ReadLine());

if (num1>num2) Console.Write("Первое число больше второго");
else 
  if (num2>num1) Console.Write("Второе число больше первого");
  else Console.Write("Первое число равно второму");  