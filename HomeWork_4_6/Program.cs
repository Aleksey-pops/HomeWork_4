// 6. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.
Console.Write("Введите размер массива: ");
int number = int.Parse(Console.ReadLine()!);
double max = 0;
double min = 200;
double[] newArray = new double[number];
for (int i = 0; i < newArray.Length; i++)
{
    newArray[i] = new Random().Next(100, 200)* 0.01;
    Console.WriteLine($"Порядковый номер № {i + 1}  \t Элементы масива = {newArray[i]}");
    if(newArray[i] > max)
       max = newArray[i];
    if(newArray[i]< min)
        min = newArray[i]; 
}
Console.WriteLine($"Максимальное число = {max}");
Console.WriteLine($"Минимальное число = {min}");
Console.WriteLine($"Разница между максимальным и минимальным числом = {max - min}");