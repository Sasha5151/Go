//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.Write("Введите целое число  :  ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)  //  % 2 == 0  Определение деления на 2 без остатка
{
Console.Write(number);
Console.Write(" - число четное  ");
}
else
{
Console.Write(number);
Console.Write(" - число нечетное  ");
}
