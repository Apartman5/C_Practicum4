﻿// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int Prompt()
{
    Console.WriteLine("введите число ");
    return Convert.ToInt32(Console.ReadLine());
}

int number = Prompt(); // строка используется в обеих задачах

// string num = Convert.ToString(number);

// Console.WriteLine(num.Length);

int Mult(int n)
{
    int mult = 1;
    for (int i = 1; i <= n; i++)
        mult *= i;
    return mult;
        
}
Console.WriteLine(Mult(number));