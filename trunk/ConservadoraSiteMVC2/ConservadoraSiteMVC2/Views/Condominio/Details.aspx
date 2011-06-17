<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ConservadoraSiteMVC2.Models.condominio>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Detalhes do Condomínio
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Detalhes do Condomínio</h2>
    <center>
    <fieldset>
        <legend>Informações :</legend>
        
        <div class="display-label">Endereço :</div>
        <div class="display-field"><%: Model.endereco %></div>
        
        <div class="display-label">Idenificação :</div>
        <div class="display-field"><%: Model.idcondominios %></div>
        
        <div class="display-label">Nome :</div>
        <div class="display-field"><%: Model.nome %></div>
        
        <div class="display-label">Sindico :</div>
        <div class="display-field"><%: Model.Sindico %></div>
        
    </fieldset>
    </center>
    <p>

        <%: Html.ActionLink("Editar", "Edit", new { id=Model.idcondominios }) %> |
        <%: Html.ActionLink("Voltar à Lista", "Index") %>
    </p>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="TituloControle" runat="server">
Detalhes do Condomínio
</asp:Content>

