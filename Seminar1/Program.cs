/*
 Напишите программу, которая на вход
  принимает
  два целых числа и проверет, 
  является ли первое число 
  квадратом второго:
  a=25, b= 5 => yes; a=2, b=10=> no
 */


System.Console.WriteLine("Введите два числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Первое число " + num1);
System.Console.WriteLine("Второе число " + num2);

if (num1 == num2 * num2)
{
    System.Console.WriteLine("Yes");
}
else 
{
    System.Console.WriteLine("No");
}

//Напишите программу, которая принимает на вход трёхзначное число и удаляет вторую цифру этого числа. Примеры: а=256=>26; а=891=>81

