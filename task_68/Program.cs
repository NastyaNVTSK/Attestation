int AkkRec(int N, int M)
{
if (N == 0) return M + 1;
else if (M == 0) return AkkRec(N - 1, 1);
else return AkkRec(N - 1, AkkRec(N, M - 1));
}

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Значение функции Аккермана равно: {AkkRec(N,M)}");