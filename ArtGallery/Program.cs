using System;
using CGS;

namespace ArtGallery
{
    // Step 1 - item 4

    class Program
    {
        // Step 2 - item 1 - a
        static string fName, lName, artistId, curatorID, artPieceID, pieceTitle, pieceYear;
        static double pieceEstimate;
        //static int countVal=0;
        static Gallery gal;

        // Step 5 - item 2
        public static void Main(string[] args)
        {
            gal = new Gallery();

            do
            {
                MainMenu();
            } while (true);
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
            OptionSelected(option);
        }
        private static void OptionSelected(String pOption)
        {
            switch (pOption)
            {
                case "1":
                    NewCurator();
                    break;

                case "2":
                    //UpdateCurator();                    
                    break;
                case "3":
                    NewArtist();
                    break;

                case "4":
                    NewArtPiece();
                    break;

                case "5":
                    SellArtPiece();                    
                    break;

                case "6":
                    ListArtitsScreen();
                    break;

                case "7":
                    ListCuratorsScreen();
                    break;

                case "8":
                    ListArtPiecesScreen();
                    break;

                case "9":
                    Console.WriteLine("Bye");
                    Environment.Exit(0);
                    break;

                case "":
                    break;

                default:
                    Console.WriteLine("Error: Invalid option");
                    break;
            }
        }

        private static void SellArtPiece()
        {
            Console.WriteLine("======================================");
            Console.WriteLine("    Sell ArtPiece                     ");
            Console.WriteLine("(*) Press ';' to return to menu       ");
            Console.WriteLine("======================================");
            Console.WriteLine("");

            // Step 3 - item 2 / e
            Console.WriteLine("ArtPiece Id");
            var pId = Console.ReadLine();
            Console.WriteLine("Price: ");
            var pPrice = Convert.ToDouble(Console.ReadLine());

            gal.SellPiece(pId, pPrice);


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


            // Step 2 - item 1 - d
            gal.AddArtist(fName, lName, artistId);

            WaitReturn();


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
            

            // Step 3 - item 2 - b
            gal.AddCurator(fName, lName, curatorID);

            WaitReturn();

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
            pieceEstimate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Artist Id: ");
            artistId = Console.ReadLine();
            Console.WriteLine("Curator Id: ");
            curatorID = Console.ReadLine();

            // Step 4 - item 2 - a


            // Step 4 - item 3 / b
            gal.AddPiece(artPieceID, pieceTitle, pieceYear, pieceEstimate, artistId, curatorID);

            WaitReturn();
        }

        private static void ListArtitsScreen()
        {

            Console.WriteLine("===========================================");
            Console.WriteLine("    List Artist                            ");
            Console.WriteLine("(*) Press ';' to return to menu            ");
            Console.WriteLine("===========================================");
            Console.WriteLine("");


            //Step 2 - item 1 - e
            foreach (var item in gal.ListArtists())
            {
                Console.WriteLine(item.ToString());
            }

            WaitReturn();


        }


        private static void ListCuratorsScreen()
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("    List Curator                           ");
            Console.WriteLine("(*) Press ';' to return to menu            ");
            Console.WriteLine("===========================================");
            Console.WriteLine("");

            // Step 3 - item 2 - f
            foreach (var item in gal.ListCurators())
            {
                Console.WriteLine(item.ToString());
            }

            WaitReturn();


        }

        private static void ListArtPiecesScreen()
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("    List Art Pieces                        ");
            Console.WriteLine("(*) Press ';' to return to menu            ");
            Console.WriteLine("===========================================");
            Console.WriteLine("");
            foreach (var item in gal.ListPieces())
            {
                Console.WriteLine(item.ToString());
            }

            WaitReturn();

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
