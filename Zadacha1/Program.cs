// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
//число и на выходе показывает вторую цифру этого числа

int NumB(int num1)
{
    int num2 = (num1 / 10);
    int num3 = num2 % 10;
   
    return num3;
}

int number = new Random().Next(100, 1000);
Console.WriteLine("из случайного числа " + number + " вторая цифра " + NumB(number));
