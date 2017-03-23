using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agenda.Presentation.UserControl
{
    public partial class delete_modal : System.Web.UI.UserControl
    {
        public string ModalID { get; set; }
        public string ModalTitulo { get; set; }
        public string ModalContenido { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAccion_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(this.hdmValue.Value);
            ((IAccionPage)this.Parent.Page).Delete(id);
        }
    }
}