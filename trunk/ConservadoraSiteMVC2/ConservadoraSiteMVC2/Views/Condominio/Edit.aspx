<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ConservadoraSiteMVC2.Models.condominio>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Editar Condominios
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Editar Condominios</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        <center>
        <fieldset>
            <legend>Informações</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.idcondominios) %>
            </div>
            <div class="editor-field">
                <%: Model.idcondominios%>
                <%: Html.HiddenFor(model => model.idcondominios) %>
            </div>
             <div class="editor-label">
                <%: Html.LabelFor(model => model.nome) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.nome) %>
                <%: Html.ValidationMessageFor(model => model.nome) %>
            </div>

            <div class="editor-label">
                <%: Html.LabelFor(model => model.endereco) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.endereco) %>
                <%: Html.ValidationMessageFor(model => model.endereco) %>
            </div>
                      
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Sindico) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Sindico) %>
                <%: Html.ValidationMessageFor(model => model.Sindico) %>
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
   Editar Condominio
</asp:Content>

