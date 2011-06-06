<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<ConservadoraSiteMVC2.Models.recado>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Recados
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <% foreach (var item in Model) { %>
    <div class="recados">
      <h4><%: item.Título %></h4>
      <%: item.Texto %>
      <p align=right><%: item.condominio.nome %></p>
    </div>       
    
    <% } %>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="TituloControle" runat="server">
<h3>Recados do Condomínio</h3>
</asp:Content>

