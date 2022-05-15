using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LocaleAjaxDemo.Controllers
{
    public class SharedController : Controller
    {
        public ActionResult SetLanguage(int id)
        {
            Helper.Helper.CurrentCulture = id;

            if (!(Request.UrlReferrer is null))
            {
                return Redirect(Request.UrlReferrer.ToString());
            }

            return RedirectToRoute("/");
        }


        protected override IAsyncResult BeginExecute(RequestContext requestContext, AsyncCallback callback, object state)
        {
            Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture =
                Helper.Helper.Culture ?? Helper.Helper.LangCultureInfo;
            return base.BeginExecute(requestContext, callback, state);
        }
    }
}