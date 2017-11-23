@ModelType ExternalLoginListViewModel
@Imports Microsoft.Owin.Security
@Code
    Dim loginProviders = Context.GetOwinContext().Authentication.GetExternalAuthenticationTypes()
End Code
<h4>Utilisez un autre service pour vous connecter.</h4>
<hr />
@If loginProviders.Count() = 0 Then
    @<div>
          <p>
              Aucun service d'authentification externe n'est configuré. Consultez <a href="https://go.microsoft.com/fwlink/?LinkId=403804">cet article</a>
              pour plus de détails sur la configuration de cette application ASP.NET afin qu'elle prenne en charge la connexion par l'intermédiaire de services externes.
          </p>
    </div>
Else
    @Using Html.BeginForm("ExternalLogin", "Account", New With {.ReturnUrl = Model.ReturnUrl}, FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
        @Html.AntiForgeryToken()
        @<div id="socialLoginList">
           <p>
               @For Each p As AuthenticationDescription In loginProviders
                   @<button type="submit" class="btn btn-default" id="@p.AuthenticationType" name="provider" value="@p.AuthenticationType" title="Connectez-vous avec votre compte @p.Caption">@p.AuthenticationType</button>
               Next
           </p>
        </div>
    End Using
End If
