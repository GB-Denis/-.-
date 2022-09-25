Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (max < b)
{
max = b;
}
if (max > c)
{
    Console.WriteLine("максимальное число: " + max);
}
else
    Console.WriteLine("максимальное число: " + c);