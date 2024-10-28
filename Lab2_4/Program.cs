using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение x (в радианах):");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение q (порог для остановки):");
        double q = Convert.ToDouble(Console.ReadLine());

        double cosX = 1.0; // Начальное значение для cos(x)
        double term = 1.0; // Первое слагаемое (1)
        int n = 0; // Счетчик слагаемых

        // Вычисление ряда Тейлора
        do
        {
            n++;
            term *= -x * x / (2 * n * (2 * n - 1)); // Вычисляем следующее слагаемое
            cosX += term; // Добавляем слагаемое к сумме
        } while (Math.Abs(term) >= q); // Останавливаемся, если модуль слагаемого меньше q

        Console.WriteLine($"Приближенное значение cos({x}) = {cosX}");
        Console.WriteLine($"Количество учтенных слагаемых: {n}");
    }
}
