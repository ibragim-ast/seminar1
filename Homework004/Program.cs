//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int a = 22;
int b = 3;
int c = 9;

int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}

Console.Write("Максимальное число = ");
Console.WriteLine(max); 