// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все чётные натуральные числа в промежутке 
// от M до N с помощью рекурсии.

// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

void EvenNumbers(int m, int n)
{
   
    if (m <= 0 && n <= 0 && m % 1 == 0 && n % 1 == 0)
    {
       return;
    }
    else if (n < m)
    {
        return;
    }
    if (n % 2 == 0)
        EvenNumbers(m, n - 2);
    else
        EvenNumbers(m, n - 1);
    if (n % 2 == 0)
    {
        Console.Write(n + " ");
    }
}

Console.WriteLine();
Console.WriteLine($"Четные натуральные числа в данном промежутке =  ");
EvenNumbers(m, n);
Console.WriteLine();