using System.ComponentModel.DataAnnotations;

namespace Segundo_App_BancoDados.Models
{
    public class Usuario
    {
        [Display(Name = "Código")]
        public int? idUsu { get; set; }

        [Display(Name = "Nome completo")]
        [Required(ErrorMessage ="Campo nome é obrigatório")]
        public string nomeUsu {  get; set; }

        [Display(Name = "Cargo")]
        [Required(ErrorMessage = "Campo cargo é obrigatório")]
        public string cargo { get; set; }

        [Display(Name = "Nascimento")]
        [Required(ErrorMessage = "Data nascimento é obrigatório")]
        [DataType(DataType.DateTime)]
        public DateTime dataNsc { get; set; }

    }
}
