namespace BackendConcesionario.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name_or_CompanyName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Dni { get; set; } = string.Empty;
        public string Phone_Number { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int Cuit_Cuil { get; set; }
    }
}
