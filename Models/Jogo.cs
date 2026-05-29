using System.ComponentModel.DataAnnotations;

namespace VicioNerd.Models
{
    internal class Jogo
    {
        [Key]
        public int Id { get; private set; } = 0;
        public string Nome { get; set; } = "";
        public string Desenvolvedora { get; set; } = "";
        public DateTime DataLancamento { get; set; } = DateTime.MinValue;
        public string Categoria { get; set; } = "";

        public Jogo(string nome, string desenvolvedora, DateTime dataLancamento, string categoria)
        {
            Nome = nome;
            Desenvolvedora = desenvolvedora;
            DataLancamento = dataLancamento;
            Categoria = categoria;
        }
    }
}
