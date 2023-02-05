using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Artist : BaseClass
    {
        public Artist()
        {
            CreatedDate = DateTime.Now;
            Albums = new HashSet<Album>();
        }
        public string Name { get; set; }

        public int AlbumId { get; set; }

        //Navigation Props

        virtual public ICollection<Album> Albums { get; set; }
    }
}
