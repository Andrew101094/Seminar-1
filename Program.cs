// Напишите программу, которая на вход принимает два числа и проверяет, какое число большее.
// a = 25, b = 7, c = 15 -> max = 25

Console.WriteLine("Введите два числа: ");
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2)
{
    int res = number1;
    Console.WriteLine("Наибольшее число: " + res);
}
else
{
    int res = number2; 
    Console.WriteLine("Наибольшее число: " + res);
}
