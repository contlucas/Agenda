using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Agenda.Presentation
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
        }
        protected void Application_Error(object sender, EventArgs e)
        {
            //Exception exc = Server.GetLastError();

            //if (exc is HttpUnhandledException)
            //{
            //    if (exc.InnerException != null)
            //    {
            //        exc = new Exception(exc.InnerException.Message);
            //        Server.Transfer("~/errors/error-page.aspx", true);
            //    }
            //}

            Exception ex = Server.GetLastError();
            HttpException he = ex as HttpException;

            if (he != null)
            {
                switch (he.GetHttpCode())
                {
                    case 404:
                        {
                            Response.Redirect(String.Format("~/errors/error-page.aspx?statusCode={0}", 404));
                            break;
                        }
                    default:
                        {
                            Response.Redirect("~/errors/error-page.aspx");
                            break;
                        }
                }
            }
        }
    }
}