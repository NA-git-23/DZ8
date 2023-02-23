// Домашнее задание
// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.


// Console.WriteLine("\nСортировка массива по убыванию строки: \n");
// int[,] arr = new int[3, 4];
// FillArrayRandom(arr);
// PrintArray(arr);
// OrderArrayRows(arr);
// Console.WriteLine();
// PrintArray(arr);
// Console.WriteLine();


// void FillArrayRandom(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }


// void OrderArrayRows(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       {
//         if (array[i, k] < array[i, k+1])
//         { 
//           int temp = array[i, k+1];
//           array[i, k+1] = array[i, k];
//           array[i, k] = temp;
//         }
//       }
//     }
//   } 
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }







// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.


// Console.WriteLine("\nСортировка массива по убыванию строки: \n");
// int[,] array = new int[4, 4];
// FillArrayRandom(array);
// PrintArray(array);

// int minSumLine = 0;
// int sumLine = MinRowSum(array, 0);
// for (int i = 1; i < array.GetLength(0); i++)
// {
//   int tempSumLine = MinRowSum(array, i);
//   if (sumLine > tempSumLine)
//   {
//     sumLine = tempSumLine;
//     minSumLine = i;
//   }
// }
// Console.WriteLine($"\nСтрокa {minSumLine+1}  с наименьшей суммой  элементов: {sumLine}");

// void FillArrayRandom(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }



// int MinRowSum (int[,] array, int i)
// {
//   int sumLine = array[i,0];
//   for (int j = 1; j < array.GetLength(1); j++)
//   {
//     sumLine += array[i,j];
//   }
//   return sumLine;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }








// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

Console.WriteLine("\nПроизведение двух таблиц: \n");
int[,] matrix1 = new int[3, 2];
int[,] matrix2 = new int[2, 2];
int[,] result = new int[3, 2];
PrintArray1(matrix1);
Console.WriteLine();
PrintArray2(matrix2);
Console.WriteLine();

Multiple(matrix1, matrix2, result);
Console.WriteLine($"\nПроизведение первой и второй матриц:");

for(int i=0; i < result.GetLength(0); ++i) {
    for(int j=0; j < result.GetLength(1); ++j) {
        Console.Write(result[i,j] + " ");
    }
    Console.WriteLine();
}


void PrintArray1(int[,] matr1)
{
for (int i = 0; i < matr1.GetLength(0); i++)
{
 for (int j = 0; j < matr1.GetLength(1); j++)
 {
  Random rnd = new Random();
  matr1[i,j] = Convert.ToInt32(rnd.Next(1, 10));
  Console.Write($"{matr1[i,j]} ");
  }
Console.WriteLine();
}
}



void PrintArray2( int[,] matr2)
{
for (int i = 0; i < matr2.GetLength(0); i++)
{
 for (int j = 0; j < matr2.GetLength(1); j++)
 {
  Random rnd = new Random();
  matr2[i,j] = Convert.ToInt32(rnd.Next(1, 10));
  Console.Write($"{matr2[i,j]} ");
  }
Console.WriteLine();
}
}

void Multiple(int[,] matrix1, int[,] matrix2, int[,] result)
{
  for (int i = 0; i < matrix1.GetLength(0); i++)
  {
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrix2.GetLength(0); k++)
      {
        sum += matrix1[i,k] * matrix2[k,j];
      }
      result[i,j] = sum;
    }
  }
}





// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.
// Задача 62: Заполните спирально массив 4 на 4.

