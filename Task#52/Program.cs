int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m, n];

    for (int i = 0; i < m; ++i){
        for(int j = 0; j < n; ++j){
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); ++i){
        for(int j = 0; j < array.GetLength(1); ++j){
        Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine());

int[,] result = GetArray(rows, colums,1,10);
PrintArray(result);

Console.WriteLine(" ");
Console.WriteLine("Среднее арифметическое каждого столбца: ");

double res = 0;

for (int j = 0; j < result.GetLength(1); ++j){
        for(int i = 0; i < result.GetLength(0); ++i){
        res += result[i, j];
        }
    Console.Write(Math.Round(res/result.GetLength(0), 1) + ";  ");
    res = 0;
}
