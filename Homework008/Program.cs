int N = 8;
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