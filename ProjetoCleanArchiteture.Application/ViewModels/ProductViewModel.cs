using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCleanArchiteture.Application.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O Nome é requerido")]
        [MinLength(3)]
        [MaxLength(100)]
        [DisplayName("Nome")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "A Descrição é requerida")]
        [MinLength(5)]
        [MaxLength(200)]
        [DisplayName("Descrição")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "O Preço é requerido")]
        [Range(1, 99999.99)]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [DisplayName("Preço")]
        public decimal Price { get; set; }
    }
}
