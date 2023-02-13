// 3. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] newArray = new int[123];
Random rnd = new Random(); //подключаем случайные числа
int j = 0;
for (int i=0; i<123; i++)
{
    newArray[i] = rnd.Next(1,200);
   
    Console.WriteLine($"Число масива №{i + 1} \t{newArray[i]}  ");
    //Console.WriteLine();
    if (newArray[i]>=10 && newArray[i]<=99)
    {  
        j++; 
        Console.WriteLine($"Подсчет элементов({j})");
        // Console.WriteLine();
    }
}
Console.WriteLine($"Количество элементов которые находятся в отрезке [10,99] = {j}");