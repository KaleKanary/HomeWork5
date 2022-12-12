/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

int min = 99;
int max = 999;
int size = 4;
int[] numbers =  new int [size];
ReadArray(numbers);
WriteArray(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        Console.WriteLine($"Четное число  {numbers[i]}");
    }
}


void ReadArray(int[] array)
{
    for (int i = 0; i < numbers.Length; i++)
    {
    numbers[i] = new Random().Next(min, max + 1);
    }
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}