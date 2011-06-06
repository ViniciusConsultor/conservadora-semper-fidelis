<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>

  <div id="menu">        
                        
                <% if (Request.IsAuthenticated)
                   { %>      
                    <div><a href="/sys/Atas/Index">Atas</a></div>
                    <div><a href="/sys/Balancetes/Index">Balancetes</a></div>
                    <div><a href="/sys/Boletos/Index">Boletos</a></div>
                    <div><a href="/sys/Recados/Index">Recados</a></div>
                    <div><a href="/sys/Account/ChangePassword">Alterar Senha</a></div>
                <% } %>
  </div>