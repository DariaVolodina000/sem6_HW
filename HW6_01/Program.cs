// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int IntPutInt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}\t");
    }
}

int Count(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}


int size = IntPutInt("Сколько чисел будем вводить? ");

int[] line = new int[size];     // создаем массив

for (int i = 0; i < line.Length; i++)   // Заполняем масси
{
    line[i] = IntPutInt("Введите число");
}

Console.WriteLine("Такой массив у нас получился: ");
PrintArray(line);
Console.WriteLine();

int result = Count(line);
Console.WriteLine($"В этом массиве чисел больше 0 = {result}");



