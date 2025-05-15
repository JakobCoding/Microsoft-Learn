/* Create mock command line tool That generates invoices */
using System;

    class Program
{
    static void Main()
    {   
        Console.WriteLine("Genertating invoices for customer \"Contoso Corp\"... \n");
        Console.WriteLine("Invoice: 1021\t\tComplete!");
        Console.WriteLine("Invoice: 1022\t\tComplete!");
        Console.WriteLine("\nOutput Directory:");
        Console.WriteLine(@"c:\invoices");

        // Kon'nichiwa World.
        Console.WriteLine("\n\u3053\u3093\u306B\u3061\u306F World!\n");

        // Concatonate Strings.
        string firstName = "Jake";
        string greeting = "Hello";
        Console.WriteLine(greeting + " " + firstName + "!\n");

        // string interpolation to combine string & Variable
        Console.WriteLine($"Hey {firstName}! welcome to C#!");

        //string interpolation with multiple variables and literal strings.
        int version = 11;
        string updateText = "Let's Update to Windows";
        Console.WriteLine($"{updateText} {version}!\n");

        //combine verbatim literals & string interpolation
        //verbatim literal allow the use of backslashes in strings and $ allows varables to concatenated with strings
        string firstProject = "First Project";
        Console.WriteLine($@"C:\Output\{firstProject}\Data" +"\n");

        //Challange
        //Code must produce the following output: Only two console statements are allowed.

        /* Output:

        View English output:
            c:\Exercise\ACME\data.txt

        Посмотреть русский вывод:
            c:\Exercise\ACME\ru-RU\data.txt

        */
        // My First Solution
        /*
        string projectName = "ACME";
        string englishOutput = "View English output:";
        string englishFilePath = @"c:\Exercise\"; 
        string dataTxt = @"\data.txt"; 
        string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434:";
        string russianExpression = @"\ru-RU";

        Console.WriteLine($"{englishOutput}\n\t{englishFilePath}{projectName}{dataTxt}\n");
        Console.WriteLine($"{russianMessage}\n\t{englishFilePath}{projectName}{russianExpression}{dataTxt}");
        */

        //My Cleaned up Solution
        string projectName = "ACME";
        string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

        string filePath = @"c:\Exercise\"; // Consolidate repeated parts
        string dataFile = @"\data.txt";
        string locale = @"\ru-RU";

        Console.WriteLine($"View English output:\n\t{filePath}{projectName}{dataFile}\n");
        Console.WriteLine($"{russianMessage}\n\t{filePath}{projectName}{locale}{dataFile}");

        //Microsoft Learn Solution - Even Cleaner! 
        string projectName = "ACME";
        string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
        Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

        string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
        string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
        Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");




    }
}







