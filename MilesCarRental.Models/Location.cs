namespace MilesCarRental.Models
{
    public partial class Location
    {
        public Guid Id { get; set; }

        public string Description { get; set; } = null!;

        public string Address { get; set; } = null!;

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }

        public virtual ICollection<Car> CarPickUpLocations { get; set; } = new List<Car>();

        public virtual ICollection<Car> CarReturnLocations { get; set; } = new List<Car>();
    }
}