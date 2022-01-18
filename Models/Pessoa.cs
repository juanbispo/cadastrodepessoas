using System.ComponentModel.DataAnnotations;

namespace CadastroDePessoas.Models
{
    public class Pessoa
    {
        [Key]
        public int PessoaId { get; set; }   



        [Display(Name ="Nome")]
        [Required(ErrorMessage ="Informe o seu nome")]
        [StringLength(60)]
        public string Nome { get; set; }




        [Display(Name = "Sobrenome")]
        [Required(ErrorMessage ="Informe o seu sobrenome")]
        [StringLength(60)]
        public string Sobrenome { get; set; }




        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage ="Informe a sua data de nascimento")]
        [StringLength(10)]
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        [RegularExpression(@"^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((19|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((19|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((19|[2-9]\d)\d{2}))|          (29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$", ErrorMessage = "Data invalida")]
        public string DataNascimento { get; set; }



        [Display(Name = "Endereço")]
        public string Endereco1 { get; set; }




        [Display(Name = "Complemento")]
        public string Endereco2 { get; set; }


        [Required(ErrorMessage ="Informe sua cidade")]
        [StringLength(100)]
        public string Cidade { get; set; }


        [Required(ErrorMessage = "Informe o estado")]
        public string Estado { get; set; }




        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*\s+<(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})>$|^(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})$", ErrorMessage = "Formato do E-mail Inválido")]
        public string Email { get; set; }




        [Display(Name = "Número de Telefone com o DDD")]
        public string Telefone { get; set; }


        
    }
}
