using System.ComponentModel.DataAnnotations;

namespace EmprestimosManga.Models
{
    public class EmprestimosModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Digite o nome do Recebedor")]
        public string Receiver { get; set; }

        [Required(ErrorMessage = "Digite o nome do Fornecedor")]
        public string Provider { get; set; }

        [Required(ErrorMessage = "Digite o nome do Manga")]
        public string Manga { get; set; }
        public DateTime LastUpdateDate { get; set; } = DateTime.UtcNow;


    }
}
