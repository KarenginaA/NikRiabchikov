//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


// int[] CreateArr(int size)
// {
//     int[] array = new int [size];

//     for(int i = 0; i < size; i++) 
//         array[i]= new Random().Next(100,1000);
//     return array;
// }
// int SearchEvenNum (int[] array)
// {
//     int count =0;

//     for(int i =0; i < array.Length; i++)
//         if (array[i] %2 ==0)
//             count++;
//         Console.WriteLine($"всего {array.Length} числа, {count} из них чётные");
//     return count;
// }


// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] result = CreateArr(size);
// ShowArray(result);
// Console.WriteLine(SearchEvenNum(result));

// //Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int[] CreateArr(int size, int min, int max)
// {
//     int[] array = new int [size];

//     for (int i = 0; i < size; i++)
//         array[i] = new Random().Next(min, max);
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }


// int SumOfUnevenIndex(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (i % 2 != 0)
//             sum += array[i];
//     return sum;
// }

// Console.Write("Задайте размер массива ");
// int size =Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int min =Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int max =Convert.ToInt32(Console.ReadLine());
// int[] arr = CreateArr( size,min,max);
// ShowArray(arr);

// Console.WriteLine(SumOfUnevenIndex(arr));

// //Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// double[] CreateArr(int size, int min, int max)
// {
//     double[] array = new double[size];

//     for(int i = 0; i < size; i++) 
//         array[i] = Math.Round(new Random().NextDouble()+ new Random().Next(min, max)  , 2);

//     return array;
// }

// void DiffBetweenNum (double[] array)
// {

//     double min = array[0];
//     double max = array[0];

//     for(int i = 0; i < array.Length; i++)
//     {
//         if (min > array[i])
//             min = array[i];
//         else if (max < array[i])
//             max = array[i];
//     }
//     Console.WriteLine(min + " - минмальное, " + max + " - максимальное.");
// }   

// void ShowArray(double[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите минимальное значение массива: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите максимальное значение массива: ");
// int max = Convert.ToInt32(Console.ReadLine());

// double[] array= CreateArr(size, min, max);
// DiffBetweenNum(array);
// ShowArray(array);


// Семинар 6

//Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.

// int PosNum(int M)
// {
//     int count = 0;
//     for( int i= 0 ; i < M; i++)
//     {
//         int n = Convert.ToInt32(Console.ReadLine());
//         if (n >= 0)
//         {
//             count++;
//         }

//     }
//     return count; 
// }
// Console.WriteLine("Введите числа");
// int num =Convert.ToInt32(Console.ReadLine());

// Console.Write(PosNum(num));
// Console.WriteLine(" положительных чисел ввел пользователь");

//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.

// double ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return Convert.ToDouble(Console.ReadLine() ?? "0");
// }

// double xVolume(double b1, double k1, double b2, double k2)
// {
//     double xVol = (b2 - b1) / (k1 - k2);
//     return xVol;
// }

// double yVolume(double b1, double k1, double x)
// {
//     double y = k1 * x + b1;
//     return y;
// }
// double b1 = ReadData("Введите значение b1: ");
// double k1 = ReadData("Введите значение k1: ");
// double b2 = ReadData("Введите значение b2: ");
// double k2 = ReadData("Введите значение k2: ");


// double x = xVolume(b1, k1, b2, k2);
// double y = yVolume(b1, k1, x);

// Console.WriteLine("Значение Х = " + x);
//  Console.WriteLine("Значение Y = " + y);

// Семинар 7

//Задайте двумерный массив размером m×n,
//заполненный случайными вещественными числами.

// double[,] CreateRandom2dArray(int m, int n)
// {
//     double[,] array = new double[m, n];

//     for(int i = 0; i < m; i++)

//         for(int j = 0; j < n; j++)

//             array[i,j] = Convert.ToDouble (new Random().Next(-100,100)) /10;

//     return array;
// }

// void Show2dArray(double[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//            Console.Write(array[i,j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// Console.Write("Input a quantity of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a quantity of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// double[,] myArray = CreateRandom2dArray(rows,colums);
// Show2dArray(myArray);


// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// int[,] CreateRandom2dArray(int rows, int colums)
// {
//     int[,] array = new int[rows, colums];

//     for(int i = 0; i < rows; i++)
    
//         for(int j = 0; j < colums; j++)
        
//             array[i,j] = new Random().Next(10,100);
        
//     return array;
// }
// void FindIndex(int[,] array, int pos1, int pos2)
// {
//     if (pos1 < 0 || pos2 < 0 || pos1 > array.GetLength(0) - 1 || pos2 > array.GetLength(1) - 1)
//         Console.WriteLine("Элемент не существует  ");
//     else
//         Console.WriteLine("Значение элемента массива array[{0},{1}] = {2}", pos1, pos2, array[pos1, pos2]);
// }

// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//            Console.Write(array[i,j] + " ");
         
//         Console.WriteLine();  
//     }
//     Console.WriteLine();  
// }
// Console.Write("Input a quantity of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a quantity of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.Write("Type first index: ");
// int pos1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Type second index: ");
// int pos2 = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = CreateRandom2dArray(rows, colums);
// FindIndex(myArray, pos1,pos2);
// Show2dArray(myArray);

// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// int[,] CreateRandom2dArray(int rows, int colums)
// {
//     int[,] array = new int[rows, colums];

//     for(int i = 0; i < rows; i++)

//     for(int j = 0; j < colums; j++)

//         array[i,j] = new Random().Next(0,10);

//     return array;
// }


// void Average(int[,] arr) 
// {   
//     int rows = arr.GetLength(0);
//     int cols = arr.GetLength(1);
//     double[] averages = new double[cols];
    
//     for (int j = 0; j < cols; j++) 
//     {
//         int sum = 0;
//         for (int i = 0; i < rows; i++) 
//         {
//             sum += arr[i, j];
//         }
//         averages[j] =Math.Round(((double)sum / rows),1);
//     }

//     for (int i = 0; i < averages.Length; i++)
//     {
//         Console.WriteLine($"Average of {i}row is: {averages[i]}");
//     }
    
// }

// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("Input a quantity of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a quantity of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = CreateRandom2dArray(rows,  colums);
// Show2dArray(myArray);
// Average(myArray);

// Семинар 8

// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.
// int[,] CreateRandom2dArray(int rows, int colums)
// {
//     int[,] array = new int[rows, colums];

//     for (int i = 0; i < rows; i++)

//         for (int j = 0; j < colums; j++)

//             array[i, j] = new Random().Next(1, 10);

//     return array;
// }
// void OrderSortElements(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     (array[i, k + 1], array[i, k]) = (array[i, k], array[i, k + 1]);
//                 }
//             }
//         }

//     }
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// Console.Write("Input a quantity of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a quantity of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = CreateRandom2dArray(rows, colums);
// Show2dArray(myArray);
// OrderSortElements(myArray);
// Show2dArray(myArray);

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[,] CreateRandom2dArray(int rows, int colums)
// {
//     int[,] array = new int[rows, colums];

//     for (int i = 0; i < rows; i++)

//         for (int j = 0; j < colums; j++)

//             array[i, j] = new Random().Next(1, 10);

//     return array;
// }


// void MinRow(int[,] array)
// {
//     int sum = 0;
//     int row = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sumOfRow = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sumOfRow += array[i, j];
//         }
//         if (sum == 0)
//         {
//             sum = sumOfRow;
//             row = i;
//         }
//         if (sumOfRow < sum)
//         {
//             sum = sumOfRow;
//             row = i;
//         }
//     }

//     Console.Write($"{row + 1} строка: {sum} ");
// }


// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// Console.Write("Input a quantity of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a quantity of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = CreateRandom2dArray(rows, colums);
// MinRow(myArray);
// Console.WriteLine();
// Show2dArray(myArray);

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//     Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// int[,] CreateRandom2dArray(int rows, int colums)
// {
//     int[,] array = new int[rows, colums];

