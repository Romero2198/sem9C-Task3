Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"M = {m}; N = {n} -> A(m,n) = " + AckermanFunction(m, n));

int AckermanFunction(int m, int n)
{
    if (m == 0)
        return n++;
    if (n == 0)
        return AckermanFunction(m - 1, 1);
    if (m > 0 && n > 0)
    {
        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    }
    return AckermanFunction(m, n);
}