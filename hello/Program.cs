using static System.Console;
using World;

WriteLine(
    $"Press <Enter> only to exit; otherwise, enter a string and press <Enter>:{
		Environment.NewLine
	}"
);

Main(Call);

void Main(Action<string> cb)
{
    while (true)
    {
        Write($"Input: ");
        string? input = ReadLine();
        if (string.IsNullOrEmpty(input))
            break;
        cb(input);
        WriteLine();
    }
}

void Call(string input) =>
    WriteLine($"Begins with uppercase? {
		(input.StartsWithUpper() ? "Yes" : "No")
	}");
