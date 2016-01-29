using System.Data.Entity;
using System.Linq;

namespace PoR.Logic.DAL
{
    sealed partial class DataAccessLayer
    {
        public void Add(Client entity)
        {
            using (var dbContext = new PoREntities(ConnectionString))
            {
                dbContext.Clients.Add(entity);
                dbContext.SaveChanges();
            }
        }

        public void Update(Client entity)
        {
            using (var dbContext = new PoREntities(ConnectionString))
            {
                // We could turn this into an upsert 
                dbContext.Clients.Attach(entity);
                dbContext.Entry(entity).State = EntityState.Modified;
                dbContext.SaveChanges();
            }
        }

        public void Delete(Client entity)
        {
            DeleteClient(entity.ClientId);
        }

        public void DeleteClient(int id)
        {
            using (var dbContext = new PoREntities(ConnectionString))
            {
                var entity = from client in dbContext.Clients
                           where client.ClientId == id
                           select client;

                dbContext.Clients.Remove(entity.First());
            }
        }

        public Client GetClient(int id)
        {
            using (var dbContext = new PoREntities(ConnectionString))
            {
                var entity = from client in dbContext.Clients
                    where client.ClientId == id
                    select client;

                return entity.First();
            }
        }
    }
}
