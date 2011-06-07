<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ConservadoraSiteMVC2.Models.LogOnModel>" %>

<asp:Content ID="loginTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Área Restrita!
</asp:Content>

<asp:Content ID="loginContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Área Restrita!</h2>
    <p>
       Por favor, entre com seu nome e senha!.
    </p>
    <center>
    <% using (Html.BeginForm()) { %>
        <%: Html.ValidationSummary(true, "Login ou senha incorretos, Por favor tente novamente.") %>
            <fieldset>
                <legend style="text-align:center;">Dados para o login :</legend>                
                <div class="editor-label">
                    Login :
                </div>
                <div class="editor-field">
                    <%: Html.TextBoxFor(m => m.UserName) %>
                    <%: Html.ValidationMessageFor(m => m.UserName) %>
                </div>
                
                <div class="editor-label">
                    Senha :
                </div>
                <div class="editor-field">
                    <%: Html.PasswordFor(m => m.Password) %>
                    <%: Html.ValidationMessageFor(m => m.Password) %>
                </div>
                
                <div class="editor-label">
                    <%: Html.CheckBoxFor(m => m.RememberMe) %>
                    Manter conectado?
                </div>                
                <p>
                    <input type="submit" value="Entrar" />
                </p>
            </fieldset>
        </center>
    <% } %>
</asp:Content>

