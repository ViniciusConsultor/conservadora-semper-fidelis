<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ConservadoraSiteMVC2.Models.FaleConoscoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Fale Conosco
</asp:Content>

<asp:Content ID="faleConoscoContent" ContentPlaceHolderID="MainContent" runat="server">

    <p>
    <%:ViewData["Mensagem"]%>
        Entre em contato conosco através deste formulário
    </p>

    <% using (Html.BeginForm()) { %>
        <%: Html.ValidationSummary(true, "Não foi possível enviar o email") %>
        <center>
            <fieldset>
                <legend>Informações</legend>
                
                <div class="editor-label">
                    <%: Html.LabelFor(m => m.Assunto) %>
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(m => m.Assunto) %>
                </div>
                
                <div class="editor-label">
                    <%: Html.LabelFor(m => m.Texto) %>
                </div>        
                <div class="editor-field">
                    <%: Html.TextAreaFor(m => m.Texto) %>
                </div>          
                <p>
                    <input type="submit" value="Enviar" />
                </p>
            </fieldset>
        </center>
    <% } %>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="TituloControle" runat="server">
   <h3>Fale Conosco</h3>
</asp:Content>
