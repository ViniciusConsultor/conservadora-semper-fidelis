<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<ConservadoraSiteMVC2.Models.boleto>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Boletos
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<center>

    <table>
        <tr>
            <th>
                Id
            </th>
            <th>
                Data
            </th>
            <th>
                Situação
            </th>         
            <th>
                Valor
            </th>      
          
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: item.idboletos %>
            </td>
            <td>
               <a href="/sys/Boletos/Download/<%:item.idboletos%>" > <%: String.Format("{0:g}", item.data) %> </a>
            </td>
            <td>
                <%: item.sitiuacao %>
            </td>
            <td>
                <%: item.valor %>
            </td>           
        </tr>    
    <% } %>

    </table>
    </center> 

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="TituloControle" runat="server">
<h3>Listagem de Boletos</h3>
</asp:Content>

