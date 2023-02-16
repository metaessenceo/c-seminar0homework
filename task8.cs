/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.Write('Введите число:');
int n = Convert.ToInt32(Console.Readline());


if (n >= 2) {
    Console.Write(2);
}

i = 2
while (i <= n) {
    i = i + 2
    Console.Write(', ' + Convert.ToString(i));
}