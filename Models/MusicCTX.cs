namespace annotations.Models
{
    using Microsoft.EntityFrameworkCore;
    public class MusicCTX:DbContext
    {
        public MusicCTX(DbContextOptions<MusicCTX> options):base(options)
        {
            
        }
    }
}