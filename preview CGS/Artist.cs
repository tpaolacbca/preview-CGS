

namespace preview_CGS
{
    class Artist : Person
    {
        private string ArtistID;

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
