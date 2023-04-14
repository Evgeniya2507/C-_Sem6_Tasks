// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] numbers = GetArray(ArrayString());
PrintArray(numbers);
NumbersMoreNull(numbers);


string ArrayString()
{
    System.Console.WriteLine("Введите числа через запятую и пробел:");
    return Console.ReadLine();
}

int[] GetArray(string ArrayAsString)
{
    string[] numbersAsString = ArrayAsString.Split(", ");

    int[] array = new int[numbersAsString.Length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(numbersAsString[i]);
    }
    return array;
}

void PrintArray(int[] numbers)
{
    System.Console.Write("[");
    for (int i = 0; i < numbers.Length-1; i++)
    {
        System.Console.Write(numbers[i] + "; ");
    }
    System.Console.WriteLine(numbers[numbers.Length-1] + "]");
}

void NumbersMoreNull(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            count++;
        }

    }
    System.Console.WriteLine($"Пользователь ввел {count} чисел > 0");
}