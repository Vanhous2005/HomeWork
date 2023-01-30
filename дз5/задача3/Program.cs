int [] CreatArray() {
    int [] array = new int [4];
    Random number = new Random();
    for (int i = 0; i < array.Length; i++) {
        array[i] = number.Next(0,30);
    }
    return array;
}
int [] a = CreatArray();
int min = 31;
int max = 0;

void PrintArray(int[] array) {
    for (int i = 0; i < array.Length; i++) {
        Console.Write($"{array[i]} ");
    }
}
PrintArray(a);

for (int i = 0; i < a.Length; i++) {
    if(min > a[i]) {
        min = a[i];
    }if (max < a[i]) {
        max = a[i];
    }
}
Console.WriteLine($"--> {max - min}");