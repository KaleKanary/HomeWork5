/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int min = 10;
int max = 100;
int size = 4;
int oddsum = 0;

int[] numbers =  new int [size];
ReadArray(numbers);
WriteArray(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    if ( i % 2 != 0)
    {
       oddsum += numbers[i];
    }
}
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях  {oddsum}");

//Методы
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