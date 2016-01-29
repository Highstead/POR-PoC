using System.Collections.Generic;
using PoR.Logic.DAL;

namespace Logic.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PoR.Logic.DAL.PoREntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PoR.Logic.DAL.PoREntities context)
        {
            //  This method will be called after migrating to the latest version.
            var clients = new List<Client>
            {
                new Client { FirstName = "Michael", LastName = "Highstead"},
                new Client { FirstName = "Jean", LastName = "Chretien"}
            };
            clients.ForEach(c => context.Clients.Add(c));
            context.SaveChanges();

            var items = new List<Item>
            {
                new Item() { Category = "Chairs", Name = "Steel Chairs", Quantity = 25},
                new Item() { Category = "Chairs", Name = "Comfy Chairs", Quantity = 10},
                new Item() { Category = "Tables", Name = "8 Foot Table", Quantity = 5},
                new Item() { Category = "Tables", Name = "6 Foot Table", Quantity = 5},
            };
            items.ForEach(i => context.Items.Add(i));
            context.SaveChanges();

            var bookedItems = new List<BookedItem>
            {
                new BookedItem() { Quantity = 4, StartTime = new DateTime(2016, 02, 01), 
                    EndTime = new DateTime(2015, 02, 12), Client = clients[0], BookedItemId = items[0].ItemId },
                new BookedItem() { Quantity = 4, StartTime = new DateTime(2016, 02, 01), 
                    EndTime = new DateTime(2015, 02, 12), Client = clients[0], BookedItemId = items[2].ItemId }
            };
            bookedItems.ForEach(bi => context.BookedItems.Add(bi));
        }
    }
}
