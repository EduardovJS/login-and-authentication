using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginAuthentication.Models
{
    public class PasswordRecovery
    {
        [Key]
        public int PasswordRecoveryId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; } // Chave Estrangeira

        [EmailAddress(ErrorMessage = "E-mail inválido")]
        [StringLength(50, ErrorMessage = "O e-mail não pode exceder {1} caracteres")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string UserEmail { get; set; }

        [StringLength(4, ErrorMessage = "O e-mail não pode exceder {1} caracteres")]
        public string RecoveryCode { get; set; }
        public DateTime ExpirationCode { get; set; }

        [Required(ErrorMessage = "Informe sua senha")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "A senha deve ter entre 6 e 100 caracteres")]
        [Display(Name = "Nova Senha")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        public User User { get; set; } // Propriedade de Navegação
    }
}
