Console.WriteLine("Напишите число");
string num = Console.ReadLine();
int a = Convert.ToInt32(num);

for (int i = 0; i < a; i++)
{
    if (i % 2 == 0) {
        Console.Write(i);
    }
}