//     for (int i = 0; i < rows; i++)

//         for (int j = 0; j < colums; j++)

//             array[i, j] = new Random().Next(1, 10);

//     return array;
// }


// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] mulMatrix(int[,] matrix1, int[,] matrix2)
// {
//     int rA = matrix1.GetLength(0);
//     int cA = matrix1.GetLength(1);
//     int rB = matrix2.GetLength(0);
//     int cB = matrix2.GetLength(1);
//     int[,] matrix = new int[rA, cB];


//     if (cA != rB)
//     {
//         Console.WriteLine("Матрицы не могут быть перемножены!!");
//     }
//     else
//     {
//         int temp = 0;

//         for (int i = 0; i < rA; i++)
//         {
//             for (int j = 0; j < cB; j++)
//             {
//                 temp = 0;
//                 for (int k = 0; k < cA; k++)
//                 {
//                     temp += matrix1[i, k] * matrix2[k, j];
//                 }
//                 matrix[i, j] = temp;
//             }
//         }

//         return matrix;
//     }
//     return matrix;
// }

// int[,] arr = CreateRandom2dArray(2, 2);
// int[,] arr1 = CreateRandom2dArray(2, 2);

// int[,] multypliedMatrix = mulMatrix(arr, arr1);

// Show2dArray(arr);
// Console.WriteLine();

// Show2dArray(arr1);
// Console.WriteLine();
// Show2dArray(multypliedMatrix);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//     Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] Create3dArray(int x, int y, int z)
// {
//     int[,,] array = new int[x, y, z];

//     int counter = 10;
//     for (int i = 0; i < x; i++)
//     {
//         for (int j = 0; j < y; j++)
//         {
//             for (int k = 0; k < z; k++)
//             {
//                 array[i, j, k] = counter;
//                 counter++;
//             }
//         }
//     }

//     return array;
// }

// void show3dArray(int[,,] array)
// {
//     int x, y, z;
//     x = array.GetLength(0);
//     y = array.GetLength(1);
//     z = array.GetLength(2);

//     for (int i = 0; i < x; i++)
//     {
//         for (int j = 0; j < y; j++)
//         {
//             for (int k = 0; k < z; k++)
//             {
//                 Console.Write($"array[{i},{j},{k}] = {array[i, j, k]}\t");
//             }

//             Console.WriteLine();
//         }
//     }
// }

// int[,,] arr = Create3dArray(2, 2, 2);
// show3dArray(arr);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

// void FillArraySpiral(int[,] array, int n)
// {
//     int i = 0, j = 0;
//     int value = 1;
//     for (int e = 0; e < n * n; e++)
//     {
//         int k = 0;
//         do { array[i, j++] = value++; } while (++k < n - 1);
//         for (k = 0; k < n - 1; k++) array[i++, j] = value++;
//         for (k = 0; k < n - 1; k++) array[i, j--] = value++;
//         for (k = 0; k < n - 1; k++) array[i--, j] = value++;
//         ++i; ++j;
//         n = n < 2 ? 0 : n - 2;
//     }
// }

// int[,] arr = new int[4,4];

//  FillArraySpiral(arr,4);

// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         Console.Write("{0,2} ", arr[i, j]);
//     }
//     Console.WriteLine();
// }

// Семинар 9

//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

// void ShowNum(int num)
// {
//     Console.Write(num +" ");
//     if(num > 1) ShowNum(num -1 );

// }
// ShowNum(10);

//Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
// int SumOfElements(int m, int n)
// {
//     int sum = m;
//     if (m == n)
//     {
//         return 0;
//     }
//     m++;
//     sum = m + SumOfElements(m, n);
//     return sum;
// }

// Console.Write("Введите число m: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число n: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write(SumOfElements(M - 1, N));

// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
//m=2 n=3

// int AkkermanFunction(int m, int n)
// {
//     if (m == 0)
//         return n + 1;
//     if (n == 0 && m > 0)
//         return AkkermanFunction(m - 1, 1);
//     return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
// }

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write(AkkermanFunction(m, n));


