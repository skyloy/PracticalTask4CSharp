// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
void DigitsSum(int num)
{
    int res = 0;
    int digits = 0;
    for (int i = num; i > 0; i/=10)
    {
        digits = num % 10;
        res += digits;
        num /= 10;
    }
    Console.WriteLine(res);
}
Console.WriteLine("Please enter the number:");
int numb = Convert.ToInt32(Console.ReadLine());
DigitsSum(numb);