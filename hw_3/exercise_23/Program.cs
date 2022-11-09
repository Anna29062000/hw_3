void cube(int n) // вычисляет кубы чисел до N
{
   for (int i = 1; i <= n; i++)
   {
        Console.WriteLine(Math.Pow(i, 3));
   }
}
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
cube(n);
