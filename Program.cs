Console.WriteLine("Задача 2");
Console.WriteLine("Сравнение двух чисел");
Console.WriteLine();
Console.WriteLine("Задача 4");
Console.WriteLine("Максимальное из трёх чисел");
Console.WriteLine();
Console.WriteLine("Задача 6");
Console.WriteLine("Проверка чётности числа");
Console.WriteLine();
Console.WriteLine("Задача 8");
Console.WriteLine("Чётные числа от 1 до N");
Console.WriteLine();
Console.Write("Введите номер задания: ");
int nubmer = Convert.ToInt32(Console.ReadLine());

switch (nubmer)
{
    case 2:
        Ex1();
        break;
    case 4:
        Ex2();
        break;
    case 6:
        Ex3();
        break;
    case 8:
        Ex4();
        break;
    default:
        Console.WriteLine("Неверный номер задания");
        break;
}

void Ex1()
{
    Console.Write("Введите число a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число b: ");
    int b = Convert.ToInt32(Console.ReadLine());

    if (a > b) Console.WriteLine("Число а больше b");
    else if (a < b) Console.WriteLine("Число а меньше b");
    else Console.WriteLine("Числа a и b равны");
}

void Ex2()
{
    Console.Write("Введите первое число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите третье число: ");
    int c = Convert.ToInt32(Console.ReadLine());

    int max = a;
    if (b > max) max = b;
    if (c > max) max = c;
    Console.WriteLine($"Максимальное число = {max}");
}

void Ex3()
{
    Console.Write("Введите число: ");
    int a = Convert.ToInt32(Console.ReadLine());

    if (a % 2 == 0) Console.WriteLine($"Число {a} является чётным");
    else Console.WriteLine($"Число {a} является нечётным");
}

void Ex4()
{
    Console.Write("Введите число N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int i = 2;
    if (N < 2) Console.Write($"Чётных чисел в диапазоне от 1 до {N} нет");
    else
        while (i <= N)
        {
            Console.Write(i + " ");
            i += 2;
        }
    Console.WriteLine();
}
