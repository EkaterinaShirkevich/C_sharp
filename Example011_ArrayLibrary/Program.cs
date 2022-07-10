void FillArray(int[] collection)
{
    int Length=collection.Length;
    int index=0;
    while(index<Length)
    {
        collection[index]=new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count=col.Length;
    int position=0;
    while(position<count)
    {
        Console.WriteLine(col[position]); //вывод на экран значения текущего эл-та
        position++;
    }

}

int IndexOf(int[]collection, int find)
{
    int count=collection.Length;
    int index=0;
    int position=-1; //если искомово эл-та нет в массиве - то будет это значение выходить
    while(index<count)
    {
        if(collection[index]==find)
        {
            position=index;
            break;
        }
        index++;
    }
    return position;
}

int[]array=new int[10]; //обозначает: создай новый массив из 10 элементов

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos=IndexOf(array,12);
Console.WriteLine(pos);


