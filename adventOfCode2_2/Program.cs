using System.Collections.Generic;

string[] instructions = File.ReadAllLines(@"C:\Users\Axion\OneDrive\Desktop\AdventOfCode\instructions.txt");

int horizontal = 0;
int depth = 0;
int aim = 0;

foreach (string line in instructions)
{
    if (line.Contains("forward"))
    {
        int number = int.Parse(GetNumbers(line));
        horizontal += number;
        depth += number * aim;
    }
    if (line.Contains("down"))
    {
        aim += int.Parse(GetNumbers(line));
    }
    if (line.Contains("up"))
    {
        aim -= int.Parse(GetNumbers(line));
    }
}

int mult = horizontal * depth;

Console.WriteLine(mult);

static string GetNumbers(string input)
{
    return new string(input.Where(c => char.IsDigit(c)).ToArray());
}
