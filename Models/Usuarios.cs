using System;
using System.ComponentModel.DataAnnotations;
namespace annotations.Models
{
    public class Usuarios
    {
        
        [Required(ErrorMessage="Escriba su nombre.")]
        [MinLength(4,ErrorMessage = "Escriba almenos 5 caracteres.")]
        [MaxLength(50,ErrorMessage = "Escriba un maximo de 50 caracteres.")]
        public string Nombres { get; set; }


        [Required(ErrorMessage="Escriba su apellido.")]
        [MinLength(4,ErrorMessage = "Escriba almenos 5 caracteres.")]
        [MaxLength(50,ErrorMessage = "Escriba un maximo de 50 caracteres.")]
        public string Apellidos { get; set; }
        

        [Required(ErrorMessage="Escriba su Dui.")]
        [RegularExpression("^[0-9]{9}-[0-9]{1}",ErrorMessage ="Escriba un Dui Valido")]
        public string Dui { get; set; }
        

        [Required(ErrorMessage="Escriba su correo.")]
        [EmailAddress(ErrorMessage ="Escriba un correo valido.")]
        public string Correo { get; set; }


        public bool EstadoActivo { get; set; }


        [Required(ErrorMessage="Escriba su fecha de nacimiento.")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }
        

        [Required(ErrorMessage ="Escriba su edad")]
        [Range(10,120,ErrorMessage ="El registro solo para mayores de 18 años")]
        public int Edad { get; set; }

    }
}