using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Agenda.Model;

namespace Agenda.Presentation.contactos
{
    public partial class contactos : System.Web.UI.Page, IAccionPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                using (AgendaModel db = new AgendaModel())
                {
                    this.repeater.DataSource = db.Contacto.AsNoTracking().ToList();
                    this.repeater.DataBind();
                }
            }
        }
        public void Delete(int id)
        {
            using (AgendaModel db = new AgendaModel())
            {
                var result = db.Contacto.AsNoTracking().Where(c => c.ID == id).First();
                db.Entry(result).State = System.Data.Entity.EntityState.Deleted;

                db.SaveChanges();
                this.Response.Redirect("~/contactos/contactos.aspx");
            }
        }
    }
}