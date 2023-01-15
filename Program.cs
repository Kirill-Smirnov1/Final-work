
void Print(string[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

string[] Words(int size)
{
    string[] arr = new string[size];
    Console.WriteLine("Введите текстовые элементы массива:");

    for (int i = 0; i < size; i++)
        arr[i] = Console.ReadLine();
    return arr;
}
Console.WriteLine("Введите размер массива:");
string[] arr_1 = Words(int.Parse(Console.ReadLine()));
Print(arr_1);




