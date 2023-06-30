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

////Альтернатива, математическая:
/*
int Prompt(string message)
{
    Console.WriteLine(message);
    string? value = Console.ReadLine();
    int number = Convert.ToInt32(value);
    return number;
}

int ReverseNumber(int a)
{
    int revNum = 0;
    int temp = a;
    while(temp > 0)
    {
        revNum = revNum * 10 + temp % 10; // 0+1 // 10+2=12 // 120+3=123 // 1230+2 // 12320+1 //12321
        temp /= 10; // temp = temp/10 // 1232 // 123 // 12 // 1 // 0
    }
    return revNum;
}

int a = Prompt("Введите 5-значное число: ");
int reverse = ReverseNumber(a);

if (a > 9999 && a< 1000000)
{
    if(reverse == a)
    {
        Console.WriteLine("Число является палиндромом");    
    }
    else
    {
        Console.WriteLine("Число НЕ является палиндромом"); 
    }

}
else
{
    Console.WriteLine("Вы ввели не 5-значное число!");   
}
*/

