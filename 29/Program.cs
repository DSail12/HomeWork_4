// Задача 29
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

class Program 
{
    static void Main (string[] args)
{
    

     int [] array = new int [8];
    int size = 8;


    Console.Write("Введите 8 элементов массива: \t");

 
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
 
            for (int i = 0; i < array.Length; i++)
            {
                {
                    Console.WriteLine("Вывод элементов массива на экран: ");
                }
               Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
}