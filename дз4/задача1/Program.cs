Console.WriteLine("Введите число");

while(true) {
    Console.WriteLine("Для завершения программы введите -1 ");
    string numberStr = Console.ReadLine();
    int number = Convert.ToInt32(numberStr);

    if(number == -1) {
        break;
    }
  
    string numberStr2 = Console.ReadLine();
    int number2 = Convert.ToInt32(numberStr2);

    Console.WriteLine(Math.Pow(number,number2));
}

