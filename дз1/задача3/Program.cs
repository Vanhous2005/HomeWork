Console.WriteLine("напишите число");
string num = Console.ReadLine();
int a = Convert.ToInt32(num);

if (a % 2 == 1) {
    Console.WriteLine("Даное число нечётное");
}
if (a % 2 == 0) {
    Console.WriteLine("Даное число чётное");
}
