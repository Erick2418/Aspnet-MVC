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

        public string Nombre { get; set; }
        
        public DateTime FechaLanzamiento { get; set; }

        public virtual Artista Artista {get;set;}
    }
}