using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Agenda.Seguridad;
using System.Web.Security;

namespace Agenda.Presentation
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.Identity.IsAuthenticated)
            {
                Response.Redirect(FormsAuthentication.DefaultUrl);
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (GestorSeguridad.Autenticar(this.txtUsuario.Text, this.txtPassword.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(this.txtUsuario.Text, this.chkRemberMe.Checked);
            }
            else
            {
                this.lblMensaje.Text = "El usuario y la contraseña no coinciden";
            }
        }
    }
}