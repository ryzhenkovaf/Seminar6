// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите числа через пробел: ");
string elements = Console.ReadLine();
int[] array = GetArrayFromString(elements);

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ");
    int[] result = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        result[i] = int.Parse(nums[i]);
    }
    return result;
}

int PosNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine($"Количество положительных чисел равно {PosNumbers(array)}");
