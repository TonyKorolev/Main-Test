// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Метод вывода массива строк
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == (array.Length-1)) Console.Write($"{array[i]}");
        else Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
}

// Метод нахождения длины массива строк, в котором будут храниться элементы длиной не больше 3
int FindLengthNewArray(string[] array)
{
    int NumberOfElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) NumberOfElements++;
    }
    return NumberOfElements;
}

// Метод создания нового массива строк, в котором будут храниться элементы строк длиной не больше 3
string[] CreatArrayWithElementsLengthNoMore3(string[] array, int lengthNewArrayMethod)
{
    string[] newArrayMethod = new string[lengthNewArrayMethod];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArrayMethod[j] = array[i];
            j++;
        }
    }
    return newArrayMethod;
}

// Исходная программа
string[] array = { "hello", "2", "world", ":-)" };
// string[] array = { "1234", "1567", "-2", "computer science" };
// string[] array = { "Russia", "Denmark", "Kazan" };
PrintArray(array);
int lengthNewArray = FindLengthNewArray(array);
string[] newArray = CreatArrayWithElementsLengthNoMore3(array, lengthNewArray);
Console.Write(" -> ");
PrintArray(newArray);