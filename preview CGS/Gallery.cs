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

        public void AddArtist(string pFirstName, string pLastName, string pArtistID)
        {
            Artist art = new Artist(pFirstName, pLastName, pArtistID);

            // art.SetArtistID(pArtistID);
            // art.SetFirstName(pFirstName);
            // art.SetLastName(pLastName);
            // this.atribArtists = art; senao fosse lista


            listartists.Add(art);
            

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

        public List<Artist> ListArtists()
        {
            return listartists;
        }
       

        public List<Curator> ListCurators()
        {
            return listcurators;
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
