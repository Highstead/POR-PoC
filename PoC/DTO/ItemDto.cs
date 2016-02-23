
namespace PoR.DTO
{
    /// <summary>
    /// Item data transfer object.  This although looks identical to the entity is used to decouple
    ///   the data layer from any business logic and expose the content to the web service layer.
    /// </summary>
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
