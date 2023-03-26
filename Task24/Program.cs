// Задача №24
// Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Prompt()
{
    Console.WriteLine("введите число ");
    return Convert.ToInt32(Console.ReadLine());
}

int SumNums(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++);
        sum += 1;
    return sum;
}
int a = Prompt();
Console.WriteLine(SumNums(a));// задачу надо проверить - не работает что-то, но не нашел, что

