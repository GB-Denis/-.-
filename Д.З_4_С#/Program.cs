Console.WriteLine("Введите положительное число от 1 ");
int num = Convert.ToInt32(Console.ReadLine());
num = Math.Abs(num);
int num2 = num % 2;
if (num % 2 == 1)
{
    num2 = num2 + 1;
}
while (num2<= num)
{
    Console.Write(num2 + ", ");
    num2 = num2 + 2;
}
Console.WriteLine();