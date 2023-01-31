void Treug(int A, int B, int C)
{
    if(A + B > C && B + C > A && A + C > B)
    {
    Console.Write("Треугольник с такими сторонами существует");
    }
    else
    {
    Console.Write("Треугольник с такими сторонами не существует"); 
    }
}



Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число C: ");
int C = Convert.ToInt32(Console.ReadLine());

Treug(A,B,C);
