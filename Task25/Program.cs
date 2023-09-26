// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
using System.Reflection.Metadata.Ecma335;

int Power(int num1, int num2)
{
    int res = num1;
        for (int i = 0; i < num2 - 1; i++)
    {
        res *= num1;
    }
    return res;
}
Console.WriteLine("Please enter the numbers");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());
if(numB < 0)

    Console.WriteLine("this is not a natural number");
else
    Console.WriteLine(Power(numA, numB));