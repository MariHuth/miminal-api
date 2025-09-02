namespace VeiculosAPI.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Papel { get; set; } // e.g., "Admin", "User"
    }
}