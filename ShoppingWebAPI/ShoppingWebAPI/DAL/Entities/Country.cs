using System.ComponentModel.DataAnnotations;

namespace ShoppingWebAPI.DAL.Entities
{
    public class Country: Entity
    {
        [Display(Name = "País")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")] //NOT -- NULL
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres.")]
        public string Name { get; set; }







    }
}
