

namespace preview_CGS
{
    class Artist : Person
    {
        private string ArtistID;

        // construtor padrao
        public Artist()
        {

        }
        public Artist (string pFirstName, string pLastName, string pArtistID)
        {
            this.SetFirstName(pFirstName);
            this.SetLastName(pLastName);
            this.SetArtistID(pArtistID);
        }

        public void SetArtistID(string pArtistId)
        {
            this.ArtistID = pArtistId;
        }

        public string GetArtistID()
        {
            return this.ArtistID;
        }
        public override string ToString()
        {
            return GetFirstName() + GetLastName() + ArtistID;
        }
    }
}
