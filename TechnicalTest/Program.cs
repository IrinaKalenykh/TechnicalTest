
using TechnicalTest.Problems;

Console.WriteLine("Please, choose a task to run.");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Press 1 - Check for Balanced Brackets in an expression");
Console.WriteLine("Press 2 - Single Number");
Console.WriteLine("Press any key to close this window.");
Console.ForegroundColor = ConsoleColor.White;

switch (Console.ReadKey().Key)
{
    case ConsoleKey.D1:
        CheckBalancedBrackets();
        break;
    case ConsoleKey.D2:
        FindSingleNumber();
        break;
}

Console.ResetColor();
Console.ReadKey();


static void CheckBalancedBrackets()
{
    Console.WriteLine("");
    Console.WriteLine("Please, enter an expression with brackets:");

    var exp = Console.ReadLine();

    if (IsNotEmptyString(exp))
    {
        if (BracketsChecker.IsBalancedBrackets(exp!))
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Balanced");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Not Balanced");
        }
    }
    else
    {
        Console.WriteLine("There is no expression to examine.");
    }
}    

static void FindSingleNumber()
{ 
    Console.WriteLine("");
    Console.WriteLine("Please, enter an non-empty array of integers:");
    
    var nums = Array.ConvertAll(Console.ReadLine()?.TrimStart('[').TrimEnd(']').
        Split(',')!, c => int.Parse(c));
    var result = SingleNumberSearch.GetSingleNumberViaXor(nums);

    Console.WriteLine(result);
}

static bool IsNotEmptyString(string? exp)
{
    return exp != null && exp.Length > 0;
}