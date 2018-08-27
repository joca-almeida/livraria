using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Excluir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarLivros();
        }

        private void ExibirMensagem(string mensagem)
        {
            ScriptManager.RegisterStartupScript(this, GetType(),
                "alerta", "alert('" + mensagem + "')", true);
        }

        private void CarregarLivros()
        {
            var livroDAL = new ServiceReference1.ServiceClient();            

            gvLivros.DataSource = livroDAL.ListarLivros();
            gvLivros.DataBind();
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            int n = 0;
            bool verifica = int.TryParse(txtCodigo.Text, out n);

            if (verifica)
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);

                var livroDAL = new ServiceReference1.ServiceClient();

                livroDAL.ExcluirLivro(codigo);

                ExibirMensagem("Livro excluído com sucesso!!");

                CarregarLivros();

                txtCodigo.Text = string.Empty;
            }
            else
            {
                ExibirMensagem("Código digitado não é válido.");
            }            
        }
    }
}