Imports System.Data.SqlClient
Imports System.Linq.Expressions

Public Class Inicio
    Public Property Usuario As String
    Public Property Contrasenia As String
    Private idRol As String
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBienvenida.Text = "¡Bienvenido, '" & Usuario.ToString() & "'!"
        TabControl1.TabPages.Remove(tbModMenu)
        TabControl1.TabPages.Remove(tbModEmpleados)
    End Sub

    Private Sub btnMesas_Click(sender As Object, e As EventArgs) Handles btnMesas.Click
        'Dim ventana As New 
        TabControl.SelectedTab = Mesas
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles BtnConfig.Click
        If Usuario <> "" And Contrasenia <> "" Then
            accesoAdmin(conexion, Usuario.Trim, Contrasenia.Trim, idRol)
        End If

        If idRol = "1" Then
            MessageBox.Show("Usted es admnistrador", "Acceso Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TabControl1.TabPages.Add(tbModMenu)
            TabControl1.TabPages.Add(tbModEmpleados)
        Else
            MessageBox.Show("Usted no es administrador", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnPlatillos_Click(sender As Object, e As EventArgs) Handles btnPlatillos.Click
        TabControl.SelectedTab = Platillos
        Dim conexion As New SqlConnection("server=DESKTOP-GR0BB9K\SQLEXPRESS; database=Restaurante; integrated security=true")
        Dim comando As New SqlCommand
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles btnPedidos.Click
        TabControl.SelectedTab = Pedidos
    End Sub




    ' Funciones Tab ModMenu
    Dim conexion As New SqlConnection("server=DESKTOP-GR0BB9K\SQLEXPRESS; database=Restaurante; integrated security=true")
    Dim comando As New SqlCommand

    Private Sub dgvMenu_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMenu.CellContentClick
        If dgvMenu.CurrentRow.Cells(0).Value.ToString().Trim <> "" Then
            txtId.Text = dgvMenu.CurrentRow.Cells(0).Value.ToString
            txtPrecio.Text = dgvMenu.CurrentRow.Cells(1).Value.ToString
            txtNombre.Text = dgvMenu.CurrentRow.Cells(2).Value.ToString
            txtDetalle.Text = dgvMenu.CurrentRow.Cells(3).Value.ToString
            cmbCategoria.SelectedIndex = dgvMenu.CurrentRow.Cells(4).Value - 1

            txtPrecio.Enabled = True
            txtNombre.Enabled = True
            txtDetalle.Enabled = True
            cmbCategoria.Enabled = True
            tsbGuardar.Enabled = True
            tsbEliminar.Enabled = True
        End If
    End Sub

    Private Sub bttnComida_Click_1(sender As Object, e As EventArgs) Handles bttnComida.Click
        Try
            conexion.Open()
            LlenarGridAdmin(conexion, "Select * From Platos Where IdCategoria = 1", dgvMenu)
            conexion.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub bttnBebidas_Click_1(sender As Object, e As EventArgs) Handles bttnBebidas.Click
        Try
            conexion.Open()
            LlenarGridAdmin(conexion, "Select * From Platos Where IdCategoria = 2", dgvMenu)
            conexion.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub bttnPostres_Click(sender As Object, e As EventArgs) Handles bttnPostres.Click
        Try
            conexion.Open()
            LlenarGridAdmin(conexion, "Select * From Platos Where IdCategoria = 3", dgvMenu)
            conexion.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub tsbNuevo_Click_1(sender As Object, e As EventArgs) Handles tsbNuevo.Click
        tsbNuevo.Enabled = False
        tsbGuardar.Enabled = True
        tsbEliminar.Enabled = True
        txtPrecio.Enabled = True
        txtNombre.Enabled = True
        txtDetalle.Enabled = True
        cmbCategoria.Enabled = True

        txtPrecio.Focus()
    End Sub

    Private Sub tsbGuardar_Click_1(sender As Object, e As EventArgs) Handles tsbGuardar.Click
        If txtId.Text.Trim = "" And txtPrecio.Text.Trim <> "" And txtNombre.Text.Trim <> "" And txtDetalle.Text.Trim <> "" And cmbCategoria.SelectedIndex <> -1 Then
            Try
                conexion.Open()
                Dim sqlCon As New SqlCommand
                sqlCon.CommandText = "Insert into Platos values (" & txtPrecio.Text.Trim & ",'" & txtNombre.Text.Trim & "','" & txtDetalle.Text.Trim & "'," & cmbCategoria.SelectedIndex + 1 & ")"
                sqlCon.Connection = conexion
                sqlCon.ExecuteReader()
                MessageBox.Show("Se han ingresado los datos con exito", "Exitoso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}")
            End Try
        ElseIf txtId.Text.Trim <> "" Then
            Try
                conexion.Open()
                Dim sqlCon As New SqlCommand
                sqlCon.CommandText = "Update Platos Set Precio = " & txtPrecio.Text.Trim & ", Nombre = '" & txtNombre.Text.Trim & "',Descripcion = '" & txtDetalle.Text.Trim & "', IdCategoria = " & cmbCategoria.SelectedIndex + 1 & " Where IdPlato = " & txtId.Text.Trim
                sqlCon.Connection = conexion
                sqlCon.ExecuteReader()
                txtId.Text = ""
                txtPrecio.Text = ""
                txtNombre.Text = ""
                txtDetalle.Text = ""

                MessageBox.Show("Se han actualizado los datos con exito", "Exitoso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}")
            End Try
        End If
        conexion.Close()
    End Sub

    Private Sub tsbEliminar_Click_1(sender As Object, e As EventArgs) Handles tsbEliminar.Click
        If MessageBox.Show("¿Seguro que desea eliminar el dato seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                conexion.Open()
                Dim sqlCon As New SqlCommand
                sqlCon.CommandText = "Delete From Platos Where IdPlato = " & txtId.Text.Trim
                sqlCon.Connection = conexion
                sqlCon.ExecuteNonQuery()
                MessageBox.Show("Se han borrado los datos con exito", "Exitoso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}")
            End Try

        End If
        conexion.Close()
    End Sub

    Private Sub tsbCancelar_Click_1(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        txtId.Text = ""
        txtPrecio.Text = ""
        txtNombre.Text = ""
        txtDetalle.Text = ""
        cmbCategoria.SelectedIndex = -1

        tsbNuevo.Enabled = True
        tsbGuardar.Enabled = False
        tsbEliminar.Enabled = False
        txtPrecio.Enabled = False
        txtNombre.Enabled = False
        txtDetalle.Enabled = False
        cmbCategoria.Enabled = False

        dgvMenu.Columns.Clear()

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

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

    'ModEmpleados
    Private Sub CargarDatos()
        Try
            Dim consulta As String = "SELECT * FROM Empleados order by IdEmpleado asc"
            Dim adaptador As New SqlDataAdapter(consulta, conexion)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)
            dgvDatos.DataSource = tabla
        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message)
        End Try
    End Sub


    Private Sub dgvDatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellContentClick

    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        CargarDatos()

        TextBox1.Enabled = True
        txtNombre.Enabled = True
        txtPrimerApellido.Enabled = True
        txtSegundoApellido.Enabled = True
        txtTelefono.Enabled = True
        btnAgregar.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            conexion.Open()
            Dim consulta As String = "INSERT INTO Empleados (Nombre, ApellidoPaterno, ApellidoMaterno, Telefono) VALUES (@Nombre, @ApellidoPaterno, @ApellidoMaterno, @Telefono)"
            comando = New SqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim)
            comando.Parameters.AddWithValue("@ApellidoPaterno", txtPrimerApellido.Text.Trim)
            comando.Parameters.AddWithValue("@ApellidoMaterno", txtSegundoApellido.Text.Trim)
            comando.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim)

            comando.ExecuteNonQuery()
            MessageBox.Show("Empleado agregado exitosamente.")
            CargarDatos()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        txtIdEmpleado.Enabled = True
        btnAgregar.Enabled = False
        btnEliminar.Enabled = False
        Try

            If String.IsNullOrEmpty(txtIdEmpleado.Text.Trim) Then
                MessageBox.Show("Por favor, selecciona un empleado para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            conexion.Open()

            Dim consulta As String = "UPDATE Empleados SET Nombre = @Nombre, ApellidoPaterno = @ApellidoPaterno, ApellidoMaterno = @ApellidoMaterno, Telefono = @Telefono WHERE IdEmpleado = @IdEmpleado"
            Dim comando As New SqlCommand(consulta, conexion)

            comando.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim)
            comando.Parameters.AddWithValue("@ApellidoPaterno", txtPrimerApellido.Text.Trim)
            comando.Parameters.AddWithValue("@ApellidoMaterno", txtSegundoApellido.Text.Trim)
            comando.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim)
            comando.Parameters.AddWithValue("@IdEmpleado", txtIdEmpleado.Text.Trim)

            Dim filasAfectadas As Integer = comando.ExecuteNonQuery()

            If filasAfectadas > 0 Then
                MessageBox.Show("Empleado modificado exitosamente.")
                txtIdEmpleado.Enabled = False
                btnEliminar.Enabled = True
                btnAgregar.Enabled = True
                limpiarPantalla()
                CargarDatos()
            Else
                MessageBox.Show("No se encontró un empleado con ese ID.")
                txtIdEmpleado.Enabled = False
                btnEliminar.Enabled = True
                btnAgregar.Enabled = True
                limpiarPantalla()
            End If

        Catch ex As Exception
            MessageBox.Show("Error al modificar empleado: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub

    Sub limpiarPantalla()
        txtIdEmpleado.Clear()
        txtNombre.Clear()
        txtPrimerApellido.Clear()
        txtSegundoApellido.Clear()
        txtTelefono.Clear()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If String.IsNullOrEmpty(txtIdEmpleado.Text.Trim) Then
                MessageBox.Show("Por favor, selecciona un empleado para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtIdEmpleado.Enabled = True
                txtNombre.Enabled = False
                txtPrimerApellido.Enabled = False
                txtSegundoApellido.Enabled = False
                txtTelefono.Enabled = False
                btnAgregar.Enabled = False
                btnModificar.Enabled = False
                Return
            End If

            If MessageBox.Show("¿Seguro que desea eliminar este empleado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                conexion.Open()

                Dim consulta As String = "DELETE FROM Empleados WHERE IdEmpleado = @IdEmpleado"
                Dim comando As New SqlCommand(consulta, conexion)

                comando.Parameters.AddWithValue("@IdEmpleado", txtIdEmpleado.Text.Trim)

                Dim filasAfectadas As Integer = comando.ExecuteNonQuery()

                If filasAfectadas > 0 Then
                    MessageBox.Show("Empleado eliminado exitosamente.")
                    txtIdEmpleado.Enabled = False
                    btnModificar.Enabled = True
                    btnAgregar.Enabled = True
                    limpiarPantalla()
                    CargarDatos()
                Else
                    MessageBox.Show("No se encontró un empleado con ese ID.")
                    txtIdEmpleado.Enabled = False
                    txtNombre.Enabled = True
                    txtPrimerApellido.Enabled = True
                    txtSegundoApellido.Enabled = True
                    txtTelefono.Enabled = True
                    btnModificar.Enabled = True
                    btnAgregar.Enabled = True
                    limpiarPantalla()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error al eliminar empleado: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try

    End Sub

    Private Sub txtTelefono_TextChanged(sender As Object, e As EventArgs) Handles txtTelefono.TextChanged

    End Sub

    Private Sub tbModEmpleados_Click(sender As Object, e As EventArgs) Handles tbModEmpleados.Click

    End Sub

    Private Sub dgvDatos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatos.CellContentDoubleClick
        If dgvDatos.CurrentRow.Cells(0).Value.ToString().Trim <> "" Then
            txtIdEmpleado.Text = dgvDatos.CurrentRow.Cells(0).Value.ToString
            TextBox1.Text = dgvDatos.CurrentRow.Cells(1).Value.ToString
            txtPrimerApellido.Text = dgvDatos.CurrentRow.Cells(2).Value.ToString
            txtSegundoApellido.Text = dgvDatos.CurrentRow.Cells(3).Value.ToString
            txtTelefono.Text = dgvDatos.CurrentRow.Cells(7).Value.ToString

            TextBox1.Enabled = True
            txtNombre.Enabled = True
            txtPrimerApellido.Enabled = True
            txtSegundoApellido.Enabled = True
            txtTelefono.Enabled = True
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim ventana As New Form1
        ventana.Show()
        Me.Hide()
    End Sub

    Private Sub btnMesa1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles btnMesa1.Click
        'Dim ventas As New 
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
End Class