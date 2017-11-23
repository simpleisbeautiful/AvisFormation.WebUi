@Code
    ViewBag.Title = "Réinitialiser la confirmation du mot de passe"
End Code

<hgroup class="title">
    <h1>@ViewBag.Title.</h1>
</hgroup>
<div>
    <p>
        Votre mot de passe a été réinitialisé. Veuillez @Html.ActionLink("cliquer ici pour vous connecter", "Login", "Account", routeValues:=Nothing, htmlAttributes:=New With {Key .id = "loginLink"})
    </p>
</div>
