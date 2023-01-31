void FillArrayWithRandom(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
}

void ReverseArray(int[] array)
{
    int temp = 0;

    for(int i = 0; i < array.Length/2; i++)
    {
        temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}


int[] array = new int [5];
FillArrayWithRandom(array);
Console.Write("Ваш случайный массив: ");
Console.WriteLine(string.Join(", ", array));
ReverseArray(array);
Console.Write("Ваш перевернутый массив: ");
Console.WriteLine(string.Join(", ", array));
