// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int GetNum(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] FillArray(int size, int start, int end)
{
    var arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(start, end);
    }
    return arr;
}

int len = GetNum("Задайте размер массива: ");
int left = GetNum("Задайте левую границу значений: ");
int right = GetNum("Задайте правую границу значений: ");

if (right < left)
{
    Console.WriteLine("Неверный ввод!");
}
else
{
    int[] myArray = FillArray(len, left, right);
    Console.WriteLine("[" + string.Join(", ", myArray) + "]");
}


