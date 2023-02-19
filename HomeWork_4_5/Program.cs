// 5. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
using System.Data;
Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine()!);
int[] array = new int[length];
Random rnd = new Random(); //подключаем случайные числа
for (int i = 0; i<length; i++)
{
array[i] = rnd.Next(1,10);
Console.Write($"{array[i]}  ");
}
Console.WriteLine();
for (int i = 0,j = 1; i < length/2; i++, j++)
{
    Console.WriteLine($"Произведение: {array[i]} * {array[length-j]} = {array[i]*array[length-j]}");
}