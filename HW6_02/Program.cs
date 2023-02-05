// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int IntPutInt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


int k1 = IntPutInt("введите точку k1");
int b1 = IntPutInt("введите точку b1");
int k2 = IntPutInt("введите точку k2");
int b2 = IntPutInt("введите точку b2");

int Result(int k, int b)
{
    int y = k*
}