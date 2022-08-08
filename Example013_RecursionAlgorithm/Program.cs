// двумерные массивы 
//string [,] table = new string [2,5]; //здесь будет массив из 2 строк и 5 столбцов
                                     
//table[1,2]="some word"; //для поиска эл-та указывавем сначала строку, а потом столбец
                        //где этот эл-т находится; как система координат

//для строк инициализация идет через константу String.Empty
//for (int rows=0; rows<2; rows++) //внешний цикл идёт по кол-ву строк
//{
  //  for (int columns=0; columns<5; columns++) //внутр.цикл идёт по кол-ву столбцов
    //{
      //  Console.WriteLine($"--{table[rows,columns]}--");
    //}
//}

//GetLength(0) это кол-во строк, GetLength(1) - столбцов


void PrintArray(int [,] matr)
{
for (int i=0; i<matr.GetLength(0); i++)   //i и j обычно используются, но это необязательно,
{                         // как в примере выше тоже можно (другие имена)
    for (int j=0; j<matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i,j]} ");
    }
    Console.WriteLine(); // принудительно делаем переход на новую строку при выводе
}                         // для более удобного восприятия
}

void FillArray(int[,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++) 
    {
       for (int j=0; j<matr.GetLength(1); j++)
       {
        matr[i,j]=new Random().Next(1,10);
       } 
    }
}

int [,] matrix = new int[3,4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

