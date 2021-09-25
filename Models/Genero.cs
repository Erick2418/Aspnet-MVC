using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace annotations.Models
{
    [Table("Genero")] // aqui le especificacmos apra que no busque en plural
    public partial class Genero //singulares para los nombres de las entidades, y los plurales es para buscar las entidades
    // ejemplo.. buscara en este caso es Generos que sera genero
    // tiene que ser parcail para que todas se compilen por una sola y no como separadas
    {
        [Key]
        public int IdGenero {get;set;}
        // [Column("nombre")]
        public string Nombre {get;set;}


        
    }
}