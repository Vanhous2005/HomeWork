// Console.WriteLine("Напишите число");
// string number = Console.ReadLine();
// int num = Convert.ToInt32(number);
// int sum = 0;
// int index = 0;

// while (num > 0) {
//     num /= 10;
//     index++;
// }

// for (int i = 0; i < index; i++) {
//     sum = sum + num % 10;
//     num = num / 10;
// }
// Console.WriteLine(sum);


Console.WriteLine("Напишите число");
string number = Console.ReadLine();
int num = Convert.ToInt32(number);
int sum = 0;

while (num != 0) {
    sum = sum + num % 10;
    num = num / 10;
}
Console.WriteLine(sum);