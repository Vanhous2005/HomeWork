Console.WriteLine("Введите натуральное число больше 1:");
int number = int.Parse(Console.ReadLine());

void NumberCounter (int number)
{
    if (number < 0) Console.Write($"{number} не натуральное число");
    if (number == 0) return;
    Console.Write("{0,4}", number);
    NumberCounter (number - 1);
}

NumberCounter(number);
