// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*int Threenum(int num)
{
    int des = num % 100 /10;
    return des;
}
Console.Write("Введите трехзначное число: ");
int newnum = Convert.ToInt32(Console.ReadLine());
int res = Threenum(newnum);
if (newnum > 99 && newnum < 1000)
{
  Console.WriteLine(res); 
}
else
{
    Console.WriteLine("Ошибка, условие введено не верно!");
}
*/

//Без проверки

/*int Threenum(int num)
{
    int des = num % 100 /10;
    return des;
}
Console.Write("Введите трехзначное число: ");
int newnum = Convert.ToInt32(Console.ReadLine());
int res = Threenum(newnum);
Console.WriteLine(res); */

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//Без функции
/*Console.Write("Введите число: ");
int newnum = Convert.ToInt32(Console.ReadLine());

if (newnum > 99)
{
  string str = newnum.ToString();
    Console.WriteLine(str[2]); 
}
else
{
    Console.WriteLine("Нет третьего числа!");
}
*/

//C функцией

/* 
int Posnum(int num)
{   
    int minus = -1;
    string str = num.ToString();
    if (num > 99)
        Console.WriteLine(str[2]);
    else
        Console.WriteLine(minus);
    return num;
}
Console.Write("Введите число: ");
int newnum = Convert.ToInt32(Console.ReadLine());
Posnum(newnum);
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/* void Day(int num)
{
    if ((num <= 8 &&num == 6)||(num <= 8 &&num == 7) )
        Console.WriteLine("Ура, этот день выходной!");
    else if (num >=1 && num <=5)
        Console.WriteLine("Будний день.");
    else 
        Console.WriteLine("Введено не верное число!");
}
Console.Write("Введите число (от 1 до 7): ");
int newnum = Convert.ToInt32(Console.ReadLine());
Day(newnum);
*/