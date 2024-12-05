using System.ComponentModel.DataAnnotations;

namespace LoginAuthentication.Models
{
    public class Authentication
    {
        [Key]
        public int AuthenticationId { get; set; }

        [EmailAddress(ErrorMessage = "E-mail inválido")]
        [StringLength(50, ErrorMessage = "O e-mail não pode exceder {1} caracteres")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [StringLength(4, ErrorMessage = "O e-mail não pode exceder {1} caracteres")]
        public string AuthenticationCode { get; set; }
        public DateTime ExpirationTime { get; set; }    
    }
}
