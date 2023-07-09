// Задача 58: Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillMatrix(int row, int colon, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, colon];
    Random rand = new Random();

    for(int i =0; i < tempMatrix.GetLength(0); i++ )
     {
        for(int j = 0; j < tempMatrix.GetLength(1); j++)    
        {
            tempMatrix[i,j] = rand.Next(leftRange, rightRange + 1);
        }
     }

     return tempMatrix;
}

int[] ReadInt(string text)
{
   Console.Write(text);
   return Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse);
}


void PrintMatrix(int[,] matrixForPrint)
{
     

    for(int i =0; i < matrixForPrint.GetLength(0); i++ )
     {
        for(int j = 0; j < matrixForPrint.GetLength(1); j++)   
        {
            System.Console.Write(matrixForPrint[i,j] + "\t");
        }
        System.Console.WriteLine();
     }

}

int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    
  if(matrix1.GetLength(1)!= matrix2.GetLength(0))
  {
    System.Console.Write("Умножение матриц невозможно: количество элементов в строке первой матрицы не соответствует количеству элементов в столбце второй матрицы ");
    System.Console.WriteLine();
  }
  int [,] matrix3 = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
     for(int i = 0; i < matrix1.GetLength(0); i++)
         {
            for(int j = 0; j < matrix2.GetLength(1); j++) 
            {
                for(int k = 0; k < matrix2.GetLength(0); k ++)
                {
                   matrix3[i,j] += matrix1[i,k] * matrix2[k,j];
                }
            }
           }

         return matrix3;
 }


//---------------------основная часть кода--------------

int [] size = ReadInt("Задайте количество строк и столбцов через запятую: ");
int [] range = ReadInt("Задайте минимальный и максимальный элемент массив через запятую: ");
int[,] matrix1 = FillMatrix(size[0], size[1], range[0], range[1]);
PrintMatrix(matrix1);
System.Console.WriteLine();
int[,] matrix2 = FillMatrix(size[0], size[1], range[0], range[1]);
PrintMatrix(matrix2);
System.Console.WriteLine();
int[,] matrix3 = MultiplicationMatrix(matrix1, matrix2);
PrintMatrix(matrix3);