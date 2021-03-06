using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace annotations.Models
{
    [Table("Genero")] // aqui le especificacmos apra que no busque en plural
    public partial class Genero //singulares para los nombres de las entidades, y los plurales es para buscar las entidades
    // ejemplo.. buscara en este caso es Generos que sera genero
    // tiene que ser parcail para que todas se compilen por una sola y no como separadas
    {
        [Key]
        [Column("IdGenero")]
        public int IdGenero {get;set;}
        [Required(ErrorMessage ="Escriba el nombre")]
        [MinLength(2,ErrorMessage ="Escriba almenos 2 caracteres")]
        [MaxLength(20,ErrorMessage ="Escribe un maximo de 20 caracteres")]
        // [Column("nombre")]
        public string Nombre {get;set;}

        // public virtual List<Artista> Artistas {get;set;}

    }
}