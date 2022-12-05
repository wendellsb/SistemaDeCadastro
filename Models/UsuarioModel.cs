namespace SistemaDeCadastro.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public byte Idade { get; set; }
        public char Sexo { get; set; }
    }
}
