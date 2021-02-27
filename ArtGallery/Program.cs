using System;
using CGS;

namespace ArtGallery
{
    // Step 1 - item 4
  
    class Program
    {
        // Step 2 - item 1 - a
        static string fName, lName, artistId, curatorID, artPieceID, pieceTitle, pieceYear;
        static double pieceValue;
        //static int countVal=0;


        // Step 5 - item 2
        public static void Main(string[] args)
            {
            //MainMenu();
            Gallery gal = new Gallery();

            gal.AddPiece("1", "Teste", "1900", "123", "9");
            gal.AddPiece("2", "Teste", "1900", "123", "9");
            gal.AddPiece("3", "Teste", "1900", "123", "9");
            gal.AddPiece("4", "Teste", "1900", "123", "9");

            var x = gal.SellPiece("9", 1000);

        }
            private static void MainMenu()
            {
                Console.WriteLine("=====================================");
                Console.WriteLine("1. Add a Curator                     ");
                Console.WriteLine("2. Update info kept a Curator        ");
                Console.WriteLine("3. Add Artists                       ");
                Console.WriteLine("4. Receive a Piece into Collection   ");
                Console.WriteLine("5. Sell a Piece                      ");
                Console.WriteLine("6. List Artists                      ");
                Console.WriteLine("7. List Curators                     ");
                Console.WriteLine("8. List Pieces                       ");
                Console.WriteLine("9. Quite the program                 ");
                Console.WriteLine("=====================================");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        NewCurator();
                        MainMenu();
                        break;

                    case "2":
                        //UpdateCurator();
                        MainMenu();
                        break;
                    case "3":
                        NewArtist();
                        MainMenu();
                        break;

                    case "4":
                        NewArtPiece();
                        MainMenu();
                        break;

                    case "5":
                        //SellArtPiece();
                        MainMenu();
                        break;

                    case "6":
                        //ListArtitsScreen();
                        MainMenu();
                        break;

                    case "7":
                        //ListCuratorsScreen();
                        MainMenu();
                        break;

                     case "8":
                        //ListArtPiecesScreen();
                        MainMenu();
                        break;

                     case "9":
                        Console.WriteLine("Bye");
                        Environment.Exit(0);
                        break;

                     case "":
                        break;

                     default:
                        Console.WriteLine("Error: Invalid option");
                        MainMenu();
                        break;
                }
            }

            private static void NewArtist()
            {
            // Step 2 - item 1 - c

                Console.WriteLine("======================================");
                Console.WriteLine("    Add a Artist                      ");
                Console.WriteLine("(*) Press ';' to return to menu       ");
                Console.WriteLine("======================================");
                Console.WriteLine("");

                Console.WriteLine("Artist First Name: ");
                fName = Console.ReadLine();
                Console.WriteLine("Artist Last Name: ");
                lName = Console.ReadLine();
                Console.WriteLine("Artist Id: ");
                artistId = Console.ReadLine();

                 // Step 2 - item 1 - b
                Gallery gal = new Gallery();

                // Step 2 - item 1 - d
                gal.AddArtist(fName, lName, artistId);

                WaitReturn();
                MainMenu();

            }

             private static void NewCurator()
             {
                Console.WriteLine("======================================");
                Console.WriteLine("    Add a Curator                     ");
                Console.WriteLine("(*) Press ';' to return to menu       ");
                Console.WriteLine("======================================");
                Console.WriteLine("");

                // Step 3 - item 2 / e
                Console.WriteLine("Curator First Name: ");
                fName = Console.ReadLine();
                Console.WriteLine("Curator Last Name: ");
                lName = Console.ReadLine();
                Console.WriteLine("Curator Id: ");
                curatorID = Console.ReadLine();

                // Step 3 - item 1 - a
                Gallery gal = new Gallery();

                // Step 3 - item 2 - b
                gal.AddCurator(fName, lName, curatorID);

                WaitReturn();
                MainMenu();
             }


            private static void NewArtPiece()
            {
                Console.WriteLine("===========================================");
                Console.WriteLine("    Receive a Piece into the Collection    ");
                Console.WriteLine("(*) Press ';' to return to menu            ");
                Console.WriteLine("===========================================");
                Console.WriteLine("");

                // Step 4 - item 3 / a
                Console.WriteLine("Art Piece Id: ");
                artPieceID = Console.ReadLine();
                Console.WriteLine("Title: ");
                pieceTitle = Console.ReadLine();
                Console.WriteLine("Year: ");
                pieceYear = Console.ReadLine();
                Console.WriteLine("Estimate Value: ");
                pieceValue = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Artist Id: ");
                artistId = Console.ReadLine();
                Console.WriteLine("Curator Id: ");
                curatorID = Console.ReadLine();

                // Step 4 - item 2 - a
                Gallery gal = new Gallery();

                // Step 4 - item 3 / b
                gal.AddPiece(artPieceID, pieceTitle, pieceYear, artistId, curatorID);

                WaitReturn();
                MainMenu();


            }

            private static void ListArtitsScreen(Gallery pGal)
            {

                Console.WriteLine("===========================================");
                Console.WriteLine("    List Artist                            ");
                Console.WriteLine("(*) Press ';' to return to menu            ");
                Console.WriteLine("===========================================");
                Console.WriteLine("");


                //Step 2 - item 1 - e
                foreach (var item in pGal.ListArtists())
                {
                    Console.WriteLine(item.ToString());
                }

                WaitReturn();
                MainMenu();

            }


            private static void ListCuratorsScreen(Gallery pGal)
            {
                Console.WriteLine("===========================================");
                Console.WriteLine("    List Curator                           ");
                Console.WriteLine("(*) Press ';' to return to menu            ");
                Console.WriteLine("===========================================");
                Console.WriteLine("");

                // Step 3 - item 2 - f
                foreach (var item in pGal.ListCurators())
                {
                    Console.WriteLine(item.ToString());
                }
                
                WaitReturn();
                MainMenu();

            }

            private static void ListArtPiecesScreen(Gallery pGal)
            {
                Console.WriteLine("===========================================");
                Console.WriteLine("    List Art Pieces                        ");
                Console.WriteLine("(*) Press ';' to return to menu            ");
                Console.WriteLine("===========================================");
                Console.WriteLine("");
                foreach (var item in pGal.ListPieces())
                {
                    Console.WriteLine(item.ToString());
                }

                WaitReturn();
                MainMenu();
            }

            private static void WaitReturn()
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Press any key to return");
                Console.ReadLine();
            }

    }
}
