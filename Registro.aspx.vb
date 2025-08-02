Imports System.Data.SqlClient

Public Class Registro
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim nombre As String = txtNombre.Text
        Dim apellido As String = txtApellido.Text
        Dim email As String = txtEmail.Text
        Dim pass As String = txtPass.Text

        Dim usuario As New Usuario() With {
            .Email = txtEmail.Text,
            .Password = txtPass.Text,
            .Nombre = txtNombre.Text,
            .Apellido = txtApellido.Text
        }
        If RegistrarUsuario(usuario) Then
            ' Redirigir al login o a la página de inicio

            ScriptManager.RegisterStartupScript(
                Me, Me.GetType(),
                "ServerControlScript",
                "Swal.fire('Usuario Registrado').then((result) => {
                    if (result.isConfirmed) {
                        window.location.href = 'Login.aspx';
                    }
                });",
                True)

        Else
            ScriptManager.RegisterStartupScript(
                Me, Me.GetType(),
                "ServerControlScript",
                "Swal.fire('Error al registrar el usuario. Inténtalo de nuevo.');",
                True)
            lblError.Text = "Error al registrar el usuario. Inténtalo de nuevo."
            lblError.Visible = True
        End If

    End Sub

    Private Function RegistrarUsuario(usuario As Usuario) As Boolean
        Dim helper As New DatabaseHelper()
        Dim sql As String = "INSERT INTO Usuarios (Email, Contraseña, Nombre, Apellidos) VALUES (@Email, @Password, @Nombre, @Apellido)"
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@Email", usuario.Email),
            New SqlParameter("@Password", usuario.Password),
            New SqlParameter("@Nombre", usuario.Nombre),
            New SqlParameter("@Apellido", usuario.Apellido)
        }
        Return helper.ExecuteNonQuery(sql, parameters)
    End Function
End Class