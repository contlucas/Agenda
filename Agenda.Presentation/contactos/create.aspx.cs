using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;
using System.Web.Security;
using Agenda.Model;

namespace Agenda.Presentation.contactos
{
    public partial class create : System.Web.UI.Page
    {
        private int IdContacto
        {
            get
            {
                int id = 0;
                Int32.TryParse(Request.QueryString["id"], out id);
                return id;
            }
        }
        private bool isEditMode
        {
            get
            {
                bool isEdit = false;
                Boolean.TryParse(Request.QueryString["editmode"], out isEdit);
                return isEdit;
            }
        }
        private object getFormValueFromKey(string key)
        {
            return Request.Form[key];
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (this.isEditMode)
                {
                    using (AgendaModel db = new AgendaModel())
                    {
                        var contact = db.Contacto.Where(c => c.ID == this.IdContacto).FirstOrDefault();
                        if (contact == null)
                        {
                            //TODO: throw an exception to indicate that the contant has not found
                        }
                        else
                        {
                            this.txtNombre.Text = contact.Nombre;
                            this.txtApellido.Text = contact.Apellido;
                            this.txtEdad.Text = Convert.ToString(contact.Edad);
                        }
                    }
                }
            }
            else
            {
                FormsAuthentication.RedirectToLoginPage();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            using (AgendaModel db = new AgendaModel())
            {
                Contacto contacto;

                if (this.isEditMode)
                    contacto = db.Contacto.Where(c => c.ID == this.IdContacto).First();
                else
                    contacto = new Contacto();

                contacto.Nombre = this.getFormValueFromKey("ctl00$ctl00$content$content$txtNombre").ToString();
                contacto.Apellido = this.getFormValueFromKey("ctl00$ctl00$content$content$txtApellido").ToString();
                contacto.Edad = Convert.ToInt32(this.getFormValueFromKey("ctl00$ctl00$content$content$txtEdad"));
                contacto.Usuario = User.Identity.Name;
                contacto.FechaCreacion = DateTime.Now;

                if (this.isEditMode)
                    db.Entry(contacto).State = System.Data.Entity.EntityState.Modified;
                else
                    db.Contacto.Add(contacto);

                db.SaveChanges();
                this.Response.Redirect("~/contactos/contactos.aspx");
            }
        }
    }
}