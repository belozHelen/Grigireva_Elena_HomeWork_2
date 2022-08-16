// Задача 15. Напишите программу, которая проверяет на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 - да
// 7 - да
// 1 - нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 5 && number <=7) 
{
    Console.WriteLine("Да, это выходной");
} else 
{
    Console.WriteLine("Нет, это будний день");
}