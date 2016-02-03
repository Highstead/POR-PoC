using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Http;
using System.Xml.XPath;
using PoR.DTO;
using PoR.Logic.BL;
using PoR.Logic.DAL;

namespace PoR.API.Controllers
{
    //[Authorize]   - you would do this if you wanted the API to be logged in.
    [RoutePrefix("api/ItemInventory")]
    public class ItemInventoryController : ApiController
    {
        private static ItemBL _itemBl;

        private static string ConnString 
        {
            get { return ConfigurationManager.ConnectionStrings["PoREntities"].ToString(); }
        }

        private static ItemBL ItemBl
        {
            get { return _itemBl ?? (_itemBl = new ItemBL(ConnString)); }
        }


        [Route("{id:int}")]
        public HttpResponseMessage Get(int id)
        {
            var dto = new ItemDto()
            {
                Category = "chairs",
                Name = "steel chair",
                Quantity = 20
            };

            return Request.CreateResponse(HttpStatusCode.OK, dto, new JsonMediaTypeFormatter());
            /*
            var result = ItemBl.GetItem(id);

            return Request.CreateResponse(HttpStatusCode.OK, result);*/
        }

        
        [Route("")]
        public HttpResponseMessage Get()
        {
            var result = ItemBl.GetItems();

            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        // POST api/<controller>
        [Route("")]
        public void Post([FromBody]ItemDto value)
        {
            var result = ItemBl.AddItem(value);
        }

        // PUT api/<controller>/5
        [Route("")]
        public void Put(int id, [FromBody]ItemDto value)
        {
            var result = ItemBl.UpdateItem(value);
        }

        // DELETE api/<controller>/5
        [Route("{id:int}")]
        public void Delete(int id)
        {
            var result = ItemBl.DeleteItem(id);
        }
    }
}