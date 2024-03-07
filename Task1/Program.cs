// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


PrintNumbers(1, 5);
PrintNumbers(8, 4);

void PrintNumbers(int m, int n)
{
    if (m == n)
    {
        System.Console.WriteLine(m);
        return;
    }
    System.Console.Write(m + ", ");
    if (m < n)
    {
        PrintNumbers(m + 1, n);
    }
    else
    {
        PrintNumbers(m - 1, n);
    }
}