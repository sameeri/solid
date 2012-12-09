using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace DependencyInversionPrinciple_WithAnIocContainer.Controllers
{
    public class ValuesController : ApiController
    {
        //
        // GET: /Values/

        public String Get()
        {
            return "Christopher";
        }
    }
}
