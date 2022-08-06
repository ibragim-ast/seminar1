//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int a = 1;

while (a < N)
{ 
if (a % 2 == 1)
{ 
    a += 1;
}
else
{
    Console.Write(a);
    Console.Write(" ");
    a += 2;
}
}