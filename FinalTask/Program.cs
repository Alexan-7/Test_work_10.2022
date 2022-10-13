Console.Clear();

/* Хотел оформить начало через меню
Console.WriteLine("Для получения готового массива нажмите 1. Для ввода массива вручную нажмите 2");
но пока затрудняюсь это сделать в C# */

string[] array1 = { "Hello", "7", ":^)", "Moscow", "GeekBrains", "-3", "Yakutia", "1$Ы", "GB" };
string[] array2 = new string[array1.Length];

Console.WriteLine("Имеем массив строк: ");
foreach (var value in array1)
    Console.Write($"{value} ");

int size2 = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= 3)
    {
        array2[size2] = array1[i];
        size2++;
    }
}

Console.WriteLine("\nСтроки размера <= 3 символов: ");
foreach (var value in array2)
    Console.Write($"{value} ");

/*
Console.Write("Укажите количество элементов вашего массива строк: ");
int elOfArr = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Теперь вводите элементы массива и жмите Enter после каждого: ");

string[] array1 = new string[elOfArr];
string[] array2 = new string[array1.Length];
for (int i = 0; i < array1.Length; i++)
   array1[i] = Console.ReadLine()!;

Console.WriteLine($"Итак, имеем массив строк: [{string.Join(", ", array1)}]");

int size2 = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= 3)
    {
        array2[size2] = array1[i];
        size2++;
    }
}

Console.WriteLine("\nСтроки размера <= 3 символов в нем: ");
foreach (var value in array2)
   Console.Write($"{value} ");
*/