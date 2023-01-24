Console.WriteLine("What grade do you expect to get in ISM 4300 (Enter a NUMERIC value)");

try
{

    decimal grade = decimal.Parse(Console.ReadLine());

    string letter;

    if (grade >= 90)
    {
        letter = "A";
        Console.WriteLine("Your expected letter grade for ISM 4300 is: " + letter);
    }

    else if (grade >= 80 && grade < 90)
    {
        letter = "B";
        Console.WriteLine("Your expected letter grade for ISM 4300 is: " + letter);
    }

    else if (grade >= 70 && grade < 80)
    {
        letter = "C";
        Console.WriteLine("Your expected letter grade for ISM 4300 is: " + letter);
    }

    else if (grade >= 60 && grade < 70)
    {
        letter = "D";
        Console.WriteLine("Your expected letter grade for ISM 4300 is: " + letter);
    }

    else if (grade >= 50 && grade < 60)
    {
        letter = "F";
        Console.WriteLine("Your expected letter grade for ISM 4300 is: " + letter);
    }

}
catch
{
    Console.WriteLine("Enter a numeric value");
}

