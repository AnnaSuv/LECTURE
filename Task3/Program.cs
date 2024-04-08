//Задачи с гирями: 
//Задача 1: даны два целых числа, надо найти большее из них.

int num1 = 47;
int num2 = 15;
if (num1>num2)
{
    System.Console.WriteLine(num1);
}
else
{
    System.Console.WriteLine(num2);
}

//Задача 2: дано 5 целых чисел, необходимо найти самое большое.

int a = 10;
int b = 1;
int c = 2;
int d = 3;
int e = 6;
int max = a;
if (b>max)
{
   max=b;
}
if (c>max)
{max=c;
}
if (d>max)
{
   max=d;
}
if (e>max)
{
   max=e;
}
    System.Console.WriteLine(max);
