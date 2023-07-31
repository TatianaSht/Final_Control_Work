// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []



void Main()
{
    Console.Write("Введите количество элементов массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] stringArray = new string[size];
    FillAray(stringArray);
    Console.WriteLine();
    Console.WriteLine ("Массив введенных строк: ");
    PrintArray(stringArray);
    Console.WriteLine();
    Console.WriteLine ("Новый массив из строк, длина которых меньше, либо равна 3 символам: ");
    PrintArray(ArrayOfLengthNumber(stringArray));
    Console.WriteLine();
}


void FillAray (string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        stringArray[i] = Console.ReadLine();
    }
}


string[] ArrayOfLengthNumber(string[] stringArray)
{
    int number = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
            number++;
    }
    string[] rezult = new string[number];
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            rezult[j] = stringArray[i];
            j++;
        }
    }
    return rezult;
}


void PrintArray(string[] array)
{
    Console.WriteLine($"[\"{string.Join("\", \"", array)}\"]");
}


Main();