
namespace CGS
{
    public class ArtPiece
    {
        private string PieceID;

        private string Title;

        private string Year;

        private double Price;

        private double Estimate = 0;

        private string ArtistId;

        private string CuratorId;

        private char Status;

        // Step 4 - item 1 / a
        public ArtPiece(string pPieceID, string pTitle, string pYear, string pArtistID, string pCuratorID)
        {
            this.SetPieceID(pPieceID);
            this.SetTitle(pTitle);
            this.SetYear(pYear);
            this.SetPrice(0);
            this.SetStatus('D');
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

        public void SetStatus(char pStatus)
        {
            this.Status = pStatus;
        }

        public char GetStatus()
        {
            return this.Status;
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

        // Step 4 - item 1 / c
        public void ChangeStatus()
        {
            this.Status = 'S';
        }

        // Step 4 - item 1 / d
        public void PricePaid(double pPrice)
        {
            this.Price = pPrice;
        }

        // Step 4 - item 1 / e
        public double CalculateComm(double pPrice)
        {
            double lucro = pPrice - Estimate;
            double cal;
            if (lucro < 0 )
            {
                cal = 0;
            }
            else
            {
                cal = lucro * 0.25;
            }

            return cal;
        }

        // Step 4 - item 1 / b
        public override string ToString()
        {
            return string.Format($"{GetPieceID()} {GetTitle()} {GetYear()} {GetPrice()} {GetStatus()} Estimate {GetArtistID()} {GetCuratorID()}");
            
        }
    }

}
