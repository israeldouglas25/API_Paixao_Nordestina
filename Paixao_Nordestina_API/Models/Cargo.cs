using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Paixao_Nordestina_API.Models
{
    [Table("cargo")]
    public class Cargo
    {
        [Key]  
        public long id { get; set; }
        [Required(ErrorMessage ="Informe o nome do cargo")]
        [StringLength(50)]
        public string nome { get; set; }
    }
}
