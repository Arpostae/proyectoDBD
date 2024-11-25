Public Class Inicio
    Public Property Usuario As String
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBienvenida.Text = "¡Bienvenido, '" & Usuario.ToString() & "'!"
        Dim cantidadMesas As Integer = 10 'OJO CAMBIAR POR LA CONSULTA A LA BASE DE DATOS

        Dim xPos As Integer = 10
        Dim yPos As Integer = 10

        ' Crear los PictureBox para las mesas
        For i As Integer = 1 To cantidadMesas
            Dim picMesa As New PictureBox()
            picMesa.Name = "PicMesa" & i ' Asignar un nombre único para cada mesa
            picMesa.Size = New Size(100, 100)
            picMesa.Location = New Point(xPos, yPos) ' Ubicación del PictureBox
            'picMesa.BackColor = Color.LightGray ' Color de fondo para el PictureBox (puedes asignar una imagen también)
            'picMesa.Image = My.Resources.MesaImage ' Asignar la imagen de la mesa (opcional)
            picMesa.SizeMode = PictureBoxSizeMode.StretchImage ' Ajustar imagen si es necesario

            ' Asignar un identificador único para cada PictureBox
            picMesa.Tag = i ' Guardamos el número de la mesa como "Tag"

            ' Agregar el evento de clic
            'AddHandler picMesa.Click, AddressOf Mesa_Click

            ' Agregar el PictureBox al TabPage
            'TabPage.Controls.Add(picMesa)

            ' Ajustar la posición para el siguiente PictureBox
            yPos += 110 ' Puedes cambiar este valor para ajustar el espacio entre botones
            'If yPos > TabPage.Height - 120 Then
            yPos = 10
                xPos += 120 ' Ajustar si se pasan a la siguiente columna
            'End If
        Next

    End Sub

    Private Sub btnMesas_Click(sender As Object, e As EventArgs) Handles btnMesas.Click
        TabControl.SelectedTab = TabControl.TabPages("Mesas")


    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles BtnConfig.Click

    End Sub

    Private Sub btnPlatillos_Click(sender As Object, e As EventArgs) Handles btnPlatillos.Click
        TabControl.SelectedTab = TabControl.TabPages("Platillos")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles btnPedidos.Click
        TabControl.SelectedTab = TabControl.TabPages("Pedidos")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim ventana As New Form1
        Me.Hide()
        ventana.Show()
    End Sub

    Private Sub btnMesa1_Click(sender As Object, e As EventArgs) Handles btnMesa1.Click

    End Sub
End Class