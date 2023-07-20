using SistemaDeTarefas.Enums;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeTarefas.Models
{
    public class TarefaModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [MinLength(2, ErrorMessage = "O nome deve ter no mínimo dois caracteres.")]
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public StatusTarefa Status { get; set; }
        public int? UsuarioId { get; set; }

        public virtual UsuarioModel? Usuario { get; set; }
    }
}
