// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int M = int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine());
void PrintingTheSumOfNumbers(int start, int end, int sum)
{
    if (M > N) 
    {
        Console.WriteLine("Сумма натуральных элементов:"  + sum);  return ;
    }
    sum += (M++);
    PrintingTheSumOfNumbers(M, N, sum);
}
PrintingTheSumOfNumbers(M, N, 0);