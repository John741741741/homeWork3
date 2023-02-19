// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


//   if (numb > 9999 && numb < 100000)
//         Console.WriteLine("true");
//     else
//         Console.WriteLine("Введите корректное число");

Console.WriteLine("Введите пятизначное число");
string x = Console.ReadLine();
int i = x.Length;

if (i == 5)
{
    if (x[0] == x[4] && x[1] == x[3])
    {
        Console.WriteLine($"число {x} является полиндромом");
    }
    else
    {
        System.Console.WriteLine($"число {x} не является полиндромом");
    }
}
else
{
    System.Console.WriteLine("Число {x} не пятизначное, введите корректное число");
}