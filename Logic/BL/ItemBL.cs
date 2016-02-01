using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoR.Logic.DAL;
using PoR.DTO;

namespace PoR.Logic.BL
{
    public class ItemBL
    {
        private string ConnectionString { get; set; }
        private DataAccessLayer _dal = null;
        private DataAccessLayer DAL {
            get { return _dal ?? (_dal = new DataAccessLayer(ConnectionString)); }
            set { _dal = value; }
        }

        public ItemBL()
        {
            ConnectionString = null;
            DAL = new DataAccessLayer();
        }

        public ItemBL(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public bool AddItem(ItemDto dto)
        {
            var entity = ModelFactory.ModelFactory.CreateEntity(dto);
            DAL.Add(entity);
            return true;
        }

        public IEnumerable<ItemDto> GetItems()
        {
            var dtos = DAL.GetItems();
            return ModelFactory.ModelFactory.CreateModel(dtos);
        }

        public ItemDto GetItem(int id)
        {
            var dto = DAL.GetItem(id);
            if (dto == null) return null;
            return ModelFactory.ModelFactory.CreateModel(dto);
        }

        public bool UpdateItem(ItemDto dto)
        {
            var entity = ModelFactory.ModelFactory.CreateEntity(dto);
            if (entity == null) return false;
            DAL.Update(entity);
            return true;
        }

        public bool DeleteItem(int id)
        {
            if (id < 1) return false;
            DAL.DeleteItem(id);
            return true;
        }
    }
}
