using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;


namespace T2_DelCastillo_JoseMiguel.Models
{
    public class Distribuidor
    {
        [Key]

        [Required(ErrorMessage = "El ID es obligatorio.")]
        public int id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string nombreDistribuidor { get; set; }

        [Required(ErrorMessage = "La razon social es obligatoria.")]
        public string razonSocial { get; set; }

        [Required(ErrorMessage = "El telefono es obligatorio.")]
        public int telefono { get; set; }

        [Required(ErrorMessage = "El año es obligatorio.")]
        [Range(1900, 3000, ErrorMessage = "El año es entre 1900 y 3000")]
        public int anioInicioOperacion { get; set; }

        [Required(ErrorMessage = "El contacto es obligatorio.")]
        public string contacto { get; set; }
        


    }
}
