﻿// Вывести на экран таблицу квадратов чисел от 1 до N.

System.Console.WriteLine("Введите диапазон выводимых чисел");
int n=Convert.ToInt32(System.Console.ReadLine());
int a=1; 

bool Check(int a)
{
    if (a<=n) return true; else return false;
}

Console.WriteLine("Число" + "\t" + "Квадрат числа");
while (Check (a))
    {
     Console.WriteLine(a + "\t" + a*a);
     a++;
    }
