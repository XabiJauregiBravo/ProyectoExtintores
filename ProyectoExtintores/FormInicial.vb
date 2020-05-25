Imports System.Data.SQLite
Imports System.IO
Public Class FormInicial

    'Generamos la base de datos o advertimos si ya existe
    Private Sub BotonGenerarBD_Click(sender As Object, e As EventArgs) Handles botonGenerarBD.Click
        CrearDatabase()
    End Sub

    'Link al repositorio de GitHub
    Private Sub BotonGitHub_Click(sender As Object, e As EventArgs) Handles botonGithub.Click
        Dim url As String = "https://github.com/XabiJauregiBravo"
        Process.Start(url)
    End Sub

    'Inicio de la aplicacion
    Private Sub botonIniciar_Click(sender As Object, e As EventArgs) Handles botonIniciar.Click
        If Directory.Exists("C:\database") Then
            If File.Exists(RutaDb) Then
                FormMenuPrincipal.Show()
                Me.Hide()
            Else
                MsgBox("Error al conectarse a la base de datos", MsgBoxStyle.Exclamation)
            End If
        Else
            MsgBox("Error al conectarse a la base de datos", MsgBoxStyle.Exclamation)
        End If

    End Sub
End Class