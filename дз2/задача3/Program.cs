Console.WriteLine("Введите число");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

if (number > 7 || number < 1) {
    Console.WriteLine("Чумба таких нет");
} else{
    if (number == 6 || number == 7) {
        Console.WriteLine("Не паримся отдыхаем");
    } else {
        Console.WriteLine("Пора на работу");
    }
}
