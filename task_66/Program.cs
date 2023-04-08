int Summ(int N, int M)
{
if (N==M)
return N;
else return N + Summ(N + 1, M);
}

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма всех целых чисел от {N} до {M} равна {Summ(N,M)}");