                    //
string[,] table = new string[2, 5];
//string.Empty
//table[0,0] table[0,1] table [0,2] table [0,4]
//table[1,0] table[1,1] table [1,2] table [1,4]


//table[1, 2] = "слово";

//for(int rows = 0; rows < 2; rows = rows + 1)
//{
//    for (int columns = 0; columns < 5; columns = columns + 1)
//    {
//        Console.WriteLine($"-{table[rows, columns]}-");
//    }
//}


int[,] matrix = new int[3, 4];

void PrintArray(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i = i + 1)
{
    for (int j = 0; j < matrix.GetLength(1); j = j + 1)
    {
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();
}
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i = i + 1)
    {
        for (int j = 0; j < matr.GetLength(1); j = j + 1)
        {
        matr[i, j] = new Random().Next(1,10); // [1,10]
        }
    }
}

int[,] matr = new int[3,4];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);