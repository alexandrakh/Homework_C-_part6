// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int n = DataEntry("Введите количество чисел ");
int[] array = FillArray(n);
System.Console.WriteLine("Количество чисел > 0 = " + GetCountNumbers(array));

int DataEntry(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] FillArray(int n)
{
    int[] data = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write("Введите число ");
        data[i] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
    }

    return data;
}


int GetCountNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    return count;

}