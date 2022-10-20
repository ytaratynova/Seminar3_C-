//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();

Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

if (number < 100)
{
    Console.WriteLine("В данном числе нет третьей цифры");
}
else 
{
    while (number > 999)
    {
        number = number / 10;
    }
     Console.WriteLine($"Третья цифра в данном числе: {number % 10}");    
}