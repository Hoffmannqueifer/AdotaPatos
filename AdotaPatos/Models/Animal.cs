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

        [Display(Name = "Nome do Animal")]
        [Required(ErrorMessage = "* Campo Obrigatório")]
        public string NomeAnimal { get; set; }

        [Display(Name = "Tipo Animal")]
        [Required(ErrorMessage = " * Campo obrigatório!")]
        public string TipoAnimal { get; set; }

        [Display(Name = "Nome do Voluntarios")]
        [Required(ErrorMessage = " * Campo obrigatório!")]
        public string NomeVoluntario { get; set; }

        [Display(Name = "Lar Temporario")]
        [Required(ErrorMessage = " * Campo obrigatório!")]
        public string LarTemporario { get; set; }

        [Required(ErrorMessage = "* Campo Obrigatório")]
        [Display(Name = "Data de Resgate")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataResgate { get; set; }

        [Display(Name = "Sexo do Animal")]
        [Required(ErrorMessage = " * Campo obrigatório!")]
        public string Sexo { get; set; }

        [Display(Name = "Raça do Animal")]
        [Required(ErrorMessage = " * Campo obrigatório!")]
        public string Raca { get; set; }

        [Display(Name = "Idade do Animal")]
        [Required(ErrorMessage = " * Campo obrigatório!")]
        public int Idade { get; set; }

        [Display(Name = "Tipo de Castração")]
        [Required(ErrorMessage = " * Campo obrigatório!")]
        public string TipoCastrado { get; set; }

        public string ImagemAntes { get; set; }

        public string ImagemDepois { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
    }
}