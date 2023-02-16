/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.Write('Введите первое число:');
int first = Convert.ToInt32(Console.Readline());

Console.Write('Введите второе число:');
int second = Convert.ToInt32(Console.Readline());

Console.Write('Введите третье число:');
int third = Convert.ToInt32(Console.Readline());


max = first
if (second > max) {
    max = second
}

if (third > max) {
    max = third
}

Console.Write(max)