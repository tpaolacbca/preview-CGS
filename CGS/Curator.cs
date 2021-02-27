using System;

namespace CGS
{
   // Step 3 - item 1 - a
    public class Curator : Person
    {
        private string CuratorID;

        private double Comission = 0;

        public const double CommRate = 0.1;


        // Step 3 - item 1 - b
        public Curator (string pFirstName, string pLastName, string pCuratorID)
        {
            this.SetFirstName(pFirstName);
            this.SetLastName(pLastName);
            this.SetCuratorID(pCuratorID);
            this.SetComm(0);
        }


        public void SetCuratorID (string pCurator)
        {
            this.CuratorID = pCurator; 
        }        

        public string GetID()
        {
            return CuratorID;
        }

        public void SetComm(double pComm)
        {
            this.Comission = pComm * CommRate;
        }

        public double GetCommission()
        {
            return this.Comission;
        }
        // Step 3 - item 1 - c
        public override string ToString()
        {
            return string.Format($"{GetFirstName()} {GetLastName()} - {GetID()} - R$ {GetCommission()}");           
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
