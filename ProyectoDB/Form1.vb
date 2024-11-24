'Imports System.Data.SqlClient
Imports System.Data.SqlClient

Public Class Form1

    Dim conexion As New SqlConnection
    Dim comando As New SqlCommand
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        conexion = New SqlConnection("server=LENOVODIEGO\SQLEXPRESS; database=Restaurante; integrated security=true")
        conexion.Open()

        Dim consulta As String = "select * from usuarios where nombre='" & txtUsuario.Text & "' and contraseña = '" & txtContrasenia.Text & "'"
        comando = New SqlCommand(consulta, conexion)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader

        If (lector.HasRows) Then
            Form2.Show()
            MessageBox.Show("Bienvenido, '" & txtUsuario.Text & "'")
            Me.Hide()
        Else
            MessageBox.Show("Usuario o Contraseña incorrecta, porfavor verifique")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'conexion = New SqlConnection("server=ARATH; database=Restaurante; integrated security=true")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtUsuario_TextChanged_1(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged
        If (txtUsuario.Text = "Usuario") Then
            txtUsuario.Text = ""
            txtUsuario.ForeColor = Color.BlueViolet
        End If

    End Sub

    Private Sub txtContrasenia_TextChanged(sender As Object, e As EventArgs) Handles txtContrasenia.TextChanged
        If (txtUsuario.Text = "Password") Then
            txtUsuario.Text = ""
            txtUsuario.ForeColor = Color.BlueViolet
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionString As String = "Server=DESKTOP-GR0BB9K\SQLEXPRESS;Database=Restaurante;Integrated Security=True;"

        ' Consulta de prueba
        Dim query As String = "SELECT TOP 1 * FROM Empleados"

        ' Conexión y comando
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                Try
                    connection.Open()
                    Dim reader As SqlDataReader = command.ExecuteReader()

                    ' Verificar si hay datos
                    If reader.HasRows Then
                        MessageBox.Show("Conexión establecida y datos encontrados.", "Prueba Exitosa")
                    Else
                        MessageBox.Show("Conexión establecida, pero no se encontraron datos.", "Prueba Exitosa")
                    End If

                Catch ex As Exception
                    MessageBox.Show($"Error: {ex.Message}", "Prueba Fallida")
                End Try
            End Using
        End Using
    End Sub
End Class
