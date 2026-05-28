namespace VicioNerd.Models
{
    internal class Usuario
    {
        private int id;
        private string nome;
        private string email;
        private string senha;

        public int Id { get; } = 0;

        public string Nome { get; set; } = "";

        public string Email { get; set; } = "";

        public string Senha { get; set; } = "";
    }
}
