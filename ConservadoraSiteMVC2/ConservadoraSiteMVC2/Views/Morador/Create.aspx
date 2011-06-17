<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<ConservadoraSiteMVC2.Models.moradores>" %>
<%@ Import Namespace="ConservadoraSiteMVC2.Models" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Adicionar Morador
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Adicionar Morador</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        <center>
        <fieldset>
            <legend>Campos :</legend>
            
            <div class="editor-label">
                Nome :
            </div>
                       
             <div class="editor-field">
                <%: Html.TextBoxFor(model => model.nome) %>
                <%: Html.ValidationMessageFor(model => model.nome) %>
            </div>        
                                   
            <div class="editor-label">
                CPF (Apenas Números):
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

            <div class="editor-label">
                Condominios :
            </div>
            <div class="editor-field" style="text-align:left">
            <%
               Condominios controle = new Condominios();
               List<condominio> lista = controle.RetornaLista();
               foreach(condominio condo in lista)
                   Response.Write("<input type='checkbox' name='condominios' value="+condo.idcondominios+" />"+condo.nome+"<br/>");               
            %>
               
            </div>
            
            <p>
                <input type="submit" value="Criar" />
            </p>
        </fieldset>
        </center>
    <% } %>

    <div>
        <%: Html.ActionLink("Voltar à Lista", "Index") %>
    </div>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="TituloControle" runat="server">
Adicionar Morador
</asp:Content>

