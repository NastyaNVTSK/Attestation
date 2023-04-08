string ValueRec(int N)
    {
        if (N == 0) return " ";
        return Convert.ToString (N) + " " + ValueRec(N-1);
    }

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ValueRec(N));

    