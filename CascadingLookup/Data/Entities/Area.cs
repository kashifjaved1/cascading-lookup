namespace CascadingLookup.Data.Entities
{
    public class Area
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Foreign key for 'City'
        public int CityId { get; set; }
        public City City { get; set; }
    }
}
