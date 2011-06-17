<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ConservadoraSiteMVC2.Models.moradores>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Editar Moradores
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Edit</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        <center>
        <fieldset>
            <legend>Informações :</legend>               
            <div class="editor-label">
                Identificação :
            </div>
            <div class="editor-field">
                <%: Model.idmoradores %>
                <%: Html.HiddenFor(model => model.idmoradores) %>
            </div>

            <div class="editor-label">
               Nome :
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.nome) %>
                <%: Html.ValidationMessageFor(model => model.nome) %>
            </div>

            <div class="editor-label">
            CPF :
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.cpf) %>
                <%: Html.ValidationMessageFor(model => model.cpf) %>
            </div>    
            
            <div class="editor-label">
                Login :
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.login) %>
                <%: Html.ValidationMessageFor(model => model.login) %>
            </div>                                    
                      
            <div class="editor-label">
                E-mail :
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.email) %>
                <%: Html.ValidationMessageFor(model => model.email) %>
            </div>
            
            <p>
                <input type="submit" value="Salvar" />
            </p>
        </fieldset>
        </center>
    <% } %>

    <div>
        <%: Html.ActionLink("Voltar à Lista", "Index") %>
    </div>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="TituloControle" runat="server">
  Editar Moradores
</asp:Content>

