using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarLivros();
        }

        private void CarregarLivros()
        {
            var livroDAL = new ServiceReference1.ServiceClient();

            gvLivros.DataSource = livroDAL.ListarLivros();
            gvLivros.DataBind();
        }
    }
}