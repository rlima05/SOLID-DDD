using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataEntryPOC.MVC.ViewModels
{
    public class PaisViewModel
    {
        [Key]
        public int PaisId { get; set; }

        [Required(ErrorMessage = "Sigla Obrigatória.")]
        [MinLength(2, ErrorMessage = "Deve conter no minimo 2 caracteres.")]
        [MaxLength(2, ErrorMessage = "Deve conter no máximo 2 caracteres.")]
        public string Sigla { get; set; }

        [Required(ErrorMessage = "Sigla Obrigatória.")]
        [MinLength(3, ErrorMessage = "Deve conter no minimo 3 letras.")]
        [MaxLength(100, ErrorMessage = "Deve conter no máximo 100 letras.")]
        public string Nome { get; set; }
    }
}