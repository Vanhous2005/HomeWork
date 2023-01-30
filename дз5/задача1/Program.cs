int [] CreatArray() {
    int [] array = new int [4];
    Random number = new Random();
    for (int i = 0; i < array.Length; i++) {
        array[i] = number.Next(100,1000);
    }
    return array;
}
int [] a = CreatArray();
int count = 0;

void PrintArray(int[] array) {
    for (int i = 0; i < array.Length; i++) {
        Console.Write($"{array[i]} ");
    }
}
PrintArray(a);

for (int i = 0; i < a.Length; i++) {
    if(a[i] % 2 == 0) {
        count ++;
    }
}
Console.WriteLine($"--> {count}");