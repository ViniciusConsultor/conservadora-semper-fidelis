<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ConservadoraSiteMVC2.Models.condominio>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Excluir Condomínio :
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Excluir</h2>
    <center>
    <h3>Tem certeza que deseja excluir este registro?</h3>
    <fieldset>
        <legend>Informações :</legend>
        
        <div class="display-label">Identificação :</div>
        <div class="display-field"><%: Model.idcondominios %></div>

        <div class="display-label">Nome :</div>
        <div class="display-field"><%: Model.nome %></div>

        <div class="display-label">Endereço :</div>
        <div class="display-field"><%: Model.endereco %></div>
        
    </fieldset>
    </center>
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" value="Excluir" /> |
		    <%: Html.ActionLink("Voltar à Lista", "Index") %>
        </p>
    <% } %>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="TituloControle" runat="server">
</asp:Content>

