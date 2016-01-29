using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoR.DTO
{
    public class BookedItemDto
    {
        public int BookedItemId { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public int Quantity { get; set; }
        public int? ItemId { get; set; }

        public DateTime CreatedDateUtc { get; set; }

        public int? ClientId { get; set; }
    }
}
