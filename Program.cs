//Задача 1: Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите число :");
int a = int.Parse(Console.ReadLine());


if(a % 7 == 0 && a % 23 == 0){
    Console.WriteLine("Кратно :" + a);
}
else if (a == 0)
   Console.Write("Вы ввели 0 результат :" + a);
else 
Console.WriteLine("Не кратно :" + a);



// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
Console.WriteLine("Введите число :");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

if(x > 0 && y > 0){
    Console.WriteLine("1 Четверть");
}
else if(x < 0 && y > 0){
    Console.WriteLine("2 Четверть");
}
else if(x < 0 && y < 0){
    Console.WriteLine("3 Четверть");
}
else if(x > 0 && y < 0){
    Console.WriteLine("4 Четверть");
}
else if(x == 0 || y == 0){
    Console.WriteLine("Ошибка x или y равны 0");
} 
else if(x == 0 && y == 0){
    Console.WriteLine("Ошибка x и y равны 0");
}             
    

// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.
Console.WriteLine("Введите число :"); //Вариант решения №1
int n = int.Parse(Console.ReadLine());

if(n >= 10 && n < 100){
    int n_1 = n / 10;
    int n_2 = n % 10;

    if( n_1 > n_2){
    Console.WriteLine("Ответ :" + n_1);
    }
    else if( n_1 < n_2){
        Console.WriteLine("Ответ :" + n_2);
    }
    else if(n_1 == n_2){
         Console.WriteLine("числа равны");
    }
}
else{
     Console.WriteLine("Ошибка n<10 или n>100");
}

int numb - new Random().Next(10, 100); // Вариант решения № 2
Console.WriteLine(numb);

int numb_1 = numb / 10;
int numb_2 = numb % 10;

if(numb_1 > numb_2){
    Console.WriteLine(numb_1);
}
else if(numb_1 == numb_2){
    Console.WriteLine("числа равны");
}



// Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.
// Вариант №1
Console.Write("Введите натуральное число: ");
int element = Convert.ToInt32(Console.ReadLine ());

string n = "";
if (element > 0)
{
    while (element > 0)
    {
        n = element % 10 + "," + n;
        element = element / 10;
    }
    // set_of_num = set_of_num.Trim({ ',' });
    Console.Write(n.Trim(',') + "\n");
}
else
    Console.Write("Ошибка. Число не натуральное");

    
//Вариант №2
        Console.Write("Введите натуральное число: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Цифры числа " + n + ": ");

        string numberString = n.ToString();

        for (int i = 0; i < numberString.Length; i++)
        {
            Console.Write(numberString[i]);

            if (i < numberString.Length - 1)
            {
                Console.Write(", ");
            }
        }

        Console.ReadLine();
