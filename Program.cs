/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
*/
#region 
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] array)
{
    int min = 1;
    int max = 10;
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(" " + array[i, j] + "");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortingAnArray(int[,] array)
{
	for(int i = 0; i < array.GetLength(0); i++)
	{
		for(int j = 0; j < array.GetLength(1); j++)
		{
			for(int k = 0; k < array.GetLength(1) -1; k++)
			{
				if(array[i, k] < array[i, k + 1])
				{
					int temp = array[i, k + 1];
					array[i, k + 1] = array[i, k];
					array[i, k] = temp;
				}

			}
		}
	}
}

int rows = InputNum(" Введите количество строк: ");
int cols = InputNum(" Введите количество столбцов: ");

int[,] myArray = Create2DArray(rows, cols);
Fill2DArray(myArray);
Print2DArray(myArray);
SortingAnArray(myArray);
Console.WriteLine();
Print2DArray(myArray);
#endregion
/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
*/
#region 
int InputNumb(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArr(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArr(int[,] array)
{
    int min = 1;
    int max = 5;
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
}

void Print2DArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(" " + array[i, j] + "");
        Console.WriteLine();
    }
    Console.WriteLine();
    
}

void ProductOfTwoMatrices(int[,] myArray1, int[,] myArray2, int[,] myArray3)
{
    for(int i = 0; i < myArray3.GetLength(0); i++)
    {
        for(int j = 0; j < myArray3.GetLength(1); j++) 
        {
            int sum = 0;
            for(int k = 0; k < myArray1.GetLength(0); k++)
            {
                sum += myArray1[i, k] * myArray2[k, j];
            } 
            myArray3[i, j] = sum;
        }
    }
}

int rowsMat1 = InputNumb(" Введите количество строк первой матрици: ");
int colsMat1 = InputNumb(" Введите количество столбцов первой матрици: ");
int rowsMat2 = InputNumb(" Введите количество строк второй матрици: ");
int colsMat2 = InputNumb(" Введите количество столбцов второй матрици: ");

int[,] myArray1 = Create2DArr(rowsMat1, colsMat1);
Fill2DArr(myArray1);
Print2DArray(myArray1);

int[,] myArray2 = Create2DArray(rowsMat2, colsMat2);
Fill2DArr(myArray2);
Print2DArr(myArray2);

int[,] myArray3 = new int[rowsMat1, colsMat2];
ProductOfTwoMatrices(myArray1, myArray2, myArray3);
Print2DArr(myArray3);
#endregion
/*
Задайте прямоугольный двумерный массив. Напишите 
программу, которая будет находить строку с наименьшей суммой элементов.
*/
#region 
int InputNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DAr(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DAr(int[,] array)
{
    int min = 1;
    int max = 5;
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
}

void Print2DAr(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(" " + array[i, j]);
        Console.WriteLine();
    }
    Console.WriteLine();
}

int SumElement(int[,] array)
{
    int[] sumArray = new int[array.GetLength(0)];
    Console.Write(" Сумма по строке: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumArray[i] += array[i, j];
        }
        Console.Write("\t" + sumArray[i] + " ");
    }

    int minSum = sumArray[0];
    int minRowse = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if(sumArray[i] < minSum)
        {
            minSum = sumArray[i];
            minRowse = i + 1;
        }
    }
    return minRowse;
}   

int row = InputNumber(" Введите количество строк: ");
int col = InputNumber(" Введите количество столбцов: ");

int[,] myArr = Create2DAr(row, col);
Fill2DAr(myArray);
Print2DAr(myArray);
int sumElem = SumElement(myArr);
Console.WriteLine();
Console.WriteLine(" Минимальная сумма элементов на строке номер: " + sumElem);
#endregion
/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
*/
#region 
int InputNumbers(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[, ,] Create3DArray(int rows, int columns, int volum )
{
    return new int[rows, columns, volum];
}

void Fill3DArray(int[,,] array)
{
  int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array.GetLength(0); x++)
  {
    for (int y = 0; y < array.GetLength(1); y++)
    {
      for (int z = 0; z < array.GetLength(2); z++)
      {
        array[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

void Print3DArray (int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

int rowse = InputNumbers(" Введите количество строк: ");
int colse = InputNumbers(" Введите количество столбцов: ");
int volum = InputNumbers(" Введите размер в 3D: ");
Console.WriteLine($"");

int[, ,] myArr3D = Create3DArray(rowse, colse, volum);
Fill3DArray(myArr3D);
Print3DArray(myArr3D);
#endregion


