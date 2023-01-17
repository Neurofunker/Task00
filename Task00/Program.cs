// See https://aka.ms/new-console-template for more information

// 0. Демонстрация решения

// 1.Напишите программу, которая на вход принимает число
// 2 выдаёт его квадрат (число умноженное на само себя).
// 3 Вывод результата

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine()); //3242332
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");



