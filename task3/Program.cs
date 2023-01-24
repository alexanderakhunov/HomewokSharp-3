System.Console.WriteLine("Ввведите Num: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
    for (int i = 1; i <= num; i++)
    {
        System.Console.WriteLine(Math.Pow(i, 3));
    }
}
else
{
    System.Console.WriteLine("Введите другое число");
}
