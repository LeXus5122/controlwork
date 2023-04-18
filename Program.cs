Console.WriteLine("Введите элементы массива (через запятую):");
string[] userInputArray = PopulateArray();
Console.WriteLine("Входной массив:");
DisplayArray(userInputArray);
int finalArraySize = CalculateResultArraySize(userInputArray);
string[] finalArray = CreateUserArray(finalArraySize);
FillResultantArray(userInputArray, finalArray);
Console.WriteLine("Результирующий массив:");
DisplayArray(finalArray);

static string[] CreateUserArray(int size)
{
    string[] newArray = new string[size];
    return newArray;
}

static string[] PopulateArray()
{
    string inputLine = Console.ReadLine()!;
    string[] elements = inputLine.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

    for (int j = 0; j < elements.Length; j++)
    {
        elements[j] = elements[j].Trim();
    }

    return elements;
}

static void DisplayArray(string[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            if (i != array.Length - 1) Console.Write($"{array[i]}, ");
            else Console.Write($"{array[i]}]");
        }
        Console.WriteLine();
    }

static int CalculateResultArraySize(string[] array)
    {
        int resultSize = 0;
        foreach (string element in array)
        {
            if (element.Length <= 3) resultSize++;
        }
        return resultSize;
    }

static void FillResultantArray(string[] initialArray, string[] finalArray)
    {
        int resultIndex = 0;
        foreach (string element in initialArray)
        {
            if (element.Length <= 3)
            {
                finalArray[resultIndex] = element;
                resultIndex++;
            }
        }
    }