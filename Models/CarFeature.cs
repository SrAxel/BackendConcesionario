namespace BackendConcesionario.Models
{
    public class CarFeature
    {
        public int Id { get; set; }
        // relacion con el modelo Cars
        public int CarId { get; set; }
        public Car? Car { get; set; }
        public string Feature { get; set; } = string.Empty;
    }
}
