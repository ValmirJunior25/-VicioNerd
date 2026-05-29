using System.ComponentModel.DataAnnotations;

namespace VicioNerd.Models
{
    internal class Prateleira
    {
        [Key]
        public int Id { get; private set; } = 0;
        public int UsuarioId { get; set; } = 0;
        public int JogoId { get; set; } = 0;
        public string Status { get; set; } = "";
        public DateTime DataAdicionado { get; set; } = DateTime.MinValue;
        
        public Prateleira(int usuarioId, int jogoId, string status, DateTime dataAdicionado)
        {
            UsuarioId = usuarioId;
            JogoId = jogoId;
            Status = status;
            DataAdicionado = dataAdicionado;
        }
    }
}
