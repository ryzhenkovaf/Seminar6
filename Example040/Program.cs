// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины. 
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Write("Введите первое число:  ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число:  ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите третье число:  ");
int c = int.Parse(Console.ReadLine());

bool Treugolnik (int a, int b, int c)
{
    return (((a + b) > c) && ((a + c) > b) && ((b + c) > a));
}
if (Treugolnik(a, b, c))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}