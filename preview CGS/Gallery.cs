﻿using System;
using System.Collections.Generic;


namespace preview_CGS
{
    class Gallery
    {
        //public Artist atribArtists;

        //public Curator atribCurators;

        //public ArtPiece atribPieces;

        List<Artist> listartists = new List<Artist>();
        List<Curator> listcurators = new List<Curator>();
        List<ArtPiece> listpieces = new List<ArtPiece>();

        public void AddArtist(string pFirstName, string pLastName, string pArtistID)
        {
            // art.SetArtistID(pArtistID);
            // art.SetFirstName(pFirstName);
            // art.SetLastName(pLastName);
            // this.atribArtists = art; caso nao fosse lista

            Artist art = new Artist(pFirstName, pLastName, pArtistID);

            listartists.Add(art);
        }

        public void AddCurator(string pFirstName, string pLastName, string pCuratorID, double pComm)
        {
            Curator cur = new Curator(pFirstName, pLastName, pCuratorID, pComm);

            cur.SetCuratorID(pCuratorID);
            cur.SetFirstName(pFirstName);
            cur.SetLastName(pLastName);
            cur.SetCommission(pComm);

            listcurators.Add(cur);
        }

        public void AddPiece(string pPieceID, string pTitle, string pYear, double pPrice, string pArtistID, string pCuratorID)
        {
            ArtPiece artpiece = new ArtPiece(pPieceID, pTitle, pYear, pPrice, pArtistID, pCuratorID);

            artpiece.SetPieceID(pPieceID);
            artpiece.SetTitle(pTitle);
            artpiece.SetYear(pYear);
            artpiece.SetPrice(pPrice);
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
            return true;
        }


    }
}
