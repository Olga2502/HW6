// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

Console.Clear();
Console.WriteLine("Сколько цифр вы хотите ввести?");
Console.WriteLine("Введите последовательно числа");
int num = int.Parse(Console.ReadLine()!);

int[] GetArray(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine($"Введите число № {i + 1}");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

int PosNum(int[] array)
{
    int result = 0;
    foreach (var item in array)
    {
        if(item > 0)
        {
            result += 1;
        }
    }
    return result;
}

int[] newArray = GetArray(num);
Console.WriteLine(String.Join(", ", newArray));

int posNum = PosNum(newArray);
Console.WriteLine($"Больше 0 цифр  {posNum} .");