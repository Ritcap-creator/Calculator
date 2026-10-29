
while (true)
{
    int otvet;
    Console.WriteLine("===CALCULATOR===");
    Console.WriteLine("num1");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("+ or - or / or *");
    string? pmdu = Console.ReadLine();
    Console.WriteLine("num2");
    int num2 = Convert.ToInt32(Console.ReadLine());
    if (pmdu == "+")
    {
        otvet = num1 + num2;
        Console.WriteLine(otvet);
    }
    else if (pmdu == "-")
    {
        otvet = num1 - num2;
        Console.WriteLine(otvet);
    }
    else if (pmdu == "*")
    {
        otvet = num1 * num2;
        Console.WriteLine(otvet);
    }
    else if (pmdu == "/")
    {
        otvet = num1 / num2;
        Console.WriteLine(otvet);
    }
}