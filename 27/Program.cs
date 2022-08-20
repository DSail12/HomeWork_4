// Задача 27
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Пожалуйста введите число: ");

int index = Convert.ToInt32(Console.ReadLine());

int SumIndex (int index)

{
    int count = Convert.ToString(index).Length;
    int step = 0;
    int result = 0;
    for (int i = 0; i < count; i++)
    {
        step = index - index % 10;
        result += index - step;
        index /= 10;
    }
    return result;
}
int sumIndex = SumIndex (index);

Console.WriteLine("Результат: " + sumIndex);