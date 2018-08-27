using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Editar : System.Web.UI.Page
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

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);

            var livroDAL = new ServiceReference1.ServiceClient();
            var objLivro = new ServiceReference1.Livro();

            objLivro = livroDAL.BuscarLivro(codigo);

            if (objLivro != null)
            {
                txtCodigo.Text = objLivro.CdLivro.ToString();
                txtAutor.Text = objLivro.NomeAutor;
                txtSinopse.Text = objLivro.SinopseLivro;
                txtTitulo.Text = objLivro.TituloLivro;

                btnEditar.Enabled = false;
                txtCodigo.Enabled = false;

                txtAutor.Enabled = true;
                txtTitulo.Enabled = true;
                txtSinopse.Enabled = true;
                btnSalvar.Enabled = true;
            }
            else
            {
                ExibirMensagem("Livro não encontrado");
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            var objLivro = new ServiceReference1.Livro();

            objLivro.CdLivro = Convert.ToInt32(txtCodigo.Text);
            objLivro.NomeAutor = txtAutor.Text;
            objLivro.SinopseLivro = txtSinopse.Text;
            objLivro.TituloLivro = txtTitulo.Text;

            var lDAL = new ServiceReference1.ServiceClient();

            lDAL.AtualizarLivro(objLivro);

            ExibirMensagem("Livro atualizado com sucesso!");

            CarregarLivros();

            txtCodigo.Text = string.Empty;
            txtAutor.Text = string.Empty;
            txtSinopse.Text = string.Empty;
            txtTitulo.Text = string.Empty;

            btnEditar.Enabled = true;
            txtCodigo.Enabled = true;

            txtAutor.Enabled = false;
            txtTitulo.Enabled = false;
            txtSinopse.Enabled = false;
            btnSalvar.Enabled = false;
        }
    }
}