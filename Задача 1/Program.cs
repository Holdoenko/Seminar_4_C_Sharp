/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.Clear();

Console.WriteLine("Введите число A: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число B: ");
double b = Convert.ToDouble(Console.ReadLine());
a = Math.Pow(a,b);
Console.WriteLine($"Ответ: {a}");
