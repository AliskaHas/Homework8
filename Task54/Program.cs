// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] FillMatrix(int row, int colon, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, colon];
    Random rand = new Random();

    for(int i =0; i < tempMatrix.GetLength(0); i++ )// или i < row
     {
        for(int j = 0; j < tempMatrix.GetLength(1); j++)    //j количество столбцов
        {
            tempMatrix[i,j] = rand.Next(leftRange, rightRange + 1);
        }
     }

     return tempMatrix;
}

int ReadInt(string text)
{
   Console.Write(text);
   return Convert.ToInt32(Console.ReadLine());
}


void PrintMatrix(int[,] matrixForPrint)
{
     

    for(int i =0; i < matrixForPrint.GetLength(0); i++ )// или i < row
     {
        for(int j = 0; j < matrixForPrint.GetLength(1); j++)    //j количество столбцов
        {
            System.Console.Write(matrixForPrint[i,j] + "\t");
        }
        System.Console.WriteLine();
     }

}

int[,] ChangeElements(int[,] matrix)
{
    int[] temp = new int[matrix.GetLength(0)];
   
    for(int i = 0; i < matrix.GetLength(0); i++ )
     {
        for(int j = 0; j < matrix.GetLength(1); j++)    
        {
            temp[j] = matrix[i,j];
        }
        Array.Sort(temp, (x,y) => y.CompareTo(x));
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = temp[j];
        }
     }
     return matrix;
}


//---------------------основная часть кода--------------

int rows = ReadInt("Введите количество строк: ");
int colons = ReadInt("Введите количество столбцов: ");
int[,] matrix = FillMatrix(rows, colons, 0, 9);
PrintMatrix(matrix);
ChangeElements(matrix);
System.Console.WriteLine();
PrintMatrix(matrix);