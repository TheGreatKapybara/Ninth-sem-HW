Console.Clear();
System.Console.WriteLine("Выберите задачу:");
System.Console.WriteLine();
System.Console.WriteLine("1 - Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.");
System.Console.WriteLine();
System.Console.WriteLine("2 - Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
System.Console.WriteLine();
System.Console.WriteLine("3 - Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
System.Console.WriteLine();
int TaskIndex = int.Parse(Console.ReadLine());
System.Console.WriteLine();
switch (TaskIndex)
{
    case 1:
    void Task1()
    {
        System.Console.Write("Введите первое число - ");
            int m = int.Parse(Console.ReadLine());
            System.Console.Write("Введите второе число - ");
            int n = int.Parse(Console.ReadLine());
            System.Console.Write($"Все натуральные числа от {m} до {n} - ");
            
        void Natural(int m, int n)
        {
            int Result = new int();
            if(m < n)
            {
                Result = m;
                System.Console.Write(Result + " ");
                Natural(m+1,n);
            }
        }
        Natural(m,n);
    }
    Task1();
    break;

    case 2:
    void Task2()
    {
        System.Console.Write("Введите первое число - ");
        int m = int.Parse(Console.ReadLine());
        System.Console.Write("Введите второе число - ");
        int n = int.Parse(Console.ReadLine());
        System.Console.Write($"Сумма натуральных чисел в промежутке от {m} до {n} - ");
        for (int i = m+1; i <= n; i++)
        {
           m = i + m;
        }
        System.Console.WriteLine(m);
        

    }
    Task2();
    break;

    case 3:
    void Task3()
    {
        Console.WriteLine("Введите начальное число M:");
        int numberM = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите начальное число N:");
        int numberN = int.Parse(Console.ReadLine());


        int AckermannFunction (int numberM, int numberN)
        {
            if (numberM == 0) return numberN + 1;
            if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
            if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
            return AckermannFunction(numberM, numberN);
        }

        Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {AckermannFunction(numberM, numberN)}");
    }
    Task3();
    break;

    default:
    System.Console.WriteLine("Такой задачи нет.");
    break;
}