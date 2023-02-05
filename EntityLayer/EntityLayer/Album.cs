using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Album : BaseClass
    {
        public Album()
        {
            CreatedDate = DateTime.Now;
            Artists = new HashSet<Artist>();
        }
        public string AlbumName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public bool IsDiscounted { get; set; }
        public int DiscountAmount { get; set; }
        public bool IsOnSale { get; set; }

        public int ArtistId { get; set; }

        //Navigation Props

        public ICollection<Artist> Artists { get; set; }
    }
}
