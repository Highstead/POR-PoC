using System.Data.Entity;
using System.Linq;

namespace PoR.Logic.DAL
{
    /// <summary>
    /// The functions specific to the booked items portions of the data access layer.
    /// </summary>
    sealed partial class DataAccessLayer
    {
        public void Add(BookedItem entity)
        {
            using (var dbContext = new PoREntities(ConnectionString))
            {
                dbContext.BookedItems.Add(entity);
                dbContext.SaveChanges();
            }
        }

        public void Update(BookedItem entity)
        {
            using (var dbContext = new PoREntities(ConnectionString))
            {
                // We could turn this into an upsert 
                dbContext.BookedItems.Attach(entity);
                dbContext.Entry(entity).State = EntityState.Modified;
                dbContext.SaveChanges();
            }
        }

        public void Delete(BookedItem entity)
        {
            DeleteItem(entity.BookedItemId);
        }

        public void DeleteBookedItem(int itemId)
        {
            using (var dbContext = new PoREntities(ConnectionString))
            {
                var item = from itm in dbContext.BookedItems
                           where itm.BookedItemId == itemId
                           select itm;

                dbContext.BookedItems.Remove(item.First());
            }
        }

        public BookedItem GetBookedItem(int id)
        {
            using (var dbContext = new PoREntities(ConnectionString))
            {
                var item = from itm in dbContext.BookedItems
                           where itm.BookedItemId == id
                           select itm;

                return item.First();
            }
        }
    }
}
