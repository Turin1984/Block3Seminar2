// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear ();

int number = new Random().Next(100,999);
System.Console.WriteLine(number);

int number1 = number / 100;
int number2 = number % 100 / 10 ;


if (number1 == number2)
{
    System.Console.WriteLine("Цифра 1 в трехзначном числе равна равна цифре 2: " + number2);
    Environment.Exit (0);
}
if (number2 > number1)
{
    System.Console.WriteLine("Цифра 2 в трехзначном числе равна: " + number2);
}

else 
{
    System.Console.WriteLine("Цифра 2 в трехзначном числе равна: " + number2);
}
