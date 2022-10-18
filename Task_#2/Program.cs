/*Задача 40: Напишите программу, 
которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/
int GetNumberFronConsole(string message)
{
Console.WriteLine(message);
int number = int.Parse(Console.ReadLine() ??"");
return number;
}
int numFirst = GetNumberFronConsole("Введите первое число");
int numSecond = GetNumberFronConsole("Введите второе число");
int numThird = GetNumberFronConsole("Введите третье число");

if(numFirst < numSecond + numThird && numSecond < numFirst + numThird && numThird < numFirst + numSecond)
{
    Console.WriteLine($"Треугольник может существовать");
}
else 
    Console.WriteLine("Не треугольник");