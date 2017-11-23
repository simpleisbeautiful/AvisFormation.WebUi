Imports System.ComponentModel.DataAnnotations

Public Class ExternalLoginConfirmationViewModel
    <Required>
    <Display(Name:="Courrier électronique")>
    Public Property Email As String
End Class

Public Class ExternalLoginListViewModel
    Public Property ReturnUrl As String
End Class

Public Class SendCodeViewModel
    Public Property SelectedProvider As String
    Public Property Providers As ICollection(Of System.Web.Mvc.SelectListItem)
    Public Property ReturnUrl As String
    Public Property RememberMe As Boolean
End Class

Public Class VerifyCodeViewModel
    <Required>
    Public Property Provider As String
    
    <Required>
    <Display(Name:="Code")>
    Public Property Code As String
    
    Public Property ReturnUrl As String
    
    <Display(Name:="Mémoriser ce navigateur ?")>
    Public Property RememberBrowser As Boolean

    Public Property RememberMe As Boolean
End Class

Public Class ForgotViewModel
    <Required>
    <Display(Name:="Courrier électronique")>
    Public Property Email As String
End Class

Public Class LoginViewModel
    <Required>
    <Display(Name:="Courrier électronique")>
    <EmailAddress>
    Public Property Email As String

    <Required>
    <DataType(DataType.Password)>
    <Display(Name:="Mot de passe")>
    Public Property Password As String

    <Display(Name:="Mémoriser le mot de passe ?")>
    Public Property RememberMe As Boolean
End Class

Public Class RegisterViewModel
    <Required>
    <EmailAddress>
    <Display(Name:="Courrier électronique")>
    Public Property Email As String

    <Required>
    <StringLength(100, ErrorMessage:="La chaîne {0} doit comporter au moins {2} caractères.", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="Mot de passe")>
    Public Property Password As String

    <DataType(DataType.Password)>
    <Display(Name:="Confirmer le mot de passe ")>
    <Compare("Password", ErrorMessage:="Le mot de passe et le mot de passe de confirmation ne correspondent pas.")>
    Public Property ConfirmPassword As String
End Class

Public Class ResetPasswordViewModel
    <Required>
    <EmailAddress>
    <Display(Name:="Courrier électronique")>
    Public Property Email() As String

    <Required>
    <StringLength(100, ErrorMessage:="La chaîne {0} doit comporter au moins {2} caractères.", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="Mot de passe")>
    Public Property Password() As String

    <DataType(DataType.Password)>
    <Display(Name:="Confirmer le mot de passe")>
    <Compare("Password", ErrorMessage:="Le nouveau mot de passe et le mot de passe de confirmation ne correspondent pas.")>
    Public Property ConfirmPassword() As String

    Public Property Code() As String
End Class

Public Class ForgotPasswordViewModel
    <Required>
    <EmailAddress>
    <Display(Name:="E-mail")>
    Public Property Email() As String
End Class
