Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int a = 1;

while (a < N)
{ 
if (a % 2 == 1)
{ 
    a = a + 1;
}
else
{
    Console.WriteLine(a);
    a = a + 2;
}
}