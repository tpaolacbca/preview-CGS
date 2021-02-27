using System;

namespace preview_CGS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Curator curator = new Curator();
            // curator.SetCuratorID("a");
            // curator.SetFirstName("Joao");
            // curator.SetLastName("Silva");


            // Artist artist = new Artist("Leonardo", "da Vinci", "1");

            // ArtPiece artpiece = new ArtPiece();

           // artpiece.SetArtistID("1");
           // artpiece.SetTitle("MonaLisa");
            // artpiece.SetPieceID("12");

            Gallery gallery = new Gallery();

            gallery.AddArtist("Leonardo", "da Vinci", "1");

            gallery.AddPiece("12", "MonaLisa", "2021",0, "1", "a");

            //gallery.AddCurator("Joao", "da Silva", "a");

            foreach (var item in gallery.ListArtists())
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();





 
        }

        
    }
}
