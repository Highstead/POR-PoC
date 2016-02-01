using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Xml.XPath;
using PoR.DTO;
using PoR.Logic.BL;
using PoR.Logic.DAL;

namespace PoR.API.Controllers
{
    //[Authorize]   - you would do this if you wanted the API to be logged in.
    [RoutePrefix("ItemInventory")]
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

        // GET api/<controller>
        public HttpResponseMessage Get()
        {
            var result = ItemBl.GetItems();

            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [Route("{id:int}")]
        public HttpResponseMessage Get(int id)
        {
            var result = ItemBl.GetItem(id);

            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        // POST api/<controller>
        public void Post([FromBody]ItemDto value)
        {
            var result = ItemBl.AddItem(value);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]ItemDto value)
        {
            var result = ItemBl.UpdateItem(value);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            var result = ItemBl.DeleteItem(id);
        }
    }
}