/* Задача 23
Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

int InterNumber()
{
    Console.WriteLine("Введите число: ");
    int N = Convert.ToInt32(Console.ReadLine());
    return N;
}

void GetPow(int N)
{
    Console.Write("Кубы чисел от 1 до " + N + ": ");
    int index = 1;

    while (index <= N)
    {
        double a = Math.Pow(index, 3);
        Console.Write(a + " ");
        index++;
    }
}

GetPow(InterNumber());