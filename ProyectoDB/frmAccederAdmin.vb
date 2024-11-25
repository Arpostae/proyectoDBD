Imports System.Data.SqlClient

Public Class Form4
    Dim conexionString As String = "server=DESKTOP-GR0BB9K\SQLEXPRESS; database=Restaurante; integrated security=true"
    Dim idRol As String
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtUsuario.Text.Trim <> "" And txtContrasenia.Text.Trim <> "" Then
            accesoAdmin(conexionString, txtUsuario.Text.Trim, txtContrasenia.Text.Trim, idRol)
            If idRol = "1" Then
                frmAdminMenu.Show()
                Me.Close()
            Else
                MessageBox.Show("Acceso denegado, usted no es administrador o ingreso mal usuario y/o contraseña", "Denegado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Form2.Show()
                Me.Close()

            End If
        Else
            MessageBox.Show("Llene todos los datos", "Datos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub
End Class