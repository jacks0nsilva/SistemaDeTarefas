using System.ComponentModel.DataAnnotations;

namespace SistemaDeTarefas.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [MinLength(2, ErrorMessage = "O nome deve ter no mínimo dois caracteres.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O email é obrigatório.")]
        [MinLength(4, ErrorMessage = "O email deve ter no mínimo quatro caracteres.")]
        public string? Email { get; set; }
    }
}
