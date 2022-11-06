using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Paixao_Nordestina_API.Models
{
    [Table("endereco")]
    public class Endereco
    {
        [Key]
        public long id { get; set; }
        [Required(ErrorMessage = "Informe o CEP")]
        [StringLength(10)]
        public string cep { get; set; }
        [Required(ErrorMessage = "Informe a rua ou avenida")]
        [StringLength(255)]
        public string logradouro { get; set; }
        [Required(ErrorMessage = "Informe o bairro")]
        [StringLength(100)]
        public string bairro { get; set; }
        [Required(ErrorMessage = "Informe a cidade")]
        [StringLength(100)]
        public string cidade { get; set; }
        [Required(ErrorMessage = "Informe o numero")]
        [StringLength(10)]
        public string numero { get; set; }
        [StringLength(50)]
        public string complemento { get; set; }
        [Required(ErrorMessage = "Informe o UF")]
        [StringLength(2)]
        public string uf { get; set; }
    }
}
