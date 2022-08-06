// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показыват все целые числа в промежутке от -N до N
Console.WriteLine("Введите положительное число");
int a = Convert.ToInt32(Console.ReadLine());
int b = -a;

while (a > b)
{
    Console.Write(b);
    Console.Write(" ");
    b = (b + 1);
}
Console.Write(a);



