using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace PoR.Logic.DAL
{
    /// <summary>
    /// These are the DAL specific Item calls.  They eventually all get merged into the singular DataAccessLayer
    /// class.  
    /// </summary>
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
                // This Could cause problems.  You could approach this like and upsert and do something like
                //   AddOrUpdate(i=> i.id == entity.Id).  Additionally you may want to set certain properties
                //   of the entity to 'not modified' if they're null so as not to update the DB.
                dbContext.SaveChanges();
            }
        }

        public void Delete(Item entity)
        {
            DeleteItem(entity.ItemId);
        }

        public void DeleteItem(int itemId)
        {
            // In a perfect wold we would not be using the auto-incremented id here but some from of generated
            //    id so that we would not expose the inner workings of the DB to the world.

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
            // In a perfect wold we would not be using the auto-incremented id here but some from of generated
            //    id so that we would not expose the inner workings of the DB to the world.

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
                // Calling the tolist here forces the DB call.  Potentially you could do something fancy
                //    and add additional parameters if you returned it as an IQueryable.  You do however
                //    Run into issue with how EF populates the navigation properties.
                return items.ToList();
            }
        }

        public int GetItemCount()
        {
            using (var dbContext = new PoREntities(ConnectionString))
            {
                var result = from itm in dbContext.Items select itm;
                //The IQueryable isn't registered to the last second, so this isn't executed on the list,
                //    but rather at the database level as a select statement so long as we're using mssql or a 
                //    driver that supports Entity framework properly.
                return result.Count();      
            }
        }
    }
}
