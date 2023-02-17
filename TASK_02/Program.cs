// Задача 2: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int temp = m;
if (m > n) 
{
  m = n; 
  n = temp;
}

void PrintSumm(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов в данном промежутке = {summ} ");
    return;
  }
  PrintSumm(m, n - 1, summ);
}

PrintSumm(m, n, temp=0);
Console.WriteLine();