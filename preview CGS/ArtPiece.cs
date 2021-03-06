﻿
namespace preview_CGS
{
    class ArtPiece
    {
        private string PieceID;

        private string Title;

        private string Year;

        private double Price = 0;

        private double Estimate = 0;

        private string ArtistId;

        private string CuratorId;

        private char Status = 'D';

        public ArtPiece(string pPieceID, string pTitle, string pYear, double pPrice, string pArtistID, string pCuratorID)
        {
            this.SetPieceID(pPieceID);
            this.SetTitle(pTitle);
            this.SetYear(pYear);
            this.SetPrice(pPrice);
            this.SetArtistID(pArtistID);
            this.SetCuratorID(pCuratorID);
        }
        public void SetPieceID(string pPieceID)
        {
            this.PieceID = pPieceID;
        }

        public string GetPieceID()
        {
            return this.PieceID;
        }

        public void SetTitle(string pTitle)
        {
            this.Title = pTitle;
        }

        public string GetTitle()
        {
            return this.Title;
        }

        public void SetYear(string pYear)
        {
            this.Year = pYear;
        }

        public string GetYear()
        {
            return this.Year;
        }

        public void SetPrice(double pPrice)
        {
            this.Price = pPrice;
        }

        public double GetPrice()
        {
            return this.Price;
        }

        public void SetArtistID(string pArtistId)
        {
            this.ArtistId = pArtistId;
        }

        public string GetArtistID()
        {
            return this.ArtistId;
        }

        public void SetCuratorID(string pCurator)
        {
            this.CuratorId = pCurator;
        }

        public string GetCuratorID()
        {
            return this.CuratorId;
        }

        public void ChangeStatus(char pStatus)
        {
            this.Status = pStatus;
        }

        public void PricePaid(double pPrice)
        {
            this.Price = pPrice;
        }

        public double CalculateComm(double pComm)
        {
            return pComm;
        }

        public override string ToString()
        {
            return PieceID + Title + Year + Price + Estimate + ArtistId + CuratorId + Status; 
        }
    }

}
