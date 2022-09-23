int Power(int x = 5)
{
    return x * x;
}
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Power(number));