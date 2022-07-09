// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenerateArray(int length = 5, int min = 100, int max = 999)
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


int Result=0;
for (int i = 0; i < NewArray.Length; i++)
{
    if (NewArray[i] % 2 ==0)
    {
        Result++;
    }
}

System.Console.WriteLine($"Количество четных чисел в массиве равно {Result}");