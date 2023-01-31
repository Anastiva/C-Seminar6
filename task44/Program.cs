void PrintFib(int N)
{
    Console.Write("0 1 ");
    int neighbour1 = 0;
    int neighbour2 = 1;
    int res = 0;
    for(int i = 0; i < N - 2; i++)
    {
        res = neighbour1 + neighbour2;
        Console.Write(res + " ");
        neighbour1 = neighbour2;
        neighbour2 = res;
    }
}

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

PrintFib(N);
