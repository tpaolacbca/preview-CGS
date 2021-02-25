using System;
using System.Collections.Generic;


namespace preview_CGS
{
    class Gallery
    {
        public Artist atribArtists;

        public Curator atribCurators;

        public ArtPiece atribPieces;

        List<Artist> listartists = new List<Artist>();
        List<Curator> listcurators = new List<Curator>();
        List<ArtPiece> listpieces = new List<ArtPiece>();

        public void AddArtist(string pArtistID, string pFirstName, string pLastName)
        {
            Artist art = new Artist();

            art.SetArtistID(pArtistID);
            art.SetFirstName(pFirstName);
            art.SetLastName(pLastName);

            listartists.Add(art);
            this.atribArtists = art;

        }

        public void AddCurator(string pCuratorID, string pFirstName, string pLastName)
        {
            Curator cur = new Curator();

            cur.SetCuratorID(pCuratorID);
            cur.SetFirstName(pFirstName);
            cur.SetLastName(pLastName);

            listcurators.Add(cur);
            this.atribCurators = cur;

        }

        public void AddPiece(string pPieceID, string pTitle, string pYear, double pPrice, string pArtistID, string pCuratorID)
        {
            ArtPiece artpiece = new ArtPiece();

            artpiece.SetPieceID(pPieceID);
            artpiece.SetTitle(pTitle);
            artpiece.SetYear(pYear);
            artpiece.SetPrice(pPrice);
            artpiece.SetArtistID(pArtistID);
            artpiece.SetCuratorID(pCuratorID);

            listpieces.Add(artpiece);
            this.atribPieces = artpiece;
        }

        public void ListArtists()
        {
            foreach (Artist Artist in listartists)
            {
                Console.WriteLine(Artist.GetArtistID() + 
                                  Artist.GetFirstName() + 
                                  Artist.GetLastName());
            }
        }
       
       

        public void ListCurators()
        {
            foreach (Curator Curator in listcurators)
            {
                Console.WriteLine(Curator.GetCuratorID() + 
                                  Curator.GetFirstName() + 
                                  Curator.GetLastName());
            }
        }
        
        public void ListPieces()
        {
            foreach (ArtPiece ArtPiece in listpieces)
            {
                Console.WriteLine(ArtPiece.GetPieceID() +
                                  ArtPiece.GetTitle() +
                                  ArtPiece.GetYear() +
                                  ArtPiece.GetPrice() +
                                  ArtPiece.GetArtistID() +
                                  ArtPiece.GetCuratorID());

            }
        }

        public Boolean SellPiece (string pPieceID, double pPrice)
        {
            return true;
        }


    }
}
