double[,] GetArray(int m, int n){
    double[,] result = new double[m, n];

    for (int i = 0; i < m; ++i){
        for(int j = 0; j < n; ++j){
            result[i, j] = new Random().NextDouble()*10;
        }
    }
    return result;
}

void PrintArray(double[,] array){
    for (int i = 0; i < array.GetLength(0); ++i){
        for(int j = 0; j < array.GetLength(1); ++j){
        Console.Write(Math.Round(array[i,j], 1) + "  ");
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine());

double[,] result = GetArray(rows, colums);
PrintArray(result);