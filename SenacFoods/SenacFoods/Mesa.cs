using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;
namespace SenacFoods
{
    public class Mesa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int NumeroMesa { get; set; }
        // / 0 - Livre, 1 - Ocupada, 2 - Reservada
        public int NumPessoasMesa { get; set; }
        public int SituacaoMesa { get; set; }
    }
}
