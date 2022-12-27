// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении задачи не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] StringToStringArray(string str)
{
    string[] arrString = str.Split(',');
    return arrString;
}

void PrintArray(string[] arr, string beginStr, string separatorElems, string endStr, string framing)
{
    Console.Write(beginStr);
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{framing}{arr[i]}{framing}{separatorElems}");
        else Console.Write($"{framing}{arr[i]}{framing}");
    }
    Console.Write(endStr);
}

string[] NewStringArrayFromOldByElementStringLengthCondition(string[] arr, int ElementStringLength)
{
    int size = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= ElementStringLength) size++;
    }
    string[] arr1 = new string[size];
    int index1 = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= ElementStringLength) arr1[index1++] = arr[i];
    }
    return arr1;
}

Console.WriteLine($"Введите элементы строкового массива через запятую");
string string1 = Console.ReadLine();

string[] array = StringToStringArray(string1);
PrintArray(array, "[", ", ", "]", "\"");

string[] array1 = NewStringArrayFromOldByElementStringLengthCondition(array, 3);
PrintArray(array1, " -> [", ", ", "]", "\"");
