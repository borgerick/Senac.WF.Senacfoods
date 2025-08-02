using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenacFoods
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public string DDD { get; set; }
        public string Celular { get; set; }
        public string TipoUsuario { get; set; }
        public string ValidaSenha { get; set; }
        public string NomeUsuario { get; set; }

    }
}
