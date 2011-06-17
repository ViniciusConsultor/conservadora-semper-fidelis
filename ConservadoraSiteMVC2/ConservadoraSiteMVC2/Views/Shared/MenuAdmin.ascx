<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>
   <div id="menu">        
                        
                <% 
                    if (Request.IsAuthenticated)
                   { %>      
                    <div><a href="/sys/Condominio/Index">Condominios</a></div>
                    <div><a href="/sys/Morador/Index">Morador</a></div>
                <% } %>
  </div>

