// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int GetSumNumbers(int A)
{
    int result = 0;
    while (A / 10 != 0)
    {
        result += A % 10;
        A = A / 10;
    }
    result += A;
    if (result < 0)
    {
        result -= 2 * result;
    }
    return result;
}

System.Console.Write("Введите число: ");
string? input = Console.ReadLine();
if (int.TryParse(input, out int num))
{

    int sum = GetSumNumbers(num);
    Console.WriteLine($"Сумма цифр в числе {num}: {sum}");
}
else
{
    System.Console.WriteLine("Введено не число!");
}

