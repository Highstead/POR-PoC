using System.Collections.Generic;
using System.Linq;
using PoR.Logic.DAL;
using DTO = PoR.DTO;
using Entity = PoR.Logic.DAL;

namespace PoR.Logic.ModelFactory
{
    public static partial class ModelFactory
    {
        public static List<DTO.ItemDto> CreateModel(IEnumerable<Item> entities)
        {
            if (entities == null)
                return null;

            var modelList = entities.Select(CreateModel).ToList();
            return modelList;
        }

        public static DTO.ItemDto CreateModel(Item entity)
        {
            if (entity == null)
                return null;

            var model = new DTO.ItemDto()
            {
                Quantity = entity.Quantity,
                Category = entity.Category,
                Name = entity.Name,
                ItemId = entity.ItemId
            };

            return model;
        }

        public static IEnumerable<Item> CreateEntities(IEnumerable<DTO.ItemDto> models)
        {
            if (models == null)
                return null;

            var entityList = models.Select(CreateEntity);
            return entityList;
        }

        public static Item CreateEntity(DTO.ItemDto model)
        {
            if (model == null)
                return null;

            var entity = new Item()
            {
                Quantity = model.Quantity,
                Category = model.Category,
                Name = model.Name,
                ItemId = model.ItemId ?? 0,
            };

            return entity;
        }
    }
}
