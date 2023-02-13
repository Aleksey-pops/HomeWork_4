// 1 .Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 2);
//     Console.Write($"\t {array[i]}");
// }

int[] newArray = new int[8];
for (int i = 0; i < newArray.Length; i++)
{
    newArray[i] = new Random().Next(0, 2);
    Console.WriteLine($"Порядковый номкр № {i + 1}  \t Элементы масива из 8 цифр от 0 до 1 = {newArray[i]}");
}