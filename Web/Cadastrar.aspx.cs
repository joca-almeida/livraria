using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;

namespace Web
{
    public partial class Cadastrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void ExibirMensagem(string mensagem)
        {
            ScriptManager.RegisterStartupScript(this, GetType(),
                "alerta", "alert('" + mensagem + "')", true);
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            ServiceReference1.Livro objlivro = new ServiceReference1.Livro();

            objlivro.TituloLivro = txtTitulo.Text;
            objlivro.NomeAutor = txtAutor.Text;
            objlivro.SinopseLivro = txtSinopse.Text;

            var livroDAL = new ServiceReference1.ServiceClient();

            livroDAL.CadastrarLivro(objlivro);            


            ExibirMensagem("Livro cadastrado com sucesso!!");

            txtAutor.Text = string.Empty;
            txtSinopse.Text = string.Empty;
            txtTitulo.Text = string.Empty;
        }
    }
}