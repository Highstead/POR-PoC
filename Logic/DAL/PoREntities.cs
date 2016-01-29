using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PoR.Logic.DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PoREntities : DbContext
    {
        // Your context has been configured to use a 'PoREntities' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Logic.DAL.PoREntities' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'PoREntities' 
        // connection string in the application configuration file.
        public PoREntities()
            : base("name=PoREntities")
        {
        }

        public PoREntities(string connectionString) : base(connectionString) { }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<BookedItem> BookedItems { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
    }

    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemId { get; set; }

        //In a perfect world we'd use something that wasn't a guid or Auto increment id and instead
        //  We'd have a generated Id.  Something to the effect of Category + Name.

        public string Name { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }

        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDateUtc { get; set; }
    }

    public class BookedItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookedItemId { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public int Quantity { get; set; }

        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDateUtc { get; set; }

        public int ClientId { get; set; }

        public int ItemId { get; set; }

        [ForeignKey("ClientId")]
        public Client Client { get; set; }

        [ForeignKey("ItemId")]
        public Item Item { get; set; }
    }

    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    
}