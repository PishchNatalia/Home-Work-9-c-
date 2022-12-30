// Домашняя работа 9.
// Задача 1.Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

/*
int n = InputInt("Введите положительное число: ");
int m = 1;
if (n < 1)
{
    Console.WriteLine("Ввели не положительное число");
}
Console.WriteLine(NaturalNumber(n,m));
int NaturalNumber(int n, int m)
{
    if (n == m)
    return n;
    else
    Console.Write($"{NaturalNumber(n,m + 1)}, ");
    return m;
}
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
*/
// Задача 2.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/*
int m = InputInt("Введите M: ");
int n = InputInt("Введите N: ");
Console.WriteLine("Сумма элементов от {m} до {n} = {CountNaturalSum(m,n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
int CountNaturalSum(int m, int n)  
{
    if (m == n)
    return n;
    return n + CountNaturalSum(m,n - 1);
} 
*/

// Задача 3.Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
AkkermanFunction(m,n);
void AkkermanFunction(int m,int n) // Вызов функции Аккермана
{
    Console.Write(Akkerman(m,n));
}
int Akkerman(int m, int n)  // Функция Аккермана
{
    if (m == 0)
    {
    return n + 1;
    }
     else if (m  > 0 && n == 0)
     {
        return Akkerman(m - 1, 1);
     }   
        else
        {
            return Akkerman(m - 1, Akkerman(m,n - 1));
        }    
}


*/
