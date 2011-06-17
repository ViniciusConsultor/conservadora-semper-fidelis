<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<ConservadoraSiteMVC2.Models.moradores>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Adm. de Moradores
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Adm. de Moradores</h2>
    <%:ViewData["Mensagem"] != null ? ViewData["Mensagem"].ToString() : "" %>
    <center>
    <table>
        <tr>
            <th>
                Identificação
            </th>            
             <th>
                Nome
            </th>
            <th>
                CPF
            </th>
              <th>
                Ações
              </th>    
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: item.idmoradores %>
            </td>      
           <td>
                <%: item.nome %>
            </td>
            <td>
                <%: item.cpf %>
            </td>  
            <td>
                <%: Html.ActionLink("Editar", "Edit", new { id=item.idmoradores }) %> |
                <%: Html.ActionLink("Detalhar", "Details", new { id=item.idmoradores })%> |
                <%: Html.ActionLink("Excluir", "Delete", new { id=item.idmoradores })%>
            </td>
        </tr>
    
    <% } %>

    </table>
    </center>
    <p>
        <%: Html.ActionLink("Adicionar Morador", "Create") %>
    </p>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="TituloControle" runat="server">
 Adm. de Moradores
</asp:Content>

