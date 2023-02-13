Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine()!);


int[] Array = new int[length];
Random rnd = new Random(); //подключаем случайные числа
for (int i=0; i<length; i++)
{
Array[i] = rnd.Next(100,1000);
        if (Array[i] % 2 == 0)
        {
            Console.WriteLine($"Порядковый номер в массиве {i}: \tЧетное число \t{Array[i]}");
        }
        else
        {
        Console.WriteLine($"Порядковый номер в массиве {i}: \tНечетное  число {Array[i]}");
        }     
}
