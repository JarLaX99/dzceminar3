System.Console.Write("Введите 5-ти значное число: ");
string str = Console.ReadLine()!;

if (str.Length == 5)
{
    if (str[0] == str[4] && str[1] == str[3])
    {
        System.Console.WriteLine($"число {str} является палиндромом ");
    }
    else
    {
        System.Console.WriteLine($"число {str} не является палиндромом ");
    }
}
else
{
    System.Console.WriteLine(" Ошибка:Введите 5-ти значное число");
}
