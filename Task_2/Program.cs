// Задача 13. Напишите программу, которая выводит третью цифру заданого числа или сообщает, что третьей цифры нет.
// 645 - 5
// 78 - третьей цифры нет
// 32679 - 6

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99) {
    Console.WriteLine(number % 10);
} else if (number < 99 && number > 9) 
{
    Console.Write("третьей цифры нет");
} 
else 
{
    Console.Write("нет даже второй цифры");
}