Imports System.ComponentModel.DataAnnotations
Imports Microsoft.AspNet.Identity
Imports Microsoft.Owin.Security

Public Class IndexViewModel
    Public Property HasPassword As Boolean
    Public Property Logins As IList(Of UserLoginInfo)
    Public Property PhoneNumber As String
    Public Property TwoFactor As Boolean
    Public Property BrowserRemembered As Boolean
End Class

Public Class ManageLoginsViewModel
    Public Property CurrentLogins As IList(Of UserLoginInfo)
    Public Property OtherLogins As IList(Of AuthenticationDescription)
End Class

Public Class FactorViewModel
    Public Property Purpose As String
End Class

Public Class SetPasswordViewModel
    <Required>
    <StringLength(100, ErrorMessage:="Le {0} doit compter au moins {2} caractères.", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="Nouveau mot de passe")>
    Public Property NewPassword As String

    <DataType(DataType.Password)>
    <Display(Name:="Confirmer le nouveau mot de passe")>
    <Compare("NewPassword", ErrorMessage:="Le nouveau mot de passe et le mot de passe de confirmation ne correspondent pas.")>
    Public Property ConfirmPassword As String
End Class

Public Class ChangePasswordViewModel
    <Required>
    <DataType(DataType.Password)>
    <Display(Name:="Mot de passe actuel")>
    Public Property OldPassword As String

    <Required>
    <StringLength(100, ErrorMessage:="Le {0} doit compter au moins {2} caractères.", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="Nouveau mot de passe")>
    Public Property NewPassword As String

    <DataType(DataType.Password)>
    <Display(Name:="Confirmer le nouveau mot de passe")>
    <Compare("NewPassword", ErrorMessage:="Le nouveau mot de passe et le mot de passe de confirmation ne correspondent pas.")>
    Public Property ConfirmPassword As String
End Class

Public Class AddPhoneNumberViewModel
    <Required>
    <Phone>
    <Display(Name:="Numéro de téléphone")>
    Public Property Number As String
End Class

Public Class VerifyPhoneNumberViewModel
    <Required>
    <Display(Name:="Code")>
    Public Property Code As String

    <Required>
    <Phone>
    <Display(Name:="Numéro de téléphone")>
    Public Property PhoneNumber As String
End Class

Public Class ConfigureTwoFactorViewModel
    Public Property SelectedProvider As String
    Public Property Providers As ICollection(Of System.Web.Mvc.SelectListItem)
End Class