///Задача 2: Задайте массив на 10 целых чисел. 
///Напишите программу, которая определяет количество чётных чисел в массиве.

int size = 10;
int[] array = new int[size];
Random r = new Random();
for (int i = 0; i < size; i++)
    array[i] = r.Next(10);

for (int i = 0; i < size; i++)
    Console.Write(array[i] + " ");

Console.WriteLine();

int count = 0;
for (int i = 0; i < size; i++)
{
    if (array[i] % 2 == 0)
        count++;
}
System.Console.WriteLine();
System.Console.WriteLine(count);