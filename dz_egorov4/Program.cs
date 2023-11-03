Console.WriteLine("Введите тысячи");
int thousands = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сотни");
int hundreds = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите десятки");
int teens = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите еденицы");
int numbers = Convert.ToInt32(Console.ReadLine());
if (thousands > 0 & thousands < 10 & hundreds > 0 & hundreds < 10 & teens > 0 & teens < 10 & numbers > 0 & numbers < 10)
{
    int chislo = thousands * 1000 + hundreds * 100 + teens * 10 + numbers;
    Console.WriteLine($"Ваше число:{chislo}");
}
else
{
    Console.WriteLine("Ошибка");
}