// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Создание метода вывода массива
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// Создание метода подсчета длины массива, в котором будут храниться элементы строк длиной не больше 3
int FindLengthNewArray (string[] array)
{
    int NumberOfElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) NumberOfElements++;
    }
    return NumberOfElements;
}

