Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
void TableCub(int arg)
{
    int i = 1;
    if(arg > 0)
    {
        while(i <= arg)
        {
            Console.WriteLine($"{i,3} {Math. Pow(i, 3),3}");
            i++;
        }
    }
    else
    {
        Console.WriteLine("Вы ввели отрицательное число"); 
    }
}

TableCub(num);