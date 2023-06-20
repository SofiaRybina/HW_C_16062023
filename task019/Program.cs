// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

int NUM = Prompt("Enter five-digit number: ");
Palindrom(NUM);

void Palindrom(int num)
{
    int N0 = 0;
    int N1 = 0;
    int N3 = 0;
    int N4 = 0;
    int number = Math.Abs(num);

    if (number > 9999 && number < 100000)
    {
        N0 = number / 10000;
        //Console.WriteLine($"N0={N0}");
        N1 = (number / 1000) % 10;
        //Console.WriteLine($"N1={N1}");
        N3 = (number / 10) % 10;
        //Console.WriteLine($"N3={N3}");
        N4 = number % 10;
        //Console.WriteLine($"N4={N4}");
        if (N0 == N4 && N1 == N3)
        {
            Console.WriteLine($"{NUM} -> да");
        }
        else
        {
            Console.WriteLine($"{NUM} -> нет");
        }
    }
    else
    {
        Console.WriteLine("Wrong number!");
    }
}

