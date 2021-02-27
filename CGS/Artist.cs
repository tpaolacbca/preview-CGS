

namespace CGS
{
    // Step 1 - item 2 / a
    public class Artist : Person
    {
        // Step 1 - item 2 / c
        private string ArtistID;

        // construtor padrao
        public Artist()
        {

        }
        // Step 1 - item 2 / b
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
        // Step 1 - item 2 / d
        public override string ToString()
        {
            return string.Format($"{GetFirstName()} { GetLastName()} - { GetArtistID()}");
        }
    }
}
