using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
namespace annotations.Models
{
    [Table("Album")]
    public partial class Album
    {
        [Key]
        public int IdAlbum { get; set; }
        public int IdArtista { get; set; }

        [Required(ErrorMessage ="Escriba el nobmbre del album")]
        [MaxLength(100,ErrorMessage ="Exedio el maximo de 100 caracteres ")]
        [MinLength(2,ErrorMessage ="Escriba un maximo de 2 caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="Escriba la fecha de lanzamiento ")]
        [DataType(DataType.Date)]
        public DateTime FechaLanzamiento { get; set; }

        public virtual Artista Artista {get;set;}
    }
}