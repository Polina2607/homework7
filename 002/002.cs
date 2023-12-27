// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m =3 и n=2.

Console.WriteLine("Введите значение M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение N");
int n = Convert.ToInt32(Console.ReadLine());

int akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  if (m > 0 && n == 0) return akkerman(m - 1, 1);
  else return akkerman(m - 1, akkerman(m, n - 1));
}

System.Console.WriteLine(akkerman(m,n));