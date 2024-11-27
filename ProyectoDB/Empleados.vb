Imports System.Data.SqlClient


Public Class btnEmpleados
    Dim conexion As New SqlConnection("server=ARATH; database=Restaurante; integrated security=true")
    Dim comando As New SqlCommand

    Private Sub CargarDatos()
        Try
            Dim consulta As String = "SELECT * FROM Empleados"
            Dim adaptador As New SqlDataAdapter(consulta, conexion)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)
            dgvDatos.DataSource = tabla
        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'llenaGrid(sqlConexion, "Select * From Empleados", dgvDatos)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'but.Enabled = True
        Try
            conexion.Open()

            If txtIdEmpleado.Text.Trim = "" Then
                ' Agregar un nuevo empleado
                Dim consulta As String = "INSERT INTO Empleados (Nombre, ApellidoPaterno, ApellidoMaterno, Telefono) VALUES (@Nombre, @ApellidoPaterno, @ApellidoMaterno, @Telefono)"
                comando = New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim)
                comando.Parameters.AddWithValue("@ApellidoPaterno", txtPrimerApellido.Text.Trim)
                comando.Parameters.AddWithValue("@ApellidoMaterno", txtSegundoApellido.Text.Trim)
                comando.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim)

                comando.ExecuteNonQuery()
                MessageBox.Show("Empleado agregado exitosamente.")
                CargarDatos()
            Else
                ' Modificar un empleado existente
                Dim consulta As String = "UPDATE Empleados SET Nombre = @Nombre, ApellidoPaterno = @ApellidoPaterno, ApellidoMaterno = @ApellidoMaterno, Telefono = @Telefono WHERE IdEmpleado = @IdEmpleado"
                comando = New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@IdEmpleado", txtIdEmpleado.Text.Trim)
                comando.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim)
                comando.Parameters.AddWithValue("@ApellidoPaterno", txtPrimerApellido.Text.Trim)
                comando.Parameters.AddWithValue("@ApellidoMaterno", txtSegundoApellido.Text.Trim)
                comando.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim)

                comando.ExecuteNonQuery()
                MessageBox.Show("Empleado modificado exitosamente.")
                CargarDatos()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Cerrar la conexión siempre, independientemente de si hubo un error o no
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
        'If txtIdEmpleado.Text.Trim = "" Then
        'sqlComando.CommandText = "Insert into Empleados Values ('" & txtIdEmpleado.Text.Trim & "','" & txtNombre.Text.Trim & "','" & txtPrimerApellido.Text.Trim & "','" & txtSegundoApellido.Text.Trim & "','" & txtTelefono.Text.Trim & "')"
        'Else
        'sqlComando.CommandText = "Update Empleados Set Modelo = ('" & txtNombre.Text.Trim & "','" & txtPrimerApellido.Text.Trim & "','" & txtSegundoApellido.Text.Trim & "','" & txtTelefono.Text.Trim & "')"
        ' End If
        'sqlComando.Connection = sqlConexion
        'sqlComando.ExecuteNonQuery()
        'MessageBox.Show("Registro almacenado exitosamente", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtPrimerApellido.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class