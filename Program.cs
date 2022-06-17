using System;

Console.WriteLine("Welcome to the calculate tax price app");

Console.WriteLine("Enter an integer number : ");

var value1 = Console.ReadLine();

if (string.IsNullOrEmpty(value1))
{
    Console.WriteLine("Hata");
    return;
}
if(int.TryParse(value1,out int x))
{

}
else
{
    Console.WriteLine("Hata");
    return;
}

Console.WriteLine("Enter a tax ratio");

var value2 = Console.ReadLine();
if (string.IsNullOrEmpty(value2))
{
    Console.WriteLine("Hata");
    return;
}
if(int.TryParse(value2,out int y))
{

}
else
{
    Console.WriteLine("Hata");
    return;
}

int number = Convert.ToInt32(value1);
int tax = Convert.ToInt32(value2);
double tax_price = (number * tax / 100) + number;
Console.WriteLine("Tax Price is : " + tax_price);
