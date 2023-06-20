// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = Prompt("Введите m");
int n = Prompt("Введите n");
Console.WriteLine(PrintNumbers(m, n));
int PrintNumbers(int m, int n)
{
    if (m == 0)
    {
        return n + 1; 
    }
    
    else 
        if (m != 0 && n == 0)
        {
            return PrintNumbers(m - 1, 1);
        }
    
    else 
    {
        return PrintNumbers(m - 1, PrintNumbers(m, n - 1));
    }
}