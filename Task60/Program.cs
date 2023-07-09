// Задача 60. ...Сформируйте трёхмерный массив из двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] FillMatrix(int row, int colon, int line, int minRange, int maxRange)
{
    int[,,] tempMatrix = new int[row, colon, line];
    Random rand = new Random();

    for(int i =0; i < tempMatrix.GetLength(0); i++ )
     {
        for(int j = 0; j < tempMatrix.GetLength(1); j++)    
        { 
            for(int k = 0; k < tempMatrix.GetLength(2); k++)
            {
            tempMatrix[i,j,k] = rand.Next(minRange, maxRange + 1);
            }
        }
     }

     return tempMatrix;
}

int[] ReadInt(string text)
{
   Console.Write(text);
   return Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse);
}


void PrintMatrix(int[,,] matrixForPrint)
{
     for(int i =0; i < matrixForPrint.GetLength(0); i++ )
     {
        for(int j = 0; j < matrixForPrint.GetLength(1); j++)   
        {
            for(int k = 0; k < matrixForPrint.GetLength(2); k++)
            {
                System.Console.Write(matrixForPrint[i,j,k] + "(" + i + "," + j + "," + k + ")" + "\t");
            }
        System.Console.WriteLine();
     }

}
}



//---------------------основная часть кода--------------

int [] size = ReadInt("Задайте количество строк, столбцов и рядов через запятую: ");
int [] range = ReadInt("Задайте минимальный и максимальный элемент массив через запятую: ");
int[,,] matrix = FillMatrix(size[0], size[1], size[2], range[0], range[1]);
PrintMatrix(matrix);
System.Console.WriteLine();

