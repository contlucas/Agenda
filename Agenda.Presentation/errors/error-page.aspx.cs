using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agenda.Presentation.errors
{
    public partial class error_page : System.Web.UI.Page
    {
        protected int statusCode;
        protected string encabezadoPage;
        protected string mensajePage;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ConfigurarParametros();
        }

        private void ConfigurarParametros()
        {
            Exception ex = Server.GetLastError();
            HttpException hex = ex as HttpException;

            if (hex != null)
            {
                //this.statusCode = hex.GetHttpCode();

                //switch (this.statusCode)
                //{
                //    case 404:
                //        {
                //            this.encabezadoPage = "Pagina no encontrada";
                //            this.mensajePage = "La página web que esta buscando no se encuentra o fue removida a otro servidor.";
                //            this.Title = this.encabezadoPage;
                //            break;
                //        }
                //    default:
                //        {
                //            break;
                //        }
                //}
            }

            this.statusCode = Convert.ToInt32(Request.QueryString["statusCode"]);

            switch (this.statusCode)
            {
                case 404:
                    {
                        this.encabezadoPage = "Pagina no encontrada";
                        this.mensajePage = "La página web que esta buscando no se encuentra o fue removida a otro servidor.";
                        this.Title = this.encabezadoPage;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            Server.ClearError();
        }
    }
}