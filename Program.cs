Console.WriteLine("Здравствуйте Денис, доброго времени суток!");

/*
First practical work. (Task 2, 4, 6, 8)

// Task 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Ищем наибольшее из двух чисел.");
Console.WriteLine("Введите первое число:");
int task2_variable1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int task2_variable2 = Convert.ToInt32(Console.ReadLine());

if(task2_variable1 > task2_variable2)
{
   Console.WriteLine("Наибольшее из двух чисел " + task2_variable1 + " и " + task2_variable2 + " - это " + task2_variable1); 
}
else
{
    Console.WriteLine("Наибольшее из двух чисел " + task2_variable1 + " и " + task2_variable2 + " - это " + task2_variable2); 
}

// Task 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Идём дальше!Теперь найдём наибольшее из трёх чисел.");

Console.WriteLine("Введите первое число:");
int task4_variable1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int task4_variable2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int task4_variable3 = Convert.ToInt32(Console.ReadLine());

if(task4_variable1 > task4_variable2)
{
    if(task4_variable1 > task4_variable3)
    {
        Console.WriteLine("Наибольшее из трёх чисел " + task4_variable1 + ", " + task4_variable2 + " и " + task4_variable3 + " - это " + task4_variable1); 
    }
    else
    {
        Console.WriteLine("Наибольшее из трёх чисел " + task4_variable1 + ", " + task4_variable2 + " и " + task4_variable3 + " - это " + task4_variable3); 
    }
}
else
{
    if(task4_variable2 > task4_variable3)
    {
        Console.WriteLine("Наибольшее из трёх чисел " + task4_variable1 + ", " + task4_variable2 + " и " + task4_variable3 + " - это " + task4_variable2); 
    }
    else
    {
        Console.WriteLine("Наибольшее из трёх чисел " + task4_variable1 + ", " + task4_variable2 + " и " + task4_variable3 + " - это " + task4_variable3); 
    }
}

// Task 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Отлично! Идём дальше!");

Console.WriteLine("Определим, является ли число чётным:");

Console.WriteLine("Введите число:");
int task6_variable1 = Convert.ToInt32(Console.ReadLine());

if(task6_variable1 % 2 == 0)
{
    Console.WriteLine(task6_variable1 + " - чётное число.");
}
else
{
    Console.WriteLine(task6_variable1 + " - нечётное число.");
}

// Task 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Переходим к последнему заданию.");

Console.WriteLine("Введите некоторое число N:");
int task8_variable1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Покажем все чётные числа от 1 до " + task8_variable1);

int count = 2;

while(count < task8_variable1)
{
    Console.Write(count + " ");
    count = count + 2;
}

Console.WriteLine();

Console.Write("Спасибо за внимание!");
*/