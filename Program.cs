//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
Console.Write("Введите число M- ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N- ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = M; i <=N; i++)
    Console.Write(" "+i);
*/

//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*

Console. WriteLine("Введите начальное число M:");
int m = Convert.ToInt32(Console. ReadLine());

Console. WriteLine("Введите начальное число M:");
 int n = Convert.ToInt32(Console. ReadLine());
Sum(m, n);


void Sum(int m, int n)
{
    Console. Write(SumMN(m - 1, n));
}


int SumMN(int m, int n)
{
    int result = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        result = m + SumMN(m, n);
        return result;
    }
}
*/

Console. WriteLine("Введите начальное число M:");
int numberM = Convert.ToInt32(Console. ReadLine());

Console. WriteLine("Введите начальное число N:");
 int numberN = Convert.ToInt32(Console. ReadLine());

int AckermannFunction (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
return AckermannFunction(numberM, numberN);
}

Console. WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {AckermannFunction(numberM, numberN)}");