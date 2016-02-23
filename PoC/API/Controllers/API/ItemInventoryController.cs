using PoR.DTO;
using PoR.Logic.BL;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PoR.API.Controllers
{
    /// <summary>
    /// Here is an example web api controller.  This is done in the standard MVC templates, 
    /// but the end goal here would to be also host the embedded code in CRefSharp on the web server.
    /// </summary>
    [RoutePrefix("api/ItemInventory")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]      //This is potentially hazardous
    //[Authorize]   - you would do this if you wanted the API to be logged in.
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
            var result = ItemBl.GetItem(id);

            return Request.CreateResponse(HttpStatusCode.OK, result);
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