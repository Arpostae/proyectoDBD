Imports System.Data.SqlClient

Module Module1
    Sub Main()
        ' Cadena de conexión
        Dim connectionString As String = "Server=DESKTOP-GR0BB9K\SQLEXPRESS;Database=Restaurante;Integrated Security=True;"
        ' Dim connectionString As String = "Server=ARATH;Database=Restaurante;Integrated Security=True;"

        ' Objeto de conexión
        Using connection As New SqlConnection(connectionString)
            Try
                ' Abrir conexión
                connection.Open()
                Console.WriteLine("Conexión exitosa.")

                ' Crear un comando SQL
                Dim query As String = "SELECT * FROM Usuarios"
                Dim command As New SqlCommand(query, connection)

                ' Leer los datos
                Dim reader As SqlDataReader = command.ExecuteReader()
                While reader.Read()
                    Console.WriteLine($"ID: {reader("ID")}, Nombre: {reader("Nombre")}")
                End While

            Catch ex As Exception
                Console.WriteLine($"Error: {ex.Message}")
            End Try
        End Using

        ' Mantener consola abierta
        Console.ReadLine()
    End Sub

    Sub LlenarGridAdmin(sqlCon As SqlConnection, query As String, ByRef dgvMenu As DataGridView)
        Dim adaptador As New SqlDataAdapter(query, sqlCon)
        Dim tabla As New DataTable()
        adaptador.Fill(tabla)
        dgvMenu.DataSource = tabla

    End Sub

    Sub accesoAdmin(conexion As SqlConnection, usuario As String, password As String, ByRef idRol As String)
        Try
            conexion.Open()
            Dim query As String = "Select IdRol From Empleados Where Usuario = '" & usuario & "' and Contraseña = '" & password & "'"
            Dim command As New SqlCommand(query, conexion)
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                idRol = reader(0).ToString()
            End If
            conexion.Close()

        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub
End Module