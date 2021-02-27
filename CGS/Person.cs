
namespace CGS
{
    // Step 1 - item 1 / a
    public abstract class Person
    {
        private string FirstName;

        private string LastName;


        public void SetFirstName (string pFName)
        {
            this.FirstName = pFName;  
        }

        public string GetFirstName()
        {
            return this.FirstName;
        }

        public void SetLastName(string pLName)
        {
            this.LastName = pLName;
        }

        public string GetLastName()
        {
            return this.LastName;
        }

        // Step 1 - item 1 / b
        public override string ToString()
        {
            return FirstName + LastName;
        }


    }
}
