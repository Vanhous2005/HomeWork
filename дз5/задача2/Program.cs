int [] CreatArray() {
    int [] array = new int [4];
    Random number = new Random();
    for (int i = 0; i < array.Length; i++) {
        array[i] = number.Next(0,20);
    }
    return array;
}
int [] a = CreatArray();
int sum = 0;

void PrintArray(int[] array) {
    for (int i = 0; i < array.Length; i++) {
        Console.Write($"{array[i]} ");
    }
}
PrintArray(a);

for (int i = 0; i < a.Length; i++) {
    if(i % 2 == 1) {
        sum = sum + a[i];
    }
}
Console.WriteLine($"--> {sum}");