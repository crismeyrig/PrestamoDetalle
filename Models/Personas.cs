using System;
using PrestamoDetalle.Models.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace PrestamoDetalle.Models
{
    public class Personas
    {

        [Key]
        public int PersonaId { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public string Nombres { get; set; }

        [ValidacionCedula]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public DateTime FechaNacimiento { get; set; } = DateTime.Now;

        public double Balance { get; set; }

    }
}
