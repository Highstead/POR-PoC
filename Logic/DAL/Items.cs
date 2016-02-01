using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace PoR.Logic.DAL
{
    sealed partial class DataAccessLayer
    {
        public void Add(Item entity)
        {
            using (var dbContext = new PoREntities(ConnectionString))
            {
                dbContext.Items.Add(entity);
                dbContext.SaveChanges();
            }
        }

        public void Update(Item entity)
        {
            using (var dbContext = new PoREntities(ConnectionString))
            {
                // We could turn this into an upsert 
                dbContext.Items.Attach(entity);
                dbContext.Entry(entity).State = EntityState.Modified;
                dbContext.SaveChanges();
            }
        }

        public void Delete(Item entity)
        {
            DeleteItem(entity.ItemId);
        }

        public void DeleteItem(int itemId)
        {
            using (var dbContext = new PoREntities(ConnectionString))
            {
                var item = from itm in dbContext.Items
                           where itm.ItemId == itemId
                           select itm;

                dbContext.Items.Remove(item.First());
            }
        }

        public Item GetItem(int id)
        {
            using (var dbContext = new PoREntities(ConnectionString))
            {
                var item = from itm in dbContext.Items
                           where itm.ItemId == id
                           select itm;

                return item.First();
            }
        }

        public List<Item> GetItems()
        {
            using (var dbContext = new PoREntities(ConnectionString))
            {
                var items = from itm in dbContext.Items select itm;

                return items.ToList();
            }
        }
    }
}
