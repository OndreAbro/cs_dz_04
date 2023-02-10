// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число A: ");
double A = Convert.ToDouble(Console.ReadLine());
double A2 = A;

Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

if (B < 0)
{
    Console.WriteLine("Неверный ввод!");
}
else if (B == 0)
{
    Console.WriteLine($"Число {A} в степени {B}: 1");
}
else
{
    for (int i = 1; i < B; i++)
    {
        A = A * A2;
    }
    Console.WriteLine($"Число {A2} в степени {B}: {A}");
}