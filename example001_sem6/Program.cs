// Демонстрация решения
// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
int[] arr = new int[] {1, 2, 3, 4};
Reverse(arr);
PrintArray(arr);

void Reverse(int[] array)
{
    for(int i = 0, j = array.Length -1; i < array.Length / 2; i++, j--)
    {
        int tmp = array[i];
        array[i] = array[j];
        array[j] = tmp;
    }
}

void PrintArray(int[] array)
{
    foreach(var item in array)
    {
        Console.WriteLine(item);
    }
}
