using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DAL;
using Models;

// OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service" no arquivo de código, svc e configuração ao mesmo tempo.
public class Service : IService
{
	public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}

    public void CadastrarLivro(Livro objLivro)
    {
        LivrariaDAL lDAL = new LivrariaDAL();

        lDAL.CadastrarLivro(objLivro);
    }

    public List<Livro> ListarLivros()
    {
        LivrariaDAL lDAL = new LivrariaDAL();

        return lDAL.ListarLivros();
    }

    public void ExcluirLivro(int codigo)
    {
        LivrariaDAL lDAL = new LivrariaDAL();

        lDAL.ExcluirLivro(codigo);
    }

    public Livro BuscarLivro(int codigo)
    {
        LivrariaDAL lDAL = new LivrariaDAL();

        Livro objLivro = lDAL.BuscarLivro(codigo);

        return objLivro;
    }

    public void AtualizarLivro(Livro l)
    {
        LivrariaDAL lDAL = new LivrariaDAL();

        lDAL.AtualizarLivro(l);
    }
}
