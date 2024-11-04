namespace BackendConcesionario.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
        public int CarId { get; set; }
        public int CarPrice { get; set; }
        public Car? Car { get; set; }
        public DateOnly SaleDate { get; set; }
        public string ClientId { get; set; } = string.Empty; 
        public Client? Client { get; set; } 
    }
}
