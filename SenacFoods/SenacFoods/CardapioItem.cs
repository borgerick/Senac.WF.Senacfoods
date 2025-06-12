using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenacFoods
{
    public class CardapioItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public bool PossuiPreparo { get; set; }
    }
}
