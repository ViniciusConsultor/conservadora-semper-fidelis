<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ConservadoraSiteMVC2.Models.moradores>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Apagar Moradores
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Apagar</h2>

    <h3>Deseja apagar este morador?</h3>
    <center>
    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label">Identificação :</div>
        <div class="display-field"><%: Model.idmoradores %></div>

        <div class="display-label">Nome :</div>
        <div class="display-field"><%: Model.nome %></div>
       
        <div class="display-label">CPF :</div>
        <div class="display-field"><%: Model.cpf %></div>
        
        <div class="display-label">Login :</div>
        <div class="display-field"><%: Model.login %></div>
                 
        <div class="display-label">E-mail :</div>
        <div class="display-field"><%: Model.email %></div>
        
    </fieldset>
    </center>
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" value="Apagar" /> |
		    <%: Html.ActionLink("Voltar à Lista", "Index") %>
        </p>
    <% } %>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="TituloControle" runat="server">
</asp:Content>

