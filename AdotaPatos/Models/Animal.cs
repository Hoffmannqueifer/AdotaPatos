using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdotaPatos.Models
{
    public class Animal
    {
        public long AnimalId { get; set; }
        //[Required]
        //[Display(Name = "Nome do Animal")]
        [Required(ErrorMessage = " * Campo obrigatório!")]
        public string NomeAnimal { get; set; }
        [Required(ErrorMessage = " * Campo obrigatório!")]
        public string TipoAnimal { get; set; }
        [Required(ErrorMessage = " * Campo obrigatório!")]
        public string NomeVoluntario { get; set; }
        [Required(ErrorMessage = " * Campo obrigatório!")]
        public string LarTemporario { get; set; }
        [Required(ErrorMessage = " * Campo obrigatório!")]
        public string DataResgate { get; set; }
        [Required(ErrorMessage = " * Campo obrigatório!")]
        public string Sexo { get; set; }
        
        public string Raca { get; set; }
        
        public int Idade { get; set; }

        public string TipoCastrado { get; set; }

        public string ImagemAntes { get; set; }

        public string ImagemDepois { get; set; }

        public string Descricao { get; set; }
    }
}