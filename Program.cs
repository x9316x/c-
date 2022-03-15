/*Console.WriteLine("Здравствуйте Денис, доброго времени суток!");

// Task 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе выводит перевёрнутое число.
Console.WriteLine("Приступаем ко второй практической работе!");
Console.WriteLine("Давайте для начала напишем программу, которая принимает на вход трёхзначное число и на выходе выводит перевёрнутое число");

Console.WriteLine("Введите трёхзначное число:");
int task10Variable1 = Convert.ToInt32(Console.ReadLine());

int[] task10Array = new int[3];

task10Array[2] = task10Variable1 / 100;

task10Array[1] = (task10Variable1 - task10Array[2] * 100) / 10;

task10Array[0] = task10Variable1 % 10;

int invertedNumber = task10Array[0] * 100 + task10Array[1] * 10 + task10Array[2];

Console.WriteLine("Получившееся перевёрнутое трёхзначное число:");
Console.WriteLine(invertedNumber);

// Task 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Отлично! Давайте теперь выводит третью цифру заданного числа, если она конечно существует!");

Console.WriteLine("Для этого давайте введём произвольное целое число:");
string? task13Variable1 = Console.ReadLine();

if(task13Variable1 is not null)
{
    if((task13Variable1.Length < 3))
    {
        Console.WriteLine("Упс, третьего числа не существует!");
    }
    else
    {
        Console.WriteLine(task13Variable1[2]);
    }
}

// Task 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Идём дальше! Введите цифру, обозначающую день недели:");
int task15Variable1 = Convert.ToInt32(Console.ReadLine());

if((task15Variable1 % 7 == 0) | ((task15Variable1 + 1) % 7 == 0))
{
    Console.WriteLine("Ура, это день выходной!");
}
else
{
    Console.WriteLine("Будний день, продолжаем работу.");
}

Console.WriteLine("Отличная работа! Приступим к третьей практической работе!");

// Task  19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Проверим, является ли пятизначное число палиндромом");

Console.WriteLine("Для этого введите пятичначное число:");
int task19Variable1 = Convert.ToInt32(Console.ReadLine());

if((task19Variable1 % 10 == task19Variable1 /10000) & ((task19Variable1 / 1000) % 10 == (task19Variable1 % 100) / 10))
{
    Console.WriteLine("Введённое число палиндром!");
}
else
{
    Console.WriteLine("Введённое число не является палиндромом!");
}

// Task  21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Далее найдём расстояние между двумя точками в трёхмерном пространстве");

int[] dotA = new int[3];

int[] dotB = new int[3];

int task21Index1 = 0;

int task21Index2 = 0;

Console.WriteLine("Введите первую точку:");

while(task21Index1 < 3)
{
    dotA[task21Index1] = Convert.ToInt32(Console.ReadLine());
    task21Index1++;
}

Console.WriteLine("Введите вторую точку:");

while(task21Index2 < 3)
{
    dotB[task21Index2] = Convert.ToInt32(Console.ReadLine());
    task21Index2++;
}

double distance = Math.Sqrt((dotB[0] - dotA[0]) * (dotB[0] - dotA[0]) + (dotB[1] - dotA[1]) * (dotB[1] - dotA[1]) + (dotB[2] - dotA[2]) * (dotB[2] - dotA[2]));

Console.WriteLine("Расстояние между точками в трёхмерном пространстве:");
Console.WriteLine(distance);

*/

/* Task  23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27.
5 -> 1, 8, 27, 64, 125
*/
Console.WriteLine("");

/*First practical work. (Task 2, 4, 6, 8)

// Task 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Ищем наибольшее из двух чисел.");
Console.WriteLine("Введите первое число:");
int task2Variable1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int task2Variable2 = Convert.ToInt32(Console.ReadLine());

if(task2Variable1 > task2Variable2)
{
   Console.WriteLine("Наибольшее из двух чисел " + task2Variable1 + " и " + task2Variable2 + " - это " + task2Variable1); 
}
else
{
    Console.WriteLine("Наибольшее из двух чисел " + task2Variable1 + " и " + task2Variable2 + " - это " + task2Variable2); 
}

// Task 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Идём дальше!Теперь найдём наибольшее из трёх чисел.");

Console.WriteLine("Введите первое число:");
int task4Variable1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int task4Variable2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int task4Variable3 = Convert.ToInt32(Console.ReadLine());

if(task4Variable1 > task4Variable2)
{
    if(task4Variable1 > task4Variable3)
    {
        Console.WriteLine("Наибольшее из трёх чисел " + task4Variable1 + ", " + task4Variable2 + " и " + task4Variable3 + " - это " + task4Variable1); 
    }
    else
    {
        Console.WriteLine("Наибольшее из трёх чисел " + task4Variable1 + ", " + task4Variable2 + " и " + task4Variable3 + " - это " + task4Variable3); 
    }
}
else
{
    if(task4Variable2 > task4Variable3)
    {
        Console.WriteLine("Наибольшее из трёх чисел " + task4Variable1 + ", " + task4Variable2 + " и " + task4Variable3 + " - это " + task4Variable2); 
    }
    else
    {
        Console.WriteLine("Наибольшее из трёх чисел " + task4Variable1 + ", " + task4Variable2 + " и " + task4Variable3 + " - это " + task4Variable3); 
    }
}

// Task 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Отлично! Идём дальше!");

Console.WriteLine("Определим, является ли число чётным:");

Console.WriteLine("Введите число:");
int task6Variable1 = Convert.ToInt32(Console.ReadLine());

if(task6Variable1 % 2 == 0)
{
    Console.WriteLine(task6Variable1 + " - чётное число.");
}
else
{
    Console.WriteLine(task6Variable1 + " - нечётное число.");
}

// Task 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Переходим к последнему заданию.");

Console.WriteLine("Введите некоторое число N:");
int task8Variable1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Покажем все чётные числа от 1 до " + task8Variable1);

int count = 2;

while(count < task8Variable1)
{
    Console.Write(count + " ");
    count = count + 2;
}

Console.WriteLine();

Console.Write("Спасибо за внимание!");
*/