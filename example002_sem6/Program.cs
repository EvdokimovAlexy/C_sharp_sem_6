﻿// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
//  может ли существовать треугольник с сторонами такой длины.

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(CheckTrinagle(a, b, c));

bool CheckTrinagle(int a, int b, int c)
{
    return a < c + b && c < a + b && b < c + a; 
}
