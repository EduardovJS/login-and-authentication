using System.ComponentModel.DataAnnotations;

namespace LoginAuthentication.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Informe seu nome de usuário")]
        [MinLength(8, ErrorMessage = "Nome deve ter no mínimo {1} caracteres")]
        [MaxLength(50, ErrorMessage = "Nome pode exceder {1} caracteres")]
        [RegularExpression(@"^[a-zA-Z0-9_]+$", ErrorMessage = "Nome de usuário não pode conter caracteres especiais ou espaços.")]
        [Display(Name = "Nome")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Informe sua senha")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "A senha deve ter entre 6 e 100 caracteres")]
        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [EmailAddress(ErrorMessage = "E-mail inválido")]
        [StringLength(50, ErrorMessage = "O e-mail não pode exceder {1} caracteres")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }
        public bool? IsEmailVerified { get; set; }
    }
}
