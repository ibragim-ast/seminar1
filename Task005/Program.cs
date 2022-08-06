// Напишите программу, которая принимает на вход трехзначное число 
// и на выходе показывает последнюю цифру этого числа
Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num % 10);
