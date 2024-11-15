if (6 >= 3)
{
    Console.WriteLine("Hello, World!");
}

using System;

class Program
{
    static void Main()
    {
        // Hämta användarnamnet från användaren
        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        // Kontrollera om användarnamnet är "kalleanka"
        if (username == "kalleanka")
        {
            Console.WriteLine("Welcome!");
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        // Hämta användarnamn från användaren
        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        // Hämta lösenord från användaren
        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        // Kontrollera om både användarnamn och lösenord är korrekta
        if (username == "kalleanka" && password == "12345")
        {
            Console.WriteLine("Welcome!");
        }
        else
        {
            Console.WriteLine("Wrong username or password");
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        // While-loop som skriver ut "Hello, World" 32 gånger
        int i = 0;
        while (i < 32)
        {
            Console.WriteLine("Hello, World");
            i++; // Ökar i med 1 för varje iteration
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        // Det korrekta lösenordet
        string correctPassword = "12345";
        string userPassword;

        // While-loop som fortsätter tills användaren skriver rätt lösenord
        do
        {
            Console.Write("Enter password: ");
            userPassword = Console.ReadLine();
        } while (userPassword != correctPassword);

        // När rätt lösenord har skrivits
        Console.WriteLine("Password correct!");
    }
}

using System;

class Program
{
    static void Main()
    {
        // Loop som körs 5 gånger
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            // Försök att konvertera input till ett tal
            if (int.TryParse(input, out int number))
            {
                // Jämför om talet är högre än 5
                if (number > 5)
                {
                    Console.WriteLine("högre än 5!");
                }
            }
            else
            {
                // Om användaren inte skriver ett giltigt tal
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        string userInput;

        // Loopa så länge använder inte använder sig av heltal
        while (true)
        {
            Console.Write("Enter a number: ");
            userInput = Console.ReadLine();

            // Försök att konvertera input till ett heltal
            if (int.TryParse(userInput, out int number))
            {
                // Om konverteringen lyckas, skriv ut numret och avsluta loopen
                Console.WriteLine($"You entered a valid number: {number}");
                break;
            }
            else
            {
                // Om konverteringen misslyckas, ge användaren ett felmeddelande
                Console.WriteLine("That's not a valid number. Please try again.");
            }
        }
    }
}