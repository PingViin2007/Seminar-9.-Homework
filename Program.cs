// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите положительное число:");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;

if (n > 0)
{
    Console.WriteLine(NaturalNumber(n, m));

    int NaturalNumber(int n, int m)
    {
        if (n == m)
            return n;
        else
        {
            Console.Write($"{NaturalNumber(n, m + 1)}, ");
        } 
        return m;
    }
}
else
{
    Console.WriteLine("Это не положительное число!");
}












// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m > n)
{
    Console.WriteLine("Указанное число M должно быть меньше, чем N!");
}
else
{
    if (m < 1) {m = 0;}
    if (n < 1) {n = 0;}

    if (m == 0 && n == 0)
    {
        Console.WriteLine("Числа не натуральные! Сумма натуральных элементов от M до N равна 0.");
    }
    else
    {
        int CountNaturalSum(int m, int n)
        {
            if (m == n)
                return n;
            else
                return n + CountNaturalSum(m, n - 1);
        }

        if (m == 0)
        {
            Console.WriteLine($"Сумма натуральных элементов от M до N = {CountNaturalSum(m, n)}");
        }
        else
        {
            Console.WriteLine($"Сумма натуральных элементов от {m} до {n} = {CountNaturalSum(m, n)}");
        }
    }
}









// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите положительное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите положительное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 1 || n < 1)
{
    Console.WriteLine("Оба введённых числа (или одно из чисел) не положительные!");
}
else
{
    int Akkerman(int m, int n)
    {
        if (m == 0)
            return n + 1;
        if (m > 0 && n == 0)
            return Akkerman(m - 1, 1);
        else
            return Akkerman(m - 1, Akkerman(m, n - 1));
    }

    Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");
}