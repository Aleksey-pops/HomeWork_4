// 4. Найти сумму чисел одномерного массива стоящих на нечетной позиции


Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine()!);
int j = 0;
int t = 0;
int sum = 0;
int sum1 =0;
int[] Array = new int[length];
Random rnd = new Random();
for (int i = 0; i<length; i++)
{
Array[i] = rnd.Next(1,100);
    if(i % 2 == 0)
        {
            sum += Array[i];
            Console.Write($"Порядковый номер в массиве {i},   \tЧисло масива({Array[i]})  \tСумма чисел =  {sum}");
            j++;
        }
    if(i % 2 != 0)
        {
            sum1 += Array[i];
            Console.WriteLine($"\tПорядковый номер в массиве {i},   \tЧисло масива({Array[i]})  \tСумма чисел \t{sum1}");
            t++;
        }
}
Console.WriteLine($"\nКоличество чисел стоящих на четной позиции ={j} \tСумма чисел стоящее на четной позиции {sum}");
Console.WriteLine($"Количество чисел стоящих на четной позиции ={t} \tСумма чисел стоящее на нечетной позиции {sum1}");