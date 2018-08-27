using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Models;

// OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService" no arquivo de código e configuração ao mesmo tempo.
[ServiceContract]
public interface IService
{

	[OperationContract]
	string GetData(int value);

	[OperationContract]
	CompositeType GetDataUsingDataContract(CompositeType composite);

    // TODO: Adicione suas operações de serviço aqui
    [OperationContract]
    void CadastrarLivro(Livro objLivro);

    [OperationContract]
    List<Livro> ListarLivros();

    [OperationContract]
    void ExcluirLivro(int codigo);

    [OperationContract]
    Livro BuscarLivro(int codigo);

    [OperationContract]
    void AtualizarLivro(Livro l);
}

// Use um contrato de dados como ilustrado no exemplo abaixo para adicionar tipos compostos a operações de serviço.
[DataContract]
public class CompositeType
{
	bool boolValue = true;
	string stringValue = "Hello ";

	[DataMember]
	public bool BoolValue
	{
		get { return boolValue; }
		set { boolValue = value; }
	}

	[DataMember]
	public string StringValue
	{
		get { return stringValue; }
		set { stringValue = value; }
	}
}
