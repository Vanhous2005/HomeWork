Console.WriteLine("напишите первое число");
string number1 = Console.ReadLine();
int a = Convert.ToInt32(number1);

Console.WriteLine("напишите второе число");
string number2 = Console.ReadLine();
int b = Convert.ToInt32(number2);

if (a < b) {
    Console.WriteLine(b);
}
else
{
    Console.WriteLine(a);
}