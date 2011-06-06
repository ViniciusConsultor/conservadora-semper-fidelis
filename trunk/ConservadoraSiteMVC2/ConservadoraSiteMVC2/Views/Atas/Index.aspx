<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<ConservadoraSiteMVC2.Models.ata>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Listagem de Atas
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

   <center>

    <table>
        <tr>
            <th>
                Id
            </th>
            <th>
                Descrição
            </th>
            <th>
                Condomínio
            </th>         
            <th>
                Data
            </th>      
          
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: item.idata %>
            </td>
            <td>
               <a href="/sys/Atas/Download/<%:item.idata%>" ><%:item.descricao%></a>
            </td>
            <td>
                <%: item.condominio.nome %>
            </td>
            <td>
                <%: String.Format("{0:g}", item.data) %>
            </td>           
        </tr>    
    <% } %>

    </table>
    </center> 
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="TituloControle" runat="server">
 <h3>Atas</h3>
</asp:Content>

