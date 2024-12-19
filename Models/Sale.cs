namespace BackendConcesionario.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
        public int CarId { get; set; }
        public int CarPrice { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public Car? Car { get; set; }
        public DateOnly SaleDate { get; set; }
        public string ClientId { get; set; } = string.Empty;
        public string Name_or_CompanyName { get; set; }
        public Client? Client { get; set; }
    }
}
