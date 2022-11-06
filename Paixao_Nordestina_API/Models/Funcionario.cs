using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Paixao_Nordestina_API.Models
{
    [Table("funcionario")]
    public class Funcionario
    {
        [Key]
        public long id { get; set; }
        [Required(ErrorMessage = "Informe o nome")]
        [StringLength(255)]
        public string nome { get; set; }
        [Required(ErrorMessage = "Informe o e-mail")]
        [StringLength(100)]
        public string email { get; set; }
        [Required(ErrorMessage = "Informe CPF")]
        public string cpf { get; set; }
        [Required(ErrorMessage = "Informe o telefone")]
        [StringLength(25)]
        public string telefone { get; set; }
    }
}
