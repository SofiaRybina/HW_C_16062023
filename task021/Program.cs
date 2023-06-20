// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

int x1 = Prompt("Input x1: ");
int y1 = Prompt("Input y1: ");
int z1 = Prompt("Input z1: ");
Console.WriteLine();

int x2 = Prompt("Input x2: ");
int y2 = Prompt("Input y2: ");
int z2 = Prompt("Input z2: ");
Console.WriteLine();

Console.WriteLine($"X1={x1},Y1={y1},Z1={z1}");
Console.WriteLine($"X2={x2},Y2={y2},Z2={z2}");

double AB = Math.Round(Math.Sqrt(((x2-x1)*(x2-x1)) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1)),2);
Console.WriteLine($"AB -> {AB}");