int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m, n];

    for (int i = 0; i < m; ++i){
        for(int j = 0; j < n; ++j){
            result[i, j] = new Random().Next(minValue, maxValue+1);
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

int[,] result = GetArray(rows, colums,0,9);
PrintArray(result);

Console.WriteLine("Введите координаты: ");
int a = int.Parse(Console.ReadLine());
int b = int. Parse(Console.ReadLine());
if (a > rows || b > colums){
    Console.WriteLine("Числа с координатами [" + a +", " + b + "] -> нет.");
}
else{
    Console.WriteLine("Элемент массива на позиции [" + a +", " + b + "] -> " + result[a,b]);
}