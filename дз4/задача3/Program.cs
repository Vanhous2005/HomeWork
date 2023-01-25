int [] CreatArray() {
    int [] array = new int [8];
    Random number = new Random();
    for (int i = 0; i < array.Length; i++) {
        array[i] = number.Next(0,1000);
    }
    return array;
}
int [] a = CreatArray();

void PrintArray(int[] array) {
    for (int i = 0; i < array.Length; i++) {
        Console.Write($"{array[i]} ");
    }
}
PrintArray(a);
