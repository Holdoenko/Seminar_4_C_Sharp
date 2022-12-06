/*Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
Дополнительная задача (задача со звёздочкой): Напишите программу, которая на вход принимает радиус круга 
и находит его площадь округленную до целого числа, необходимо вывести максимальную цифру в полученном округлённом значении площади круга.
10 -> 4
20 -> 7
30 -> 8*/

Console.Clear();

Console.Write("Введите радиус круга, R: ");
int R = Convert.ToInt32(Console.ReadLine());
double P = 3.14;
double res = (P * Math.Pow(R, 2));
res = Math.Round(res, MidpointRounding.AwayFromZero);
double max = 0;
do max = Math.Max(max, res % 10);
while ((res /= 10) != 0);
Console.Write("Максимальная цифра в значении площади круга: "); 
Console.WriteLine(Math.Round(max, MidpointRounding.AwayFromZero));