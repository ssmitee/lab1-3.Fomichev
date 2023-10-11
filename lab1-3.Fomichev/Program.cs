Console.Write("Введите число n (10 ≤ n ≤ 999, число десятков не равно 0): ");
int n = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

if (n >= 10 && n <= 999 && n % 100 != 0)
{
    int x = n / 10;
    int y = n % 10;

    int restoredNumber = x * 100 + y;

    Console.WriteLine($"Исходное число x: {restoredNumber}");
}
else
{
    Console.WriteLine("Введенное число не соответствует условиям (10 ≤ n ≤ 999, число десятков не равно 0).");
}