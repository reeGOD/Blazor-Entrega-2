using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BlazorCadastro.Shared
{
    public class Cadastro
    {
        [Required]
        public int Title { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Lastname { get; set; }
        
        [Required]
        public DateTime DataNasc { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "Mínimo de 8 caracteres")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Senha tem que ta igual a outra")]
        public string ConfPassword { get; set; }

        [Required]
        [Range(typeof(bool), "true", "true", ErrorMessage = "Aceitar os termos é obrigatório")]
        public bool confirmacao { get; set; }

    }
}