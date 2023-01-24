int GetNumber(string messege) {
    int resout = 0;

    while(true) {
        Console.WriteLine(messege);

        if(int.TryParse(Console.ReadLine(), out resout) && resout != 0) {
            break;
        }else {
            Console.WriteLine("Ввели не число или не корректное число. Поворите ввод!");
        }
    
    }
    return resout;
}

double getDistance(int ax, int ay, int bx, int by, int az, int bz) {
    double resout = Math.Sqrt(Math.Pow(ax-bx,2) + Math.Pow(ay-by,2) + Math.Pow(az-bz,2));
    return resout;
}

int ax = GetNumber("Введите x координату");
int ay = GetNumber("Введите y координату");
int az = GetNumber("Введите z координату");

int bx = GetNumber("Введите x координату");
int by = GetNumber("Введите y координату");
int bz = GetNumber("Введите z координату");

double distance = getDistance(ax, ay, bx, by, az, bz);

Console.WriteLine($"Находиться между ({ax},{ay},{az}) и ({bx},{by},{bz}) {distance:f2}");
