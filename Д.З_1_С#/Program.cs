Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());
if (b > a)
{
    Console.WriteLine("максимальное число: " + b);
    Console.WriteLine("минимальное число: " + a);
}
else 
{
    
    Console.WriteLine("максимальное число: " + a);
    Console.WriteLine("минимальное число: " + b);
}