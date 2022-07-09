// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 67] -> 0

int[] GenerateArray(int length = 5, int min = -10, int max = 100)
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

int [] NewArray=GenerateArray();
PrintArray(NewArray);

int Result=0;
for (int i = 0; i < NewArray.Length; i++)
{
    if (NewArray[i]%2 !=0)
    {
        Result+=NewArray[i];
    }
}
System.Console.WriteLine($"Сумма нечетных чисел в массиве равна {Result}");