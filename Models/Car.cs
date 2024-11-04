using System.Text.RegularExpressions;

namespace BackendConcesionario.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Year { get; set; }
        public string Status { get; set; } = string.Empty ;
        public int Stock { get; set; }
        public string Description { get; set; } = string.Empty;
    }
    //public enum VehicleStatus
    //{
    //    New,
    //    Used
    //}
}
