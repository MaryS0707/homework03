/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да*/

bool func (string num)
{
    if (num[0] == num[4] && num[1] == num[3]) return true;
    else return false;
}

string number = "23432";

if (func(number)) Console.WriteLine($"{number} -> да");
else Console.WriteLine($"{number} -> нет");