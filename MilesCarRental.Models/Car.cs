namespace MilesCarRental.Models
{
    public partial class Car
    {
        public Guid Id { get; set; }

        public string Brand { get; set; } = null!;

        public string Line { get; set; } = null!;

        public short Model { get; set; }

        public string Color { get; set; } = null!;

        public string Plate { get; set; } = null!;

        public Guid PickUpLocationId { get; set; }

        public Guid ReturnLocationId { get; set; }

        public bool Available { get; set; }

        public virtual Location PickUpLocation { get; set; } = null!;

        public virtual Location ReturnLocation { get; set; } = null!;
    }
}