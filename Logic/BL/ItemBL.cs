using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoR.Logic.DAL;
using PoR.DTO;
using PoR.Logic.DAL;

namespace PoR.Logic.BL
{
    public class ItemBL
    {
        private string ConnectionString { get; set; }
        private DataAccessLayer DAL { get; set; }

        public ItemBL(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void AddItem(ItemDto dto)
        {
            
        }
    }
}
