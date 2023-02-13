// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

int Promt(string msg)
{
    System.Console.Write(msg + "-> ");
    return int.Parse(Console.ReadLine());
}

void ShowNumbers(int start, int finish)
{
    if (start > finish)
    {
        return;
    }
    if (start % 2 != 0)
    {
        start++;
    }
    Console.Write(start + " ");
    ShowNumbers(start + 2, finish);

}

int number1 = Promt("Введите число M");
int number2 = Promt("Введите число N");

ShowNumbers(number1, number2);