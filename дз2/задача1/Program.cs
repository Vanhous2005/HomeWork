Console.WriteLine("Введите трёхзначное число");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

int number2 = number / 10 % 10;

Console.WriteLine(number2);
