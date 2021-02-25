using System;

namespace preview_CGS
{
    class Curator : Person
    {
        private string CuratorID;

        private double Comission = 0;

        public const double CommRate = 0.1;

       public void SetCuratorID (string pCurator)
        {
            this.CuratorID = pCurator; 
        }

        public string GetCuratorID()
        {
            return this.CuratorID;
        }

        public string GetID()
        {
            return CuratorID;
        }
        public void SetCommission(double pCommission)
        {
            this.Comission = pCommission;
        }

        public void SetComm(double pComm)
        {
            this.Comission = pComm;
        }

        public double GetCommission()
        {
            return this.Comission;
        }
        public override string ToString()
        {
            return GetFirstName() + GetLastName() + CuratorID + Comission;
        }

        public void OnChangeCommission(EventArgs e)
        {
            
        }

        public void ClearComm()
        {
            this.Comission = 0;
        }
    }
}
