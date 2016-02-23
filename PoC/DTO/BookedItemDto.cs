using System;

namespace PoR.DTO
{
    /// <summary>
    /// Booked Item Data transfer object.
    /// </summary>
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
