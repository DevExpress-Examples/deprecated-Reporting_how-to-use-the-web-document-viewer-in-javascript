using System.Linq;
using DevExpress.Web.Mvc.Controllers;
using System.Web.Mvc;
using DevExpress.XtraReports.Web.Extensions;

namespace ServerSide.Controllers
{
    public class WebDocumentViewerController : WebDocumentViewerApiControllerBase {
        public override ActionResult Invoke() {
            var result = base.Invoke();
            // Allow cross-domain requests.
            Response.AppendHeader("Access-Control-Allow-Origin", "*");
            return result;
        }

        [HttpPost]
        public ActionResult GetReports() {
            Response.AppendHeader("Access-Control-Allow-Origin", "*");
            var result = new JsonResult {
                Data = ReportStorageWebService.GetUrls().ToArray()
            };
            return result;
        }
    }
}