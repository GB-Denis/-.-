Console.Write("Введите положительное число ");
int num = Convert.ToInt32(Console.ReadLine());
num = Math.Abs(num);
int num2 = -num;
while (num2<= num)
{
    Console.Write(num2 + ", ");
    num2 = num2 + 1;
}
Console.WriteLine();