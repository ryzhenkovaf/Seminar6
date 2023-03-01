// /*Задача 45: Напишите программу,
 //которая будет создавать копию заданного массива с помощью поэлементного копирования.*/


Console.Clear();
int[] array = GetArray(6, 1, 20);
int[] newArray = CopyArray(array);
PrintArray(array);
PrintArray(newArray);

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

void PrintArray(int[] array)
{
    Console.WriteLine(String.Join(", ", array));
}
int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

