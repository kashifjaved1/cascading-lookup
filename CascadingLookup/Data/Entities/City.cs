namespace CascadingLookup.Data.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Area> Areas { get; set; }

        // Foreign key for 'Country'
        public int CountryId { get; set; }
        public Country Country { get; set; }

        // Read more about mapping attributes
        // https://learn.microsoft.com/en-us/ef/core/modeling/relationships/mapping-attributes
        // https://www.entityframeworktutorial.net/code-first/foreignkey-dataannotations-attribute-in-code-first.aspx
    }
}
