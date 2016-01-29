using System.Collections.Generic;
using System.Linq;
using PoR.Logic.DAL;
using DTO = PoR.DTO;
using Entity = PoR.Logic.DAL;

namespace PoR.Logic.ModelFactory
{
    public static partial class ModelFactory
    {
        public static IEnumerable<DTO.ClientDto> CreateModel(IEnumerable<Client> entities)
        {
            if (entities == null)
                return null;

            var modelList = entities.Select(CreateModel).ToList();
            return modelList;
        }

        public static DTO.ClientDto CreateModel(Client entity)
        {
            if (entity == null)
                return null;

            var model = new DTO.ClientDto()
            {
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                ClientId = entity.ClientId
            };

            return model;
        }

        public static IEnumerable<Client> CreateEntities(IEnumerable<DTO.ClientDto> models)
        {
            if (models == null)
                return null;

            var entityList = models.Select(CreateEntity);
            return entityList;
        }

        public static Client CreateEntity(DTO.ClientDto model)
        {
            if (model == null)
                return null;

            var entity = new Client()
            {
                ClientId = model.ClientId ?? 0,
                LastName = model.LastName,
                FirstName = model.FirstName
            };

            return entity;
        }
    }
}
