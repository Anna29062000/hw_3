
int polindrom(int num) //Проверяет является ли палиндромом число и если да - возвращает 1, иначе - 0
{
   int n0, n1, n3, n4, res = 0;
   n0 = num/10000;
   n1 = (num/1000)%10;
   n3 = (num%100)/10;
   n4 = num%10;
   if ((n0 == n4) && (n1 == n3))
   {
       res = 1;
   }
   return res;
}

Console.WriteLine("Введите пятизначное число:");
int num = Convert.ToInt32(Console.ReadLine());
int n = polindrom(num);
if (n == 1) 
{
    Console.WriteLine("Палиндром");
}
else 
{
     Console.WriteLine("Не является палиндромом");
}