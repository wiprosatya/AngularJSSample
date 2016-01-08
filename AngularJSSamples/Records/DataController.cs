using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularJSSamples.Records
{
    public class DataController : Controller
    {
        //
        // GET: /Data/
        public JsonResult GetLastContact()
        {
            UserDetail ud = null;
            using (FetchRecordsEntities ur = new FetchRecordsEntities())
            {
                ud = ur.UserDetails.OrderByDescending(o => o.Id).FirstOrDefault();

            }
            return new JsonResult { Data = ud, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
	}
}