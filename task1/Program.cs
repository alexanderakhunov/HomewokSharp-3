System.Console.WriteLine("Введите 5-ти значное число:");
string num = Console.ReadLine();
int DL = num.Length;
if (DL == 5)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        System.Console.WriteLine("Да");
    }
    else
    {
        System.Console.WriteLine("нет");
    }
}
else
{
    System.Console.WriteLine("Введено не 5-ти значное число");
}