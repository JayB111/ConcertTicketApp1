namespace Application
{
    public class Concert
    {
        public string Name { get; set; }
        public string Venue { get; set; }
        public DateTime Date { get; set; }
        public Concert(string name, string venue, DateTime date)
        {
            Name = name;
            Venue = venue;
            Date = date;

        }
    }
}
