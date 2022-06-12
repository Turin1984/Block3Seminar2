// Задача №4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear ();

System.Console.Write("Введите число : ");
string number = Console.ReadLine();
int numberDay = int.Parse(number);

if ((numberDay >= 8)||(numberDay <=0))
{
    System.Console.WriteLine("Ошибка, в неделе 7 дней");
    Environment.Exit (0);
}
if (numberDay <= 5)
{
    System.Console.WriteLine("НЕТ - это рабочий день недели");
}
else
{
    System.Console.WriteLine("ДА - это выходной день недели");
}