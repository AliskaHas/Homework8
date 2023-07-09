// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int ReadInt(string text)
{
   Console.Write(text);
   return Convert.ToInt32(Console.ReadLine());
}

string[,] FillMatrix(string[,] matrix)
{   string[,] matrix = new string[row,col];
    int I0 = 0, In = 0, J0 =0, Jn = 0;
    int k = 1, i = 0, j = 0;
    while(k <= row*col)
    {
        if(k < 10) matrix[i,j] = "0" + k.ToString();
        else
        {
            matrix[i,j] = k.ToString();
        }
        if(i == I0 && j < col - Jn -1) j++;
        else if(j == col - Jn - 1 && i < row - In - 1) i++;
        else if(i == row - In - 1 && j > J0) j--;
        else
        {
            i--;
        }
        if((i == I0 + 1) && (j == J0) && (J0!= col - Jn - 1))
        {
            I0++;
            In++;
            J0++;
            Jn++;
        }
        k++;
    } 
    return matrix;
}

void PrintMatrix(string[,] matrixForPrint)
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

//---------------------основная часть кода--------------

var row = ReadInt("Введите количество строк: ");
var col = ReadInt("Введите количество столбцов: ");
int[] range = ReadInt("Задайте минимальный и максимальный элемент массива через запятую: ");

string[,] matrix = FillMatrix(matrix);
PrintMatrix(matrix);