using System.ComponentModel.DataAnnotations;

namespace EmprestimosManga.Models
{
    public class EmprestimosModel
    {
        [Key]
        public int Id { get; set; }
        public string Receiver { get; set; }
        public string Provider { get; set; }
        public string Manga { get; set; }
        public DateTime LastUpdateDate { get; set; } = DateTime.Now;
    }
}
