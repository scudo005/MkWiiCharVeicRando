using System;
internal class MKWiiCharVeicRando
{
    private static void Main(string[] args)
    {
        int currentCharacterID = 0;
        int currentVeichleID = 0;
        var rng = new Random();
    InsertNoPlayers:
        Console.WriteLine("Inserire il numero di giocatori: ");
        int numberOfPlayers = int.Parse(Console.ReadLine()!);
        if (numberOfPlayers > 12 || numberOfPlayers <= 0)
        {
            Console.WriteLine("Hai inserito un numero impossibile di giocatori. ");
            goto InsertNoPlayers; //hate the game not the player
        }

        for (int i = 0; i < numberOfPlayers; i++)
        {
            currentCharacterID = rng.Next(0, 25);
            currentVeichleID = rng.Next(0, 11);
            var sb = new System.Text.StringBuilder();
            int j = i+1;
            string startText = "Risultato giocatore " + j + ": \nPersonaggio: ";
            sb.Append(startText);
                switch (currentCharacterID){
                    case 0:
                        sb.Append("Baby Mario\nVeicolo: ");
                        break;
                    case 1:
                        sb.Append("Baby Luigi\nVeicolo: ");
                        break;
                    case 2:
                        sb.Append("Baby Peach\nVeicolo: ");
                        break;
                    case 3:
                        sb.Append("Baby Daisy\nVeicolo: ");
                        break;
                    case 4:
                        sb.Append("Toad\nVeicolo: ");
                        break;
                    case 5:
                        sb.Append("Toadette\nVeicolo: ");
                        break;
                    case 6:
                        sb.Append("Koopa\nVeicolo: ");
                        break;
                    case 7:
                        sb.Append("Tartosso\nVeicolo: ");
                        break;
                    //lightweights range from ID 0 to ID 7
                    case 8:
                        sb.Append("Mario\nVeicolo: ");
                        break;
                    case 9:
                        sb.Append("Luigi\nVeicolo: ");
                        break;
                    case 10:
                        sb.Append("Daisy\nVeicolo: ");
                        break;
                    case 11:
                        sb.Append("Peach\nVeicolo: ");
                        break;
                    case 12:
                        sb.Append("Yoshi\nVeicolo: ");
                        break;
                    case 13:
                        sb.Append("Strutzi\nVeicolo: ");
                        break;
                    case 14:
                        sb.Append("Diddy Kong\nVeicolo: ");
                        break;
                    case 15:
                        sb.Append("Bowser Junior\nVeicolo: ");
                        break;
                    //middleweights range from ID 8 to ID 15
                    //Mii Outfit A & B are special cases; they get their own ID.
                    //I usually have middleweight Miis, but not everyone does.
                    //This should be added as a feature, maybe don't ask the user every time but have a config file?
                    //Maybe if the program is actually used I might implement such a feature, but for now I'll assume
                    //That Miis are all middleweight. Feel free to open an issue if you care.
                    case 16:
                        sb.Append("Wario\nVeicolo: ");
                        break;
                    case 17:
                        sb.Append("Waluigi\nVeicolo: ");
                        break;
                    case 18:
                        sb.Append("Donkey Kong\nVeicolo: ");
                        break;
                    case 19:
                        sb.Append("Bowser\nVeicolo: ");
                        break;
                    case 20:
                        sb.Append("Re Boo\nVeicolo: ");
                        break;
                    case 21:
                        sb.Append("Rosalinda\nVeicolo: ");
                        break;
                    case 22:
                        sb.Append("Funky Kong\nVeicolo: ");
                        break;
                    case 23:
                        sb.Append("Skelobowser\nVeicolo: ");
                        break;
                    case 24:
                        sb.Append("Mii Outfit A\nVeicolo: ");
                        break;
                    case 25:
                        sb.Append("Mii Outfit B\nVeicolo: ");
                        break;
                    default:
                        Console.WriteLine("Opzione non riconosciuta: "+currentCharacterID);
                        break;
                }
            if (currentCharacterID >= 0 && currentCharacterID <= 7)
            { //lightweight
                switch (currentVeichleID){
                    case 0:
                        sb.Append("Kart standard P\n");
                        break;
                    case 1:
                        sb.Append("Culla a reazione\n");
                        break;
                    case 2:
                        sb.Append("Pistoni bollenti\n");
                        break;
                    case 3:
                        sb.Append("Smack-mobile\n");
                        break;
                    case 4:
                        sb.Append("Minirally\n");
                        break;
                    case 5:
                        sb.Append("Blue Falcon\n");
                        break;
                    case 6:
                        sb.Append("Moto standard P\n");
                        break;
                    case 7:
                        sb.Append("Moto pallottolo\n");
                        break;
                    case 8:
                        sb.Append("Moto Bit\n");
                        break;
                    case 9:
                        sb.Append("Quaquaraqua\n");
                        break;
                    case 10:
                        sb.Append("Kamekruiser\n");
                        break;
                    case 11:
                        sb.Append("Bolla jet\n");
                        break;
                    default:
                        Console.WriteLine("Opzione non riconosciuta: "+currentVeichleID);
                        break;                        
                }
            }
            else if ((currentCharacterID > 7 && currentCharacterID <= 16) || currentCharacterID == 24 || currentCharacterID == 25)
            { //middleweight
                    switch (currentVeichleID){
                    case 0:
                        sb.Append("Kart standard M\n");
                        break;
                    case 1:
                        sb.Append("Nostalgia 1\n");
                        break;
                    case 2:
                        sb.Append("Ali di squalo\n");
                        break;
                    case 3:
                        sb.Append("Super calamako\n");
                        break;
                    case 4:
                        sb.Append("Bolide retrò\n");
                        break;
                    case 5:
                        sb.Append("Glory\n");
                        break;
                    case 6:
                        sb.Append("Moto standard M\n");
                        break;
                    case 7:
                        sb.Append("Moto Mach\n");
                        break;
                    case 8:
                        sb.Append("Scooter filante\n");
                        break;
                    case 9:
                        sb.Append("Jalapeno\n");
                        break;
                    case 10:
                        sb.Append("Nitrocicletta\n");
                        break;
                    case 11:
                        sb.Append("Delfinator\n");
                        break;
                    default:
                        Console.WriteLine("Opzione non riconosciuta: "+currentVeichleID);
                        break;                        
                }
            }
            else if (currentCharacterID > 15 && currentCharacterID <= 23)
            {  //heavyweight
                switch (currentVeichleID){
                    case 0:
                        sb.Append("Kart standard G\n");
                        break;
                    case 1:
                        sb.Append("Dune buggy\n");
                        break;
                    case 2:
                        sb.Append("Fiamma volante\n");
                        break;
                    case 3:
                        sb.Append("Piranha turbo\n");
                        break;
                    case 4:
                        sb.Append("Protoracer\n");
                        break;
                    case 5:
                        sb.Append("Flash GT\n");
                        break;
                    case 6:
                        sb.Append("Moto standard G\n");
                        break;
                    case 7:
                        sb.Append("Moto Bowser\n");
                        break;
                    case 8:
                        sb.Append("Moto di Wario\n");
                        break;
                    case 9:
                        sb.Append("Moto Stella\n");
                        break;
                    case 10:
                        sb.Append("Torpedo sprint\n");
                        break;
                    case 11:
                        sb.Append("Motorazzo\n");
                        break;
                    default:
                        Console.WriteLine("Opzione non riconosciuta: "+currentVeichleID);
                        break;                        
                }
            }

            Console.WriteLine(sb.ToString());
        }
        Console.WriteLine("Premere un tasto qualsiasi per uscire.");
        Console.ReadKey();
    }
    
}