// Задача 3: Задайте произвольный массив. Выведете его элементы,
//  начиная с конца. Использовать рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

int[] array = [1, 2, 5, 0, 10, 34];

printReverseArray(array);

void printReverseArray(int[] numbers)
{
    if(numbers.Length==0)
    {
        return;
    }
    System.Console.Write(numbers[numbers.Length-1]+ " ");
    Array.Resize(ref numbers, numbers.Length-1);
    printReverseArray(numbers);
}

