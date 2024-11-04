namespace BackendConcesionario.Models
{
    public class CarImage
    {
        public int Id { get; set; }

        // Relationship with the Car model
        public int CarId { get; set; }
        public Car? Car { get; set; }

        public string ImageUrl { get; set; } = string.Empty;
        public bool IsPrimaryImage { get; set; }
    }
}
