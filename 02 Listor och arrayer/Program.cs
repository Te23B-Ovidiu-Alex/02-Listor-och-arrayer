// {
    // Skapa en array med fem olika leksaker
//     string[] leksaker = { "Teddy björn", "Batman", "El Primo", "Lego set", "Leksaksbil" };

    // Skriv ut leksakerna
//     foreach (string leksak in leksaker)
//     {
//          Console.WriteLine(leksak);
//     }
// }



// {
    // Skapa en array med fem olika leksaker
//     string[] leksaker = { "Teddy björn", "Batman", "Lego set", "El Primo", "Leksaksbil" };

    // Använd en for-loop för att skriva ut varje leksak
//     for (int i = 0; i < leksaker.Length; i++)
//     {
//         Console.WriteLine(leksaker[i]);
//     }
// }



// {
    // Skapa en array med fem klasskamrater
//     string[] klasskamrater = { "Calin", "Aris", "Kevin", "David", "Debil" };

    // Skriv ut klasskamraterna
//     foreach (string klasskamrat in klasskamrater)
//     {
//         Console.WriteLine(klasskamrat);
//     }
// }



// {
    // Skapa en lista med fem heltalsvärden mellan 0 och 10
//     List<int> värden = new List<int> { 1, 2, 4, 7, 9 };

    // Skriv ut värdena
//     foreach (int värde in värden)
//     {
//         Console.WriteLine(värde);
//     }
// }



// {
    // Array med fem klasskamrater
//     string[] klasskamrater = { "Calin", "Aris", "Kevin", "David", "Debil" };

    // Array med fem leksaker
//     string[] leksaker = { "Teddy björn", "Batman", "Lego set", "El Primo", "Leksaksbil" };

    // Array med fem betyg mellan 0 och 10
//     int[] betyg = { 8, 5, 7, 10, 6 };

    // For-loop som skriver ut betygen
//     for (int i = 0; i < klasskamrater.Length; i++)
//     {
//         Console.WriteLine($"{klasskamrater[i]} ger {leksaker[i]} betyget {betyg[i]}");
//     }
// }



// {
    // Skapa en tom lista med namn "cities"
//     List<string> cities = new List<string>();

    // Skriv ut ett meddelande för att bekräfta att listan har skapats
//     Console.WriteLine("En tom lista med namnet 'cities' har skapats.");
// }



// {
//     // Skapa en tom lista med namn "cities"
//     List<string> cities = new List<string>();

//     while (true)
//     {
//         // Be användaren att skriva in en stad
//         Console.Write("Skriv in en stad (eller 'exit' för att avsluta): ");
//         string input = Console.ReadLine();

//         // Kontrollera om användaren skrev "exit"
//         if (input.ToLower() == "exit")
//         {
//             break; // Avbryt loopen
//         }

//         // Lägg till användarens inmatning till listan cities
//         cities.Add(input);
//     }

//     // Skriv ut alla städer som lagts till i listan
//     Console.WriteLine("Du har skrivit in följande städer:");
//     foreach (string city in cities)
//     {
//         Console.WriteLine(city);
//     }
// }



{
    // Skapa en tom lista med namn "cities"
    List<string> cities = new List<string>();

    while (true)
    {
        // Be användaren att skriva in en stad
        Console.Write("Skriv in en stad (eller 'exit' för att avsluta): ");
        string input = Console.ReadLine();

        // Kontrollera om användaren skrev "exit"
        if (input.ToLower() == "exit")
        {
            break; // Avbryt loopen
        }

        // Lägg till användarens inmatning till listan cities
        cities.Add(input);
    }

    // Skriv ut ett meddelande för att visa att inskrivningen är avslutad
    Console.WriteLine("Du har avslutat inskrivningen.");

    // Ny loop som skriver ut alla städer som lagts till i listan
    Console.WriteLine("Här är alla städer du har skrivit in:");
    foreach (string city in cities)
    {
        Console.WriteLine(city);
    }
}




Console.ReadLine();