// Задача 30: 
// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int Prompt()
{
    Console.WriteLine("введите длину массива ");
    return Convert.ToInt32(Console.ReadLine());
}

// int size = Prompt();
int[] RandomArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i ++)
    {
        array[i] = new Random().Next(0, 2);
        // Console.WriteLine(array[i] + " "); - вариант вывода познаково в столбик
    }
    return array;
}

int[] newArray = RandomArray(Prompt());
Console.WriteLine(String.Join(" | ", newArray));// разобраться с программой в таком виде, а то не работает

