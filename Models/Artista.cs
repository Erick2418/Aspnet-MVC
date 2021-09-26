using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel;

namespace annotations.Models
{
     [Table("Artista")]
    public partial class Artista
    {
        [Key]
        [Column("IdArtista")]
        public int IdArtista {get;set;}
        // [Column("nombre")]
        [Required(ErrorMessage ="Ingrese el nombre del Artista")]
         [MaxLength(100,ErrorMessage ="Exedio el maximo de 100 caracteres ")]
        [MinLength(2,ErrorMessage ="Escriba un maximo de 2 caracteres")]
        public string Nombre {get;set;}

        public int IdGenero {get; set;}

        // [Required(ErrorMessage ="Ingrese el nombre del Artista")]
        [MaxLength(100,ErrorMessage ="Exedio el maximo de 100 caracteres ")]
        [MinLength(2,ErrorMessage ="Escriba un maximo de 2 caracteres")]
        public string Nacionalidad {get; set;}
        [DisplayName("Altura")]
        public decimal Altura { get; set; }
        
        [Required(ErrorMessage ="Escriba la fecha de nacimiento ")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [MaxLength(200,ErrorMessage ="Exedio el maximo de 100 caracteres ")]
        [MinLength(2,ErrorMessage ="Escriba un maximo de 2 caracteres")]
        public string LugarNacimiento { get; set; }
        
         [DisplayName("Año de inicio")]
        public int AnioInicio  { get; set; }

        //creando la relacion es virutal por que no es un campo de una tabla este busca en la tabla el IdGenero
        [ForeignKey("IdGenero")]
        public virtual Genero Genero {get;set;}

    }
}