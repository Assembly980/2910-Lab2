namespace Twitty_Brandon_Lab1_2910
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
            string file = folder + Path.DirectorySeparatorChar + "videogames.csv";

            List<VideoGame> games = new List<VideoGame>();

            using (var reader = new StreamReader(file))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    string[] values = line.Split(',');

                    VideoGame x = new VideoGame()
                    {
                        Name = values[0],
                        Platform = values[1],
                        Year = values[2],
                        Genre = values[3],
                        Publisher = values[4],
                        NA_Sales = values[5],
                        EU_Sales = values[6],
                        JP_Sales = values[7],
                        Other_Sales = values[8],
                        Global_Sales = values[9]
                    };

                    games.Add(x);
                }   //End of While Loop
            }  //End of Using statement 

            games.Sort();
            double numGames = games.Count();

            //This is the implementation of a queue
            Console.WriteLine("What Platform do you want to look at?");
            Console.Write("\t");
            string platform = Console.ReadLine();

            Queue<VideoGame> platformGameQueue = new Queue<VideoGame>();

            var platformGames = games.Where(x => x.Platform == platform);
            foreach (var game in platformGames) platformGameQueue.Enqueue(game);
            Console.WriteLine("\n\nThe Games are sorted into a queue, which opperates on a First in, First out method");
            Console.WriteLine($"\nThe first game available in this queue on {platform} is:\n\n" + platformGameQueue.Peek().ToString() + "\n\n");
            //////////////////////////////////////////////////////////

            //This is my implementation of a stack
            Console.WriteLine("What Publisher do you want to look at?");
            Console.Write("\t");
            string publisher = Console.ReadLine();

            Stack<VideoGame> publisherGameStack = new Stack<VideoGame>();

            var publisherGames = games.Where(x => x.Publisher == publisher);
            foreach(var game in publisherGames) publisherGameStack.Push(game);
            Console.WriteLine("\n\nThese Games are sorted into a stack, which opperates on a Last in, First out method");
            Console.WriteLine($"\nThe first game available in this stack from the publisher {publisher} is:\n\n" + publisherGameStack.Peek().ToString() + "\n\n");
            //////////////////////////////////////////////////////////

            //This is my implementation of a dictionary
            Dictionary<string, int> platformGameDictionary = new Dictionary<string, int>();

            var gamesOn2600 = games.Where(x => x.Platform == "2600"); int num2600 = gamesOn2600.Count();
            var gamesOn3DO = games.Where(x => x.Platform == "3DO"); int num3DO = gamesOn3DO.Count();
            var gamesOn3DS = games.Where(x => x.Platform == "3DS"); int num3DS = gamesOn3DS.Count();
            var gamesOnDC = games.Where(x => x.Platform == "DC"); int numDC = gamesOnDC.Count();
            var gamesOnDS = games.Where(x => x.Platform == "DS"); int numDS = gamesOnDS.Count();
            var gamesOnGB = games.Where(x => x.Platform == "GB"); int numGB = gamesOnGB.Count();
            var gamesOnGBA = games.Where(x => x.Platform == "GBA"); int numGBA = gamesOnGBA.Count();
            var gamesOnGC = games.Where(x => x.Platform == "GC"); int numGC = gamesOnGC.Count();
            var gamesOnGEN = games.Where(x => x.Platform == "GEN"); int numGEN = gamesOnGEN.Count();
            var gamesOnGG = games.Where(x => x.Platform == "GG"); int numGG = gamesOnGG.Count();
            var gamesOnN64 = games.Where(x => x.Platform == "N64"); int numN64 = gamesOnN64.Count(); 
            var gamesOnNES = games.Where(x => x.Platform == "NES"); int numNES = gamesOnNES.Count();
            var gamesOnNG = games.Where(x => x.Platform == "NG"); int numNG = gamesOnNG.Count();
            var gamesOnPC = games.Where(x => x.Platform == "PC"); int numPC = gamesOnPC.Count();
            var gamesOnPCFX = games.Where(x => x.Platform == "PCFX"); int numPCFX = gamesOnPCFX.Count();
            var gamesOnPS = games.Where(x => x.Platform == "PS"); int numPS = gamesOnPS.Count();
            var gamesOnPS2 = games.Where(x => x.Platform == "PS2"); int numPS2 = gamesOnPS2.Count();
            var gamesOnPS3 = games.Where(x => x.Platform == "PS3"); int numPS3 = gamesOnPS3.Count();
            var gamesOnPS4 = games.Where(x => x.Platform == "PS4"); int numPS4 = gamesOnPS4.Count();
            var gamesOnPSP = games.Where(x => x.Platform == "PSP"); int numPSP = gamesOnPSP.Count();
            var gamesOnPSV = games.Where(x => x.Platform == "PSV"); int numPSV = gamesOnPSV.Count();
            var gamesOnSAT = games.Where(x => x.Platform == "SAT"); int numSAT = gamesOnSAT.Count();
            var gamesOnSCD = games.Where(x => x.Platform == "SCD"); int numSCD = gamesOnSCD.Count();
            var gamesOnSNES = games.Where(x => x.Platform == "SNES"); int numSNES = gamesOnSNES.Count();
            var gamesOnTG16 = games.Where(x => x.Platform == "TG16"); int numTG16 = gamesOnTG16.Count();
            var gamesOnWii = games.Where(x => x.Platform == "Wii"); int numWii = gamesOnWii.Count();
            var gamesOnWiiU = games.Where(x => x.Platform == "WiiU"); int numWiiU = gamesOnWiiU.Count();
            var gamesOnWS = games.Where(x => x.Platform == "WS"); int numWS = gamesOnWS.Count();
            var gamesOnX360 = games.Where(x => x.Platform == "X360"); int numX360 = gamesOnX360.Count();
            var gamesOnXB = games.Where(x => x.Platform == "XB"); int numXB = gamesOnXB.Count();
            var gamesOnXOne = games.Where(x => x.Platform == "XOne"); int numXOne = gamesOnXOne.Count();

            platformGameDictionary.Add("2600", num2600);
            platformGameDictionary.Add("3DO", num3DO);
            platformGameDictionary.Add("3DS", num3DS);
            platformGameDictionary.Add("DC", numDC);
            platformGameDictionary.Add("DS", numDS);
            platformGameDictionary.Add("GB", numGB);
            platformGameDictionary.Add("GBA", numGBA);
            platformGameDictionary.Add("GC", numGC);
            platformGameDictionary.Add("GEN", numGEN);
            platformGameDictionary.Add("GG", numGG);
            platformGameDictionary.Add("N64", numN64);
            platformGameDictionary.Add("NES", numNES);
            platformGameDictionary.Add("NG", numNG);
            platformGameDictionary.Add("PC", numPC);
            platformGameDictionary.Add("PCFX", numPCFX);
            platformGameDictionary.Add("PS", numPS);
            platformGameDictionary.Add("PS2", numPS2);
            platformGameDictionary.Add("PS3", numPS3);
            platformGameDictionary.Add("PS4", numPS4);
            platformGameDictionary.Add("PSP", numPSP);
            platformGameDictionary.Add("PSV", numPSV);
            platformGameDictionary.Add("SAT", numSAT);
            platformGameDictionary.Add("SCD", numSCD);
            platformGameDictionary.Add("SNES", numSNES);
            platformGameDictionary.Add("TG16", numTG16);
            platformGameDictionary.Add("Wii", numWii);
            platformGameDictionary.Add("WiiU", numWiiU);
            platformGameDictionary.Add("WS", numWS);
            platformGameDictionary.Add("X360", numX360);
            platformGameDictionary.Add("XB", numXB);
            platformGameDictionary.Add("XOne", numXOne);

            Console.WriteLine("What Platform do you want information on?");
            Console.Write("\t");
            string userPlatform = Console.ReadLine();

            var chosenPlatform = platformGameDictionary.Where(x => x.Key == userPlatform);
            foreach(var game in chosenPlatform) Console.WriteLine($"There are {game.Value} games that you can play on the {game.Key} platform!");
            //////////////////////////////////////////////////////////
        }

        static void PublisherData(List<VideoGame> games, string publisher)
        {
            var publisherGames = games.Where(x => x.Publisher == publisher);
            foreach (var pub in publisherGames) Console.WriteLine(pub.ToString());

            double numGames = games.Count();

            var ubisoftGames = games.Where(x => x.Publisher == publisher);
            double numPublisher = ubisoftGames.Count();
            double percentPublisher = Math.Round((numPublisher / numGames * 100), 2);
        }

        static void PlatformData(List<VideoGame> games, string platform)
        {
            var platformGames = games.Where(x => x.Platform == platform);
            foreach (var plat in platformGames) Console.WriteLine(plat.ToString());

            double numGames = games.Count();

            double numPlatform = platformGames.Count();
            double percentPlatform = Math.Round((numPlatform / numGames * 100), 2);
        }

        static void GenreData(List<VideoGame> games, string genre)
        {
            var genreGames = games.Where(x => x.Genre == genre);
            foreach (var gen in genreGames) Console.WriteLine(gen.ToString());

            double numGames = games.Count();

            var Creeper_____Aww_Man = games.Where(X => X.Genre == genre);
            double NumGen = Creeper_____Aww_Man.Count();
            double percentGen = Math.Round((NumGen * 100 / numGames), 2);
        }
    }
}