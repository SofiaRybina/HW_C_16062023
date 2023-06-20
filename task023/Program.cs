// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine()!;
    int result = Math.Abs(Convert.ToInt32(value));
    return result;
}

void GetNum(int num)
{
    int power = 3; //степень
    int i = 1;
    Console.Write($"{num} -> ");
    while(i <= num)
    {
        if(i == 1)
        {
            Console.Write(Math.Pow(i,power));
            i++;
        }
        else
        {
            Console.Write(","+ " "+ Math.Pow(i,power));
            i++;
        }
    }
}

int n = Prompt("Input N: ");
GetNum(n);