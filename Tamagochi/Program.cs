Tamagochi tamagochi = new Tamagochi();

Console.WriteLine("TAMAGOCHI!");

Console.WriteLine("Enter name for your tamagochi:");
tamagochi.name = Console.ReadLine();

Console.WriteLine("Press enter to start");
Console.ReadLine();


while (tamagochi.IsAlive())
{
    tamagochi.PrintStats();

    Console.WriteLine("Options: 1. Feed, 2. Hi, 3. Teach, 4. Skip");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            tamagochi.Feed();
            break;
        case "2":
            tamagochi.Hi();
            break;
        case "3":
            Console.WriteLine("Enter a word to teach:");
            string word = Console.ReadLine();
            tamagochi.Teach(word);
            break;
        case "4":
            Console.WriteLine("Skipped Time");
            break;
        default:
            Console.WriteLine("Invalid choice, please pick 1, 2, 3 or 4.");
            break;
    }

    tamagochi.Tick();
    Console.ReadLine();
}

Console.WriteLine("Game over!");
Console.ReadLine();
