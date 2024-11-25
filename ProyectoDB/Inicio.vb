Public Class Inicio
    Public Property Usuario As String
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBienvenida.Text = "¡Bienvenido, '" & Usuario.ToString() & "'!"
    End Sub

    Private Sub btnMesas_Click(sender As Object, e As EventArgs) Handles btnMesas.Click

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles BtnConfig.Click

    End Sub

    Private Sub btnPlatillos_Click(sender As Object, e As EventArgs) Handles btnPlatillos.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles btnPedidos.Click

    End Sub
End Class