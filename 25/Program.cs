// Задача 25
// Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Цикл, который принимает на вход два числа А и В и возводит число А в натуральную степень В");

int Exponentiation (int indexA, int indexB)
{
    var result = 1;
    for(var i = 1; i <= indexB; i++)
    {
        result *= indexA;

    }
    return result;
}

Console.WriteLine("Введите число А: ");
var indexA  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
var indexB  = Convert.ToInt32(Console.ReadLine());

if (indexB < 0)
{
    Console.WriteLine("Значение В должно быть натуральным. Попробуйте снова ввести число В.");

}
else
{
    int exponentiation = Exponentiation(indexA, indexB);
    Console.WriteLine("Результат: " + exponentiation);
}