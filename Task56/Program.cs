// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
//строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
     

    for(int i =0; i < matrixForPrint.GetLength(0); i++ )
     {
        for(int j = 0; j < matrixForPrint.GetLength(1); j++)    
        {
            System.Console.Write(matrixForPrint[i,j] + "\t");
        }
        System.Console.WriteLine();
     }

}

int MinSum(int[,] matrix)
{
    int minSum = int.MaxValue;
    int minIndex = 0;
    int sum = 0;
   
    for(int j = 0; j < matrix.GetLength(1); j++)
     {
        for(int i = 0; i < matrix.GetLength(0); i++)    
        {
            sum = sum + matrix[i,j];
            if(sum < minSum)
            {
                minSum = sum;
                minIndex = i;
            }
            sum = 0;
        }
        
}
return minIndex + 1;
}


//---------------------основная часть кода--------------

int rows = ReadInt("Введите количество строк: ");
int colons = ReadInt("Введите количество столбцов: ");
int[,] matrix = FillMatrix(rows, colons, 0, 9);
PrintMatrix(matrix);
MinSum(matrix);
System.Console.WriteLine($"Минимальная сумма элементов находится в строке {MinSum(matrix)} ");