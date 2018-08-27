<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastrar.aspx.cs" Inherits="Web.Cadastrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4>
        Tela para cadastros de livros.</h4>
    <br />
    Título<br />
<asp:TextBox ID="txtTitulo" runat="server" Width="174px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTitulo" ErrorMessage="Título obrigatório." ForeColor="Red"></asp:RequiredFieldValidator>
<br />
<br />
Autor<br />
<asp:TextBox ID="txtAutor" runat="server" Width="174px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAutor" ErrorMessage="Autor obrigatório." ForeColor="Red"></asp:RequiredFieldValidator>
<br />
<br />
Sinopse<br />
<asp:TextBox ID="txtSinopse" runat="server" Height="117px" TextMode="MultiLine" Width="712px"></asp:TextBox>
    <br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtSinopse" ErrorMessage="Sinopse obrigatório." ForeColor="Red"></asp:RequiredFieldValidator>
<br />
<br />
<asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" Width="117px" OnClick="btnCadastrar_Click" />
<br />
<br />
    <br />
</asp:Content>
