using System.ComponentModel.DataAnnotations;

namespace VicioNerd.Models
{
    internal class Usuario
    {
        [Key]
        public int Id { get; private set; } = 0;

        public string Nome { get; set; } = "";

        public string Email { get; set; } = "";

        public string Senha { get; set; } = "";

        public Usuario(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }
    }
}