using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BlazorCadastro.Shared
{
    public class Cadastro
    {
        [Required (ErrorMessage = "Titulo Obrigatorio")]
        
        public int Title { get; set; }
        
        [Required (ErrorMessage = "Nome Obrigatorio")]

        public string Name { get; set; }
        
        [Required (ErrorMessage = "Sobrenome Obrigatorio")]

        public string Lastname { get; set; }
        
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]

        public DateTime DataNasc { get; set; }

        [DataType(DataType.EmailAddress)]

        [EmailAddress(ErrorMessage="Digite um e-mail valido")]
        public string Email { get; set; }

        [Required]

        [DataType(DataType.Password)]

        [StringLength(30,MinimumLength=8)]

        [Display(Name = "Password")]

        public string Password { get; set; }
        
        [Required]

        [DataType(DataType.Password)]

        [StringLength(30,MinimumLength=8)]

        [Display(Name = "Passord")] 

        public string ConfPassword { get; set; }

        public bool confirmacao { get; set; }
    }
}