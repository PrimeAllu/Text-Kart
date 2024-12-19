class Program
{
    static int playerPoints = 0;

    static void Main(string[] args)
    {
        Console.WriteLine("\r\n   ,-,--.                  _ __       ,----.                _,.----.    ,---.                    ,-,--.                       ,---.       _,.----.       ,----.  \r\n ,-.'-  _\\ .--.-. .-.-. .-`.' ,`.  ,-.--` , \\  .-.,.---.  .' .' -   \\ .--.'  \\      .-.,.---.  ,-.'-  _\\         .-.,.---.  .--.'  \\    .' .' -   \\   ,-.--` , \\ \r\n/==/_ ,_.'/==/ -|/=/  |/==/, -   \\|==|-  _.-` /==/  `   \\/==/  ,  ,-' \\==\\-/\\ \\    /==/  `   \\/==/_ ,_.'        /==/  `   \\ \\==\\-/\\ \\  /==/  ,  ,-'  |==|-  _.-` \r\n\\==\\  \\   |==| ,||=| -|==| _ .=. ||==|   `.-.|==|-, .=., |==|-   |  . /==/-|_\\ |  |==|-, .=., \\==\\  \\          |==|-, .=., |/==/-|_\\ | |==|-   |  .  |==|   `.-. \r\n \\==\\ -\\  |==|- | =/  |==| , '=',/==/_ ,    /|==|   '='  /==|_   `-' \\\\==\\,   - \\ |==|   '='  /\\==\\ -\\         |==|   '='  /\\==\\,   - \\|==|_   `-' \\/==/_ ,    / \r\n _\\==\\ ,\\ |==|,  \\/ - |==|-  '..'|==|    .-' |==|- ,   .'|==|   _  , |/==/ -   ,| |==|- ,   .' _\\==\\ ,\\        |==|- ,   .' /==/ -   ,||==|   _  , ||==|    .-'  \r\n/==/\\/ _ ||==|-   ,   /==|,  |   |==|_  ,`-._|==|_  . ,'.\\==\\.       /==/-  /\\ - \\|==|_  . ,'./==/\\/ _ |       |==|_  . ,'./==/-  /\\ - \\==\\.       /|==|_  ,`-._ \r\n\\==\\ - , //==/ , _  .'/==/ - |   /==/ ,     //==/  /\\ ,  )`-.`.___.-'\\==\\ _.\\=\\.-'/==/  /\\ ,  )==\\ - , /       /==/  /\\ ,  )==\\ _.\\=\\.-'`-.`.___.-' /==/ ,     / \r\n `--`---' `--`..---'  `--`---'   `--`-----`` `--`-`--`--'             `--`        `--`-`--`--' `--`---'        `--`-`--`--' `--`                    `--`-----``  \r\n");

        Character[] characters = new Character[]
        {
            new Character("Elon Musk", true),
            new Character("Cristiano Ronaldo"),
            new Character("Taylor Swift"),
            new Character("King von"),
            new Character("Lionel Messi"),
            new Character("Adolf Hitler"),
            new Character("Isaac Newton"),
            new Character("Albert Einstein"),
            new Character("Johnny Depp"),
            new Character("Hanna"),
            new Character("ULTIMATE ALLU (FINAL BOSS)")
        };


        Vehicle[] vehicles = new Vehicle[]
        {
            new Vehicle("Aston Martin Valkyrie", 200, 3, "Black", true),
            new Vehicle("Koenigsegg Jesko", 220, 4, "White"),
            new Vehicle("Pagani Huayra", 240, 4, "Blue"),
            new Vehicle("Rimac Nevera", 260, 5, "Silver"),
            new Vehicle("McLaren P1", 280, 5, "Orange"),
            new Vehicle("Ferrari SF90", 300, 6, "Red"),
            new Vehicle("Porsche 911 Turbo S", 320, 6, "Yellow"),
            new Vehicle("Bugatti Chiron", 340, 7, "Black"),
            new Vehicle("Lamborghini Aventador", 360, 7, "Green"),
            new Vehicle("Formula 1 Car", 380, 8, "Red"),
            new Vehicle("Audi RS7 MTM", 400, 9, "Matte Black"),
        };


        Track[] tracks = new Track[]
        {
            new Track("Monaco Grand Prix Circuit", 500, "Asphalt", new string[] { "Rainstorm", "Falling Branches" }, true),
            new Track("Nürburgring Nordschleife", 900, "Sand", new string[] { "Sandstorm", "Quick Sand" }),
            new Track("Silverstone Circuit", 1400, "Asphalt", new string[] { "Oil Slicks", "Flash Flood" }),
        };


        while (true)
        {
            try
            {

                Console.WriteLine("Choose your character!");
                for (int i = 0; i < characters.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {characters[i].Name} {(characters[i].IsUnlocked ? "" : "(LOCKED)")} ");
                }
                int characterChoice = int.Parse(Console.ReadLine()) - 1;
                if (!characters[characterChoice].IsUnlocked)
                {
                    throw new InvalidOperationException("Character is locked! Win races to unlock it!");
                }
                Character chosenCharacter = characters[characterChoice];
                Console.WriteLine($"You chose {chosenCharacter.Name}!");



                Vehicle chosenVehicle = null;
                while (chosenVehicle == null)
                {
                    Console.WriteLine("Would you like to:");
                    Console.WriteLine("1. Choose a pre-existing vehicle");
                    Console.WriteLine("2. Customize a new vehicle");
                    int vehicleChoiceType = int.Parse(Console.ReadLine());

                    if (vehicleChoiceType == 1)
                    {
                        try
                        {
                            Console.WriteLine("Choose your vehicle:");
                            for (int i = 0; i < vehicles.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}. {vehicles[i].Model} Speed: {vehicles[i].Speed} {(vehicles[i].IsUnlocked ? "" : "(LOCKED)")} ");
                            }
                            int vehicleChoice = int.Parse(Console.ReadLine()) - 1;
                            if (!vehicles[vehicleChoice].IsUnlocked)
                            {
                                throw new InvalidOperationException("Vehicle is locked! Win races to unlock it!");
                            }
                            chosenVehicle = vehicles[vehicleChoice];
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Error: {e.Message}");
                        }
                    }
                    else if (vehicleChoiceType == 2)
                    {
                        chosenVehicle = CustomizeVehicle();
                    }
                }
                Console.WriteLine($"You chose {chosenVehicle.Model}!");

                Track chosenTrack = null;
                while (chosenTrack == null)
                {
                    try
                    {
                        Console.WriteLine("Choose your track:");
                        for (int i = 0; i < tracks.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {tracks[i].Name} {(tracks[i].IsUnlocked ? "" : "(LOCKED)")} ");
                        }
                        int trackChoice = int.Parse(Console.ReadLine()) - 1;
                        if (!tracks[trackChoice].IsUnlocked)
                        {
                            throw new InvalidOperationException("Track is locked! Win races to unlock it!");
                        }
                        chosenTrack = tracks[trackChoice];
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Error: {e.Message}");
                    }
                }
                Console.WriteLine($"You chose the track: {chosenTrack.Name}!");


                Console.Clear();
                Console.WriteLine($"Starting race on {chosenTrack.Name} ({chosenTrack.Length} meters)\n");
                Thread.Sleep(2000);

                int numBots = 5;
                int[] botDistances = new int[numBots];
                string[] botNames = { "Your Mom", "Spongebob", "Patrick", "A Bitch", "Johnny sins" };
                int playerDistance = 0;
                Vehicle botVehicle = vehicles[0];

                bool raceOver = false;
                while (!raceOver)
                {
                    Console.Clear();
                    Console.WriteLine("Racing Progress:");
                    Console.WriteLine("================");


                    for (int i = 0; i < numBots; i++)
                    {
                        botDistances[i] += new Random().Next(botVehicle.Speed / 17, botVehicle.Speed / 12);
                        Console.WriteLine($"{botNames[i]}: {botDistances[i]} meters");
                        if (botDistances[i] >= chosenTrack.Length) raceOver = true;
                    }


                    playerDistance += new Random().Next(chosenVehicle.Speed / 15, chosenVehicle.Speed / 10);
                    Console.WriteLine($"\nPlayer (You): {playerDistance} meters");

                    if (playerDistance >= chosenTrack.Length) raceOver = true;

                    Thread.Sleep(500);
                }

                var results = botDistances
                     .Select((distance, index) => (Name: botNames[index], Distance: distance))
                     .ToList();


                results.Add(("Player", playerDistance));
                results = results.OrderByDescending(r => r.Distance).ToList();


                Console.Clear();
                Console.WriteLine("Race Results:");
                for (int i = 0; i < results.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {results[i].Name} - {results[i].Distance} meters");
                }

               
                int playerPlacement = results.FindIndex(r => r.Name == "Player") + 1;
                if (playerPlacement == 1)
                {
                    Console.WriteLine("\nYou finished in 1st place!");
                    UnlockRewards(characters, vehicles, tracks, 50, true, true, true);
                }
                else if (playerPlacement == 2)
                {
                    Console.WriteLine("\nYou finished in 2nd place!");
                    UnlockRewards(characters, vehicles, tracks, 25, true, true, false);
                }
                else if (playerPlacement == 3)
                {
                    Console.WriteLine("\nYou finished in 3rd place!");
                    UnlockRewards(characters, vehicles, tracks, 10, true, false, false);
                }
                else
                {
                    Console.WriteLine("\nYou did not place in the top 3. No rewards earned.");
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }


    static Vehicle CustomizeVehicle()
    {
        Console.WriteLine("\nCustomize your vehicle:");
        Console.WriteLine("Choose a name for your vehicle:");
        string name = Console.ReadLine();

        Console.WriteLine("Choose a color:");
        string color = Console.ReadLine();

        int baseSpeed = 200;
        int speed = baseSpeed;
        int durability = 3;

        while (true)
        {
            Console.WriteLine("\nCustomize your vehicle stats:");
            Console.WriteLine($"1. Speed: {speed} (Points: {playerPoints}) buy 10 km/h for 10 points only!!");
            Console.WriteLine($"2. Durability: {durability} (Points: {playerPoints}) buy 1 more durabilty for 5 points only!!");
            Console.WriteLine("3. Finish customization");

            int choice = int.Parse(Console.ReadLine());
            if (choice == 1 && playerPoints >= 10)
            {
                speed += 10;
                playerPoints -= 20;
            }
            else if (choice == 2 && playerPoints >= 5)
            {
                durability += 1;
                playerPoints -= 5;
            }
            else if (choice == 3)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice or insufficient points.");
            }
        }

        return new Vehicle(name, speed, durability, color, true);
    }


    static void UnlockRewards(Character[] characters, Vehicle[] vehicles, Track[] tracks, int points, bool unlockCharacter, bool unlockVehicle, bool unlockTrack)
    {
        Console.WriteLine($"\nCongratulations! You've earned {points} points!");
        playerPoints += points;

        if (unlockCharacter)
        {
            var lockedCharacters = characters.Where(c => !c.IsUnlocked).ToArray();
            if (lockedCharacters.Length > 0)
            {
                var randomCharacter = lockedCharacters[new Random().Next(lockedCharacters.Length)];
                randomCharacter.IsUnlocked = true;
                Console.WriteLine($"- Character unlocked: {randomCharacter.Name}");
            }
        }

        if (unlockVehicle)
        {
            var lockedVehicles = vehicles.Where(v => !v.IsUnlocked).ToArray();
            if (lockedVehicles.Length > 0)
            {
                var randomVehicle = lockedVehicles[new Random().Next(lockedVehicles.Length)];
                randomVehicle.IsUnlocked = true;
                Console.WriteLine($"- Vehicle unlocked: {randomVehicle.Model}");
            }
        }

        if (unlockTrack)
        {
            var lockedTracks = tracks.Where(t => !t.IsUnlocked).ToArray();
            if (lockedTracks.Length > 0)
            {
                var randomTrack = lockedTracks[new Random().Next(lockedTracks.Length)];
                randomTrack.IsUnlocked = true;
                Console.WriteLine($"- Track unlocked: {randomTrack.Name}");
            }
        }
    }
}
