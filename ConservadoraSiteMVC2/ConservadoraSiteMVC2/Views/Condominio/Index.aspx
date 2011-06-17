<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<ConservadoraSiteMVC2.Models.condominio>>" %>
<%@ Import Namespace="ConservadoraSiteMVC2.Models" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Adm. de Condomínios
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<%
    Moradores controle = new Moradores();
    List<moradores> moradoresLista = controle.RetornaLista();
     %>
    <h2>Adm. de Condomínios </h2>
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
                Endereco
                </th>
                 <th>
                Sindico
            </th>
            <th>Ações</th>             
           
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: item.idcondominios %>
            </td>
            <td>
                <%: item.nome %>
            </td>
            <td>
                <%: item.endereco %>
            </td>
            <td>
                <% moradores mor = moradoresLista.Where(p => p.idmoradores == item.Sindico).FirstOrDefault();
                   Response.Write(mor == null ? "" : mor.nome);
                %>
            </td>
              <td>
                <%: Html.ActionLink("Editar", "Edit", new { id=item.idcondominios }) %> |
                <%: Html.ActionLink("Detalhar", "Details", new { id=item.idcondominios })%> |
                <%: Html.ActionLink("Excluir", "Delete", new { id=item.idcondominios })%>
            </td>
        </tr>
    
    <% } %>

    </table>
    </center>
    <p>
        <%: Html.ActionLink("Adicionar", "Create") %>
    </p>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="TituloControle" runat="server">
Adm. de Condomínios
</asp:Content>

