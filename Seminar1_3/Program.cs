﻿/*
 Напишите программу, которая принимает
  на вход трёхзначное целое число 
  и на  выходе показывает сумму первой 
  и последней цифры этого числа.
 (напр.:456=>10
 782=>9;
 918=>17)
 6/2=3
 7/2=6/2+1  7%2= ост 1
 25 % 10 = ост 5
 253 % 10 = ост3
 1025 % 100 = ост 25

15 / 10 = 1
125/10 = 12
125/100 = 1
*/

System.Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());//456
int first_num = num1 / 100;
int last_num = num1 % 10;
int sum = first_num + last_num;
System.Console.WriteLine("Сумма первой и последней цифры числа " + num1 + " " + "равна " + sum);
System.Console.WriteLine($"Сумма первой и последней цифры числа {num1}  равна {sum}");