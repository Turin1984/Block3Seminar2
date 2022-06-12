// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear ();

Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);

if (number <= 99 )
{
    System.Console.WriteLine("Третьей цифр нет");
    Environment.Exit (0);
}
else
{
    System.Console.WriteLine("Третья цифра в чиcле равна: " + numberText[2]);
}
