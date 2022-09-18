// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());

GetFibonacci(num);

void GetFibonacci(int num)
{   
    int firstNum = 0; 
    int secondNum = 1; 
    System.Console.WriteLine(firstNum);
    System.Console.WriteLine(secondNum);
    for(int i = 3; i <= num; i++) 
    {
        int tmp = secondNum; 
        System.Console.WriteLine(secondNum + firstNum);
        secondNum = firstNum + secondNum; 
        firstNum = tmp; 
    }
}
