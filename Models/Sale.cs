namespace BackendConcesionario.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CarPrice { get; set; }
        public Car? Car { get; set; }
        public DateOnly SaleDate { get; set; }
        public string ClientId { get; set; } = string.Empty;
        public Client? Client { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
    public enum PaymentMethod
    {
        Efectivo,
        Transferencia,
        CreditoPrendario,
        CreditoBancario,
        TarjetaDeCredito,
        Financiación
    }
}
