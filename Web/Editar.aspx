<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Editar.aspx.cs" Inherits="Web.Editar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4>
        Para editar utilize o código da lista abaixo:</h4>
    <p>
        &nbsp;</p>
    <asp:GridView ID="gvLivros" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="515px">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="CdLivro" HeaderText="Código" />
            <asp:BoundField DataField="TituloLivro" HeaderText="Título" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <br />
        <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
        *Digite o código e clique em editar.
    <br />
    <br />
        <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnBuscar_Click" />
    
    <br />
    <br />

        <b>Edite o livro e depois clique em salvar.</b>     
    <br />
    <br />

        Titulo<br />
&nbsp;<asp:TextBox ID="txtTitulo" runat="server" Enabled="False"></asp:TextBox>
    <br />
    <br />
    
        Autor<br />
&nbsp;<asp:TextBox ID="txtAutor" runat="server" Enabled="False"></asp:TextBox>
    
    <br />    
    <br />
        Sinopse<br />
&nbsp;<asp:TextBox ID="txtSinopse" runat="server" Height="148px" TextMode="MultiLine" Width="293px" Enabled="False"></asp:TextBox>
    
    <br />
    <br />
        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" Enabled="False" OnClick="btnSalvar_Click" />
    
</asp:Content>
