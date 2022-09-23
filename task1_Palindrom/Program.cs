/*Задача 19
Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да*/

int InterNumber() //метод для ввода числа
{
    Console.WriteLine("Введите пятизначное число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int number = InterNumber();
int numberForLength = number; //отдельная переменная для расчёта длины числа, проверка на пятизначность

int LengthOfNumber() //метод для расчёта длины числа, проверка на пятизначность, чтобы не использовать string
{
    int lengthOfNumber = 0;

    while (numberForLength > 0)
    {
        lengthOfNumber++;
        numberForLength = numberForLength/10;
    }
    
    if (lengthOfNumber != 5)
    {
        Console.WriteLine("Введённое число не является пятизначным.");
    }

    return lengthOfNumber;
}

int lengthOfNumber = LengthOfNumber();

void NumberPalindrom() //метод проверяет является ли число палиндромом, работает только для пятизначного чисел
{
    if (lengthOfNumber == 5)
    {
        int digit5 = number % 10; //цифра числа в разряде единиц класса единиц
        number = number / 10;
        int digit4 = number % 10; //цифра числа в разряде десятков класса единиц
        number = number / 100;
        int digit2 = number % 10; //цифра числа в разряде единиц класса тысяч
        number = number / 10;
        int digit1 = number; //цифра числа в разряде десятков класса тысяч
    
        if (digit5 == digit1 && digit4 == digit2)
        {
            Console.WriteLine("Введённое число является палиндромом.");
        }
        
        else
        {
            Console.WriteLine("Введённое число не является палиндромом.");
        } 
    }  
}
        
    NumberPalindrom();