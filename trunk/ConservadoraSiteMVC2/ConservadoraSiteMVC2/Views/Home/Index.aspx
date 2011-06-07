<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="TituloControle" runat="server">
    <h3>Início</h3>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
    <p>
       <div class="atalho">
           <img alt="Atas" src="/sys/Content/Imagens/26_48x48.png" 
               style="width: 48px; height: 48px" /><br />
           <a href="/sys/Atas/Index">Atas</a></div>
       <div class="atalho">
           <img alt="Balancetes" src="/sys/Content/Imagens/34_48x48.png" 
               style="width: 48px; height: 48px" /><br />
            <a href="/sys/Balancetes/Index">Balancetes</a></div>
       <div class="atalho">
           <img alt="Recados" longdesc="Recados" src="/sys/Content/Imagens/3_48x48.png" 
               style="width: 48px; height: 48px" /><br />
            <a href="/sys/Recados/Index">Recados</a></div><br />
       <div class="atalho">
           <img alt="Boletos" longdesc="Boletos" src="../../Content/Imagens/80.png" 
               style="width: 48px; height: 48px" /><br />
           <a href="/sys/Boletos/Index">Boletos</a></div>
       <div class="atalho">
           <img alt="Alterar Senha" longdesc="Alterar Senha" 
               src="../../Content/Imagens/49.png" style="width: 48px; height: 48px" /><br />
            <a href="/sys/Account/ChangePassword">Alterar Senha</a></div>
       <div class="atalho">
           <img alt="Sair" src="../../Content/Imagens/118.png" 
               style="width: 48px; height: 48px" /><br />
            <a href="/sys/Account/LogOff">LogOut</a></div>
    </p>
    </form>
</asp:Content>
