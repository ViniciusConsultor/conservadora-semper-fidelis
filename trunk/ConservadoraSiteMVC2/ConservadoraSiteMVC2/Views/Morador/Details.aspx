<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ConservadoraSiteMVC2.Models.moradores>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Detalhes
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Detalhes</h2>
    <center>
    <fieldset>
        <legend>Campos</legend>
          
        <div class="display-label">Idenficação :</div>
        <div class="display-field"><%: Model.idmoradores %></div>

            <div class="display-label">Nome :</div>
        <div class="display-field"><%: Model.nome %></div>

        <div class="display-label">Cpf :</div>
        <div class="display-field"><%: Model.cpf %></div>
        
        <div class="display-label">Login :</div>
        <div class="display-field"><%: Model.login %></div>
                  
        <div class="display-label">E-Mail :</div>
        <div class="display-field"><%: Model.email %></div>
        
    </fieldset>
    </center>
    <p>

        <%: Html.ActionLink("Editar", "Edit", new { id=Model.idmoradores }) %> |
        <%: Html.ActionLink("Redefinir Senha", "ResetarSenha", new { id = Model.idmoradores })%> |
        <%: Html.ActionLink("Voltar à Lista", "Index") %>
    </p>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="TituloControle" runat="server">
Detalhes
</asp:Content>

