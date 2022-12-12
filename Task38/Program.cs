double[] NewArray(int len) 
{
    double[] array = new double[len];
	for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,50);  
    }
    return array;
}

void PrintArray(double[] array) 
{
	for (int i = 0; i < array.Length; i++)
	{
		System.Console.Write($"{array[i]}\t");
	}
	System.Console.WriteLine();
}

double[] array = NewArray(4); 
PrintArray(array);

double MaxNumber (double[]array)
{
    double max = array[0];
	for (int i = 0; i < array.Length; i++)
	{
		if (max < array[i])
		{
			max = array[i];
		}
	}
	return max;
}

double MinNumber (double[]array)
{
    double min = array[0];
	for (int i = 0; i < array.Length; i++)
	{
		if (min > array[i])
		{
			min = array[i];
		}
	}
	return min;
}

double maxNum = MaxNumber(array);
double minNum = MinNumber(array);
double res = maxNum-minNum;
Console.Write($"разница между максимальным и минимальным элементов массива равна {res}");