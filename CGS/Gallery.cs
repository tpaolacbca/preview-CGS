using System;
using System.Collections.Generic;
using System.Linq;

namespace CGS
{
    public class Gallery
    {
        List<Artist> listartists = new List<Artist>();
        List<Curator> listcurators = new List<Curator>();
        List<ArtPiece> listpieces = new List<ArtPiece>();

        // Step 1 - item 3 / a - b
        public void AddArtist(string pFirstName, string pLastName, string pArtistID)
        {
            Artist art = new Artist(pFirstName, pLastName, pArtistID);

            listartists.Add(art);
        }

        // Step 3 - item 2 / a - b
        public void AddCurator(string pFirstName, string pLastName, string pCuratorID)
        {
            Curator cur = new Curator(pFirstName, pLastName, pCuratorID);

            cur.SetCuratorID(pCuratorID);
            cur.SetFirstName(pFirstName);
            cur.SetLastName(pLastName);

            // Step 3 - item 2 / c
            listcurators.Add(cur);
        }

        // Step 4 - item 2 / a, b , c
        public void AddPiece(string pPieceID, string pTitle, string pYear, string pArtistID, string pCuratorID)
        {
            ArtPiece artpiece = new ArtPiece(pPieceID, pTitle, pYear, pArtistID, pCuratorID);

            artpiece.SetPieceID(pPieceID);
            artpiece.SetTitle(pTitle);
            artpiece.SetYear(pYear);
            artpiece.SetPrice(0);
            artpiece.SetStatus('D');
            artpiece.SetArtistID(pArtistID);
            artpiece.SetCuratorID(pCuratorID);

            listpieces.Add(artpiece);       
        }

        public List<Artist> ListArtists()
        {
            return listartists;
        }
       

        public List<Curator> ListCurators()
        {
            return listcurators;
        }
        
        public List<ArtPiece> ListPieces()
        {
            return listpieces;
        }

        public Boolean SellPiece (string pPieceID, double pPrice)
        {
            var lista = this.listpieces.Where(a => a.GetPieceID()==pPieceID);

            ArtPiece artPiece = lista.FirstOrDefault();
            
            return artPiece.GetStatus() == 'D' ? true : false;
        }
    }
}
