using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
namespace annotations.Models
{
     [Table("Artista")]
    public partial class Artista
    {
        [Key]
        [Column("IdArtista")]
        public int IdArtista {get;set;}
        // [Column("nombre")]
        public string Nombre {get;set;}
        public int IdGenero {get; set;}
        public string Nacionalidad {get; set;}
        public decimal Altura { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string LugarNacimiento { get; set; }
        public int AnioInicio  { get; set; }

        //creando la relacion es virutal por que no es un campo de una tabla este busca en la tabla el IdGenero
        [ForeignKey("IdGenero")]
        public virtual Genero Genero {get;set;}

    }
}