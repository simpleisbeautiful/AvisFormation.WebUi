@ModelType IndexViewModel
@Code
    ViewBag.Title = "Gérer"
End Code

<h2>@ViewBag.Title.</h2>

<p class="text-success">@ViewBag.StatusMessage</p>
<div>
    <h4>Changer les paramètres de votre compte</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>Mot de passe :</dt>
        <dd>
            [
            @If Model.HasPassword Then
                @Html.ActionLink("Changer votre mot de passe", "ChangePassword")
            Else
                @Html.ActionLink("Créer", "SetPassword")
            End If
            ]
        </dd>
        <dt>Connexions externes :</dt>
        <dd>
            @Model.Logins.Count [
            @Html.ActionLink("Gérer", "ManageLogins") ]
        </dd>
        @*
            Les numéros de téléphone peuvent être utilisés comme second facteur de vérification dans un système d'authentification à 2 facteurs.
             
             Consultez <a href="https://go.microsoft.com/fwlink/?LinkId=403804">cet article</a>
                pour plus de détails sur la configuration de cette application ASP.NET afin qu'elle prenne en charge l'utilisation de l'authentification à 2 facteurs à l'aide de SMS.
             
             Décommentez le bloc suivant après avoir configuré l'authentification à 2 facteurs
        *@
        @* 
            <dt>Numéro de téléphone :</dt>
            <dd>
                @(If(Model.PhoneNumber, "None"))
                @If (Model.PhoneNumber <> Nothing) Then
                    @<br />
                    @<text>[&nbsp;&nbsp;@Html.ActionLink("Change", "AddPhoneNumber")&nbsp;&nbsp;]</text>
                    @Using Html.BeginForm("RemovePhoneNumber", "Manage", FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
                        @Html.AntiForgeryToken
                        @<text>[<input type="submit" value="Supprimer" class="btn-link" />]</text>
                    End Using
                Else
                    @<text>[&nbsp;&nbsp;@Html.ActionLink("Add", "AddPhoneNumber") &nbsp;&nbsp;]</text>
                End If
            </dd>
        *@
        <dt>Authentification à 2 facteurs :</dt>
        <dd>
            <p>
                Aucun fournisseur d'authentification à deux facteurs n'est configuré. Consultez <a href="https://go.microsoft.com/fwlink/?LinkId=403804">cet article</a>
                pour plus de détails sur la configuration de cette application ASP.NET afin qu'elle prenne en charge l'authentification à deux facteurs.
            </p>
            @*
                @If Model.TwoFactor Then
                    @Using Html.BeginForm("DisableTwoFactorAuthentication", "Manage", FormMethod.Post, New With { .class = "form-horizontal", .role = "form" })
                      @Html.AntiForgeryToken()
                      @<text>
                      Activé
                      <input type="submit" value="Désactiver" class="btn btn-link" />
                      </text>
                    End Using
                Else
                    @Using Html.BeginForm("EnableTwoFactorAuthentication", "Manage", FormMethod.Post, New With { .class = "form-horizontal", .role = "form" })
                      @Html.AntiForgeryToken()
                      @<text>
                      Désactivé
                      <input type="submit" value="Activer" class="btn btn-link" />
                      </text>
                    End Using
                End If
	     *@
        </dd>
    </dl>
</div>
