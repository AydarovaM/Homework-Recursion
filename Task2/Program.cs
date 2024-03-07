// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

System.Console.WriteLine(instructor_ack(2, 3));

int instructor_ack(int m, int n)
{
    return ack(n, m);
}

int ack(int m, int n)
{
    if (m == 0)
    {
        return (n + 1);
    }
    else if (n == 0)
    {
        return ack(m - 1, 1);
    }
    else
    {
        return ack(m - 1, ack(m, n - 1));
    }
}

// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))