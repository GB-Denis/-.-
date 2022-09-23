Console.WriteLine("Введите число 1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{a} * {a} = {b}");
if(b == a * a)
{
    Console.WriteLine("Верно!");   
}
else
{
   Console.WriteLine("Не верно!");  
}
