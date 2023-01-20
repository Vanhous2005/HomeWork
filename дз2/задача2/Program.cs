Console.WriteLine("Введите число");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

if (number < 100)
{
     Console.WriteLine("3-ей цифры нет");
}else
{
     Console.WriteLine(numberStr[2]); 
}
