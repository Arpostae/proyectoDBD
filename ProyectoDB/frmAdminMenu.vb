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

    Private Sub bttnBebidas_Click(sender As Object, e As EventArgs) Handles bttnBebidas.Click
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

    Private Sub tsbNuevo_Click(sender As Object, e As EventArgs) Handles tsbNuevo.Click
        tsbNuevo.Enabled = False
        tsbGuardar.Enabled = True
        tsbEliminar.Enabled = True
        txtPrecio.Enabled = True
        txtNombre.Enabled = True
        txtDetalle.Enabled = True
        cmbCategoria.Enabled = True

        txtPrecio.Focus()
    End Sub



    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged


    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click
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
                MessageBox.Show("Se han actualizado los datos con exito", "Exitoso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}")
            End Try
        End If
        conexion.Close()
    End Sub

    Private Sub dgvMenu_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMenu.CellContentDoubleClick
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

    Private Sub tsbEliminar_Click(sender As Object, e As EventArgs) Handles tsbEliminar.Click
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

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
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
End Class