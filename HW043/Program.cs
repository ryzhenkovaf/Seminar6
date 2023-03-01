//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
//задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Введите значения уравнения y = k1 * x + b1");
Console.Write("b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значения уравнения y = k2 * x + b2");
Console.Write("b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double[] result = Point(b1, k1, b2, k2);

PrintArray(result);

double[] Point(double b1, double k1, double b2, double k2)
{
    double[] res = new double[2];
    res[0] = (b2 - b1) / (k1 - k2);
    res[1] = k2 * res[0] + b2;
    return res;
}
void PrintArray(double[] array)
{
    Console.WriteLine(String.Join("; ", array));
}
