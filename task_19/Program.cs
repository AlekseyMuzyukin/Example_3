Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
void Palindrom(int arg)
{
    if (arg < 99999 && arg > 9999)
    {
        int first = arg % 10;
        int recFirst = (arg / 10000) % 10;
        int recSecond = (arg / 1000) % 10;
        int sekond = (arg / 10) % 10;

        if (first == recFirst && recSecond == sekond)
        {
            Console.WriteLine("Число является полиндромом.");
        }
        else
        {
            Console.WriteLine("Число не является полиндромом");
        }
    }
    else
    {
        Console.WriteLine("Ввели неверное число");
    }
}
Palindrom(num);
