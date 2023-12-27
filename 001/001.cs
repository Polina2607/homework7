// Задайте значения M и N. Напишите программу, которая выведет все натуральные 
//числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

System.Console.WriteLine("Введите первое число");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

void PrintNumbers(int startNum, int endNum) 
{
    System.Console.WriteLine(startNum);
    if(startNum >= endNum)
    {
        return;
    }
    PrintNumbers(startNum+1, endNum);
}
PrintNumbers(num,num2);
