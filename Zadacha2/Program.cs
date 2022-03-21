
//Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

void NumOrNum(int J)
{
if (J > 99)
{
   while (J > 999)
   {
        J - J / 10;
    }
    J - J % 10;
    Console.WriteLine(J);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
}
int number = new Random().Next(10, 999);
Console.WriteLine("случайное число " + number + " max part is " + NumOrNum(number));

