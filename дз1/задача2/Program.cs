Console.WriteLine("Напишите три числа");
string numberStr1 = Console.ReadLine();
int a = Convert.ToInt32(numberStr1);

string numberStr2 = Console.ReadLine();
int b = Convert.ToInt32(numberStr2);

string numberStr3 = Console.ReadLine();
int c = Convert.ToInt32(numberStr3);

int max = a;

if (b > max) {
    max = b;
}
if (c > max) {
    max = c;
}

Console.WriteLine("Наибольшие число ->" + max);