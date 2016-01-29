using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoR.DTO
{
    public class ItemDto
    {
        public int? ItemId { get; set; }

        //In a perfect world we'd use something that wasn't a guid or Auto increment id and instead
        //  We'd have a generated Id.  Something to the effect of Category + Name.

        public string Name { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }

        //public DateTime CreatedDateUtc { get; set; }
    }
}
