Imports System.Data.SqlClient

Public Class frmAdminMenu
    Dim conexion As New SqlConnection("server=DESKTOP-GR0BB9K\SQLEXPRESS; database=Restaurante; integrated security=true")
    Dim comando As New SqlCommand
    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub dgvMenu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMenu.CellContentClick

    End Sub

    Private Sub bttnComida_Click(sender As Object, e As EventArgs) Handles bttnComida.Click

        Try
            conexion.Open()
            LlenarGridAdmin(conexion, "Select * From Platos Where IdCategoria = 1", dgvMenu)
            conexion.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try


    End Sub

    Private Sub bttnRegresar_Click(sender As Object, e As EventArgs) Handles bttnRegresar.Click
        Form2.Show()
        Me.Close()
    End Sub
End Class