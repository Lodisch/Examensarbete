using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.WindowsAzure.Mobile.Service;
using siolRecieverService.DataObjects;
using siolRecieverService.Models;

namespace siolRecieverService.Controllers
{
    public class MsgCliRelationalController : TableController<MsgCliRelational>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            siolRecieverContext context = new siolRecieverContext();
            DomainManager = new EntityDomainManager<MsgCliRelational>(context, Request, Services);
        }

        // GET tables/MsgCliRelational
        public IQueryable<MsgCliRelational> GetAllMsgCliRelational()
        {
            return Query(); 
        }

        // GET tables/MsgCliRelational/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<MsgCliRelational> GetMsgCliRelational(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/MsgCliRelational/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<MsgCliRelational> PatchMsgCliRelational(string id, Delta<MsgCliRelational> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/MsgCliRelational
        public async Task<IHttpActionResult> PostMsgCliRelational(MsgCliRelational item)
        {
            MsgCliRelational current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/MsgCliRelational/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteMsgCliRelational(string id)
        {
             return DeleteAsync(id);
        }

    }
}