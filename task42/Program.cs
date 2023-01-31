void GetBinaryView(int number)
{
    if(number == 0) return;
    GetBinaryView(number/2);
    Console.Write(number%2);
}


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

GetBinaryView(number);