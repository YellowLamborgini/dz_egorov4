Console.WriteLine("Введите шестизначное число");
int chislo= Convert.ToInt32(Console.ReadLine());

if (chislo/100000==0| chislo / 1000000 > 0)
{
    Console.WriteLine("Ошибка");
}
else
{
    int sotnityshyach = chislo / 100000;
    int desyatkitysyach = chislo%100000 / 10000;
    int tisyachi = chislo%10000/1000;
    int sotni = chislo % 1000 / 100;
    int desyatki = chislo % 100 / 10;
    int edenitsy = chislo % 10;
    int result = edenitsy * 100000 + desyatki * 10000 + sotni * 1000 + tisyachi * 100 + desyatkitysyach * 10 + sotnityshyach;
    Console.WriteLine($"Результат: {result}");
}