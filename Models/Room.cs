namespace CalbayogBoardHouseLocator
{

    public class Room
    {
        public string Description { get; set; } = "";
        public int Rent { get; set; } = 0;
        public string Status { get; set; } = "";
        public Landlord Owner { get; set; } = new Landlord();
        public Address Location { get; set; } = new Address();
    }

}