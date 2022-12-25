Console.Clear();
Console.Write("Enter number: ");
string number = Console.ReadLine();

if (number[0] == number[4] && number[1] == number[3])
{
    Console.WriteLine($"Является палиндромом");
}   
else
{
    Console.WriteLine($"Не является палиндромом");
}

