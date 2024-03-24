using System;
internal class MKWiiCharVeicRando
{
    private static void Main(string[] args)
    {
        int currentCharacterID = 0;
        int currentVeichleID = 0;
        int numberOfPlayers = 0;
        const int MAX_PLAYERS = 11;
        const int MAX_VEICHLES = 25;
        var rng = new Random();

        do{
            Console.WriteLine("Insert the number of players: ");
            numberOfPlayers = int.Parse(Console.ReadLine()!);
            if (numberOfPlayers > MAX_PLAYERS || numberOfPlayers <= 0)
            {
                Console.WriteLine("You have inserted an impossible amount of players. ");
            }
        }
        while (numberOfPlayers > MAX_PLAYERS || numberOfPlayers <= 0);

        for (int i = 0; i < numberOfPlayers; i++)
        {
            currentCharacterID = rng.Next(0, MAX_VEICHLES);
            currentVeichleID = rng.Next(0, MAX_PLAYERS);
            var sb = new System.Text.StringBuilder();
            int j = i+1; 
            sb.Append("Player no." + j + ":\nCharacter: ");
                switch (currentCharacterID){
                    case 0:
                        sb.Append("Baby Mario\nVeichle: ");
                        break;
                    case 1:
                        sb.Append("Baby Luigi\nVeichle: ");
                        break;
                    case 2:
                        sb.Append("Baby Peach\nVeichle: ");
                        break;
                    case 3:
                        sb.Append("Baby Daisy\nVeichle: ");
                        break;
                    case 4:
                        sb.Append("Toad\nVeichle: ");
                        break;
                    case 5:
                        sb.Append("Toadette\nVeichle: ");
                        break;
                    case 6:
                        sb.Append("Koopa Troopa\nVeichle: ");
                        break;
                    case 7:
                        sb.Append("Dry Bones\nVeichle: ");
                        break;
                    //lightweights range from ID 0 to ID 7
                    case 8:
                        sb.Append("Mario\nVeichle: ");
                        break;
                    case 9:
                        sb.Append("Luigi\nVeichle: ");
                        break;
                    case 10:
                        sb.Append("Daisy\nVeichle: ");
                        break;
                    case 11:
                        sb.Append("Peach\nVeichle: ");
                        break;
                    case 12:
                        sb.Append("Yoshi\nVeichle: ");
                        break;
                    case 13:
                        sb.Append("Birdo\nVeichle: ");
                        break;
                    case 14:
                        sb.Append("Diddy Kong\nVeichle: ");
                        break;
                    case 15:
                        sb.Append("Bowser Junior\nVeichle: ");
                        break;
                    //middleweights range from ID 8 to ID 15
                    //Mii Outfit A & B are special cases; they get their own ID.
                    //I usually have middleweight Miis, but not everyone does.
                    //This should be added as a feature, maybe don't ask the user every time but have a config file?
                    //Maybe if the program is actually used I might implement such a feature, but for now I'll assume
                    //That Miis are all middleweight. Feel free to open an issue if you care.
                    case 16:
                        sb.Append("Wario\nVeichle: ");
                        break;
                    case 17:
                        sb.Append("Waluigi\nVeichle: ");
                        break;
                    case 18:
                        sb.Append("Donkey Kong\nVeichle: ");
                        break;
                    case 19:
                        sb.Append("Bowser\nVeichle: ");
                        break;
                    case 20:
                        sb.Append("King Boo\nVeichle: ");
                        break;
                    case 21:
                        sb.Append("Rosalina\nVeichle: ");
                        break;
                    case 22:
                        sb.Append("Funky Kong\nVeichle: ");
                        break;
                    case 23:
                        sb.Append("Dry Bowser\nVeichle: ");
                        break;
                    case 24:
                        sb.Append("Mii Outfit A\nVeichle: ");
                        break;
                    case 25:
                        sb.Append("Mii Outfit B\nVeichle: ");
                        break;
                    default:
                        Console.WriteLine("Unrecognized option: "+currentCharacterID);
                        break;
                }
            if (currentCharacterID >= 0 && currentCharacterID <= 7)
            { //lightweight
                switch (currentVeichleID){
                    case 0:
                        sb.Append("Standard kart S\n");
                        break;
                    case 1:
                        sb.Append("Booster Seat\n");
                        break;
                    case 2:
                        sb.Append("Mini Beast\n");
                        break;
                    case 3:
                        sb.Append("Cheep Charger\n");
                        break;
                    case 4:
                        sb.Append("Tiny Titan\n");
                        break;
                    case 5:
                        sb.Append("Blue Falcon\n");
                        break;
                    case 6:
                        sb.Append("Standard bike S\n");
                        break;
                    case 7:
                        sb.Append("Bullet Bike\n");
                        break;
                    case 8:
                        sb.Append("Bit Bike\n");
                        break;
                    case 9:
                        sb.Append("Quacker\n");
                        break;
                    case 10:
                        sb.Append("Kamekruiser\n");
                        break;
                    case 11:
                        sb.Append("Jet Bubble\n");
                        break;
                    default:
                        Console.WriteLine("Unrecognized option: "+currentVeichleID);
                        break;                        
                }
            }
            else if ((currentCharacterID >= 8 && currentCharacterID <= 15) || currentCharacterID == 24 || currentCharacterID == 25)
            { //middleweight
                    switch (currentVeichleID){
                    case 0:
                        sb.Append("Standard kart M\n");
                        break;
                    case 1:
                        sb.Append("Classic Dragster");
                        break;
                    case 2:
                        sb.Append("Wild Wing\n");
                        break;
                    case 3:
                        sb.Append("Super blooper\n");
                        break;
                    case 4:
                        sb.Append("Daytripper\n");
                        break;
                    case 5:
                        sb.Append("B Dasher Mk 2\n");
                        break;
                    case 6:
                        sb.Append("Standard bike M\n");
                        break;
                    case 7:
                        sb.Append("Mach Bike\n");
                        break;
                    case 8:
                        sb.Append("Sugarscoot\n");
                        break;
                    case 9:
                        sb.Append("Zip Zip\n");
                        break;
                    case 10:
                        sb.Append("Sneakster\n");
                        break;
                    case 11:
                        sb.Append("Dolphin Dasher\n");
                        break;
                    default:
                        Console.WriteLine("Unrecognized option: "+currentVeichleID);
                        break;                        
                }
            }
            else if (currentCharacterID >= 16 && currentCharacterID <= 23)
            {  //heavyweight
                switch (currentVeichleID){
                    case 0:
                        sb.Append("Standard kart L\n");
                        break;
                    case 1:
                        sb.Append("Offroader\n");
                        break;
                    case 2:
                        sb.Append("Flame Flyer\n");
                        break;
                    case 3:
                        sb.Append("Piranha Prowler\n");
                        break;
                    case 4:
                        sb.Append("Jetsetter\n");
                        break;
                    case 5:
                        sb.Append("Honeycoupe\n");
                        break;
                    case 6:
                        sb.Append("Standard bike L\n");
                        break;
                    case 7:
                        sb.Append("Flame Runner\n");
                        break;
                    case 8:
                        sb.Append("Wario Bike\n");
                        break;
                    case 9:
                        sb.Append("Shooting Star\n");
                        break;
                    case 10:
                        sb.Append("Torpedo\n");
                        break;
                    case 11:
                        sb.Append("Phantom\n");
                        break;
                    default:
                        Console.WriteLine("Unrecognized option: "+currentVeichleID);
                        break;                        
                }
            }

            Console.WriteLine(sb.ToString());
        }
        Console.WriteLine("Press any key to exit the program.");
        Console.ReadKey();
    }
    
}