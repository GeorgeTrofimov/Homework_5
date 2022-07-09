// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7, 22, 2, 78] -> 76

int[] GenerateArray(int length = 5, int min = 0, int max = 100)
{
    int[] newArray = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rnd.Next(min, max + 1);
    }
    return newArray;
}


void PrintArray(int[] array)

{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}; ");
    }
}

int [] NewArray = GenerateArray();
PrintArray(NewArray);

int max=NewArray[0];
for (int i = 0; i < NewArray.Length; i++)
{
    if (NewArray[i]>max)
    {
        max=NewArray[i];
    }
}

int min=NewArray[0];
for (int i = 0; i < NewArray.Length; i++)
{
    if (NewArray[i]< min)
    {
        min=NewArray[i];
    }
}

int Result=0;
Result=max-min;
    System.Console.WriteLine($"Разница между максимальным и минимальным значением равна {Result}");