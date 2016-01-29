using System.Collections.Generic;
using System.Linq;
using PoR.Logic.DAL;
using DTO = PoR.DTO;
using Entity = PoR.Logic.DAL;

namespace PoR.Logic.ModelFactory
{
    public static partial class ModelFactory
    {
        public static IEnumerable<DTO.BookedItemDto> CreateModel(IEnumerable<BookedItem> entities)
        {
            if (entities == null)
                return null;

            var modelList = entities.Select(CreateModel).ToList();
            return modelList;
        }

        public static DTO.BookedItemDto CreateModel(BookedItem entity)
        {
            if (entity == null)
                return null;

            var model = new DTO.BookedItemDto()
            {
                Quantity = entity.Quantity,
                BookedItemId = entity.BookedItemId,
                EndTime = entity.EndTime,
                ClientId = entity.Client.ClientId,
                ItemId = entity.Item.ItemId,
                StartTime = entity.StartTime
            };

            return model;
        }

        public static IEnumerable<BookedItem> CreateEntities(IEnumerable<DTO.BookedItemDto> models)
        {
            if (models == null)
                return null;

            var entityList = models.Select(CreateEntity);
            return entityList;
        }

        public static BookedItem CreateEntity(DTO.BookedItemDto Dto)
        {
            if (Dto == null)
                return null;

            var entity = new BookedItem()
            {
                Quantity = Dto.Quantity,
                BookedItemId = Dto.BookedItemId,
                EndTime = Dto.EndTime,
                StartTime = Dto.EndTime,
                ClientId = Dto.ClientId ?? 0,
                ItemId = Dto.ItemId ?? 0,
            };

            return entity;
        }
    }
}
