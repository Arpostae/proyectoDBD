<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminMenu))
        Me.bttnComida = New System.Windows.Forms.Button()
        Me.bttnBebidas = New System.Windows.Forms.Button()
        Me.bttnPostres = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvMenu = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblDetalle = New System.Windows.Forms.Label()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.bttnRegresar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'bttnComida
        '
        Me.bttnComida.Image = CType(resources.GetObject("bttnComida.Image"), System.Drawing.Image)
        Me.bttnComida.Location = New System.Drawing.Point(4, 4)
        Me.bttnComida.Margin = New System.Windows.Forms.Padding(4)
        Me.bttnComida.Name = "bttnComida"
        Me.bttnComida.Size = New System.Drawing.Size(103, 90)
        Me.bttnComida.TabIndex = 0
        Me.bttnComida.UseVisualStyleBackColor = True
        '
        'bttnBebidas
        '
        Me.bttnBebidas.Image = CType(resources.GetObject("bttnBebidas.Image"), System.Drawing.Image)
        Me.bttnBebidas.Location = New System.Drawing.Point(115, 4)
        Me.bttnBebidas.Margin = New System.Windows.Forms.Padding(4)
        Me.bttnBebidas.Name = "bttnBebidas"
        Me.bttnBebidas.Size = New System.Drawing.Size(103, 90)
        Me.bttnBebidas.TabIndex = 1
        Me.bttnBebidas.UseVisualStyleBackColor = True
        '
        'bttnPostres
        '
        Me.bttnPostres.Image = CType(resources.GetObject("bttnPostres.Image"), System.Drawing.Image)
        Me.bttnPostres.Location = New System.Drawing.Point(226, 4)
        Me.bttnPostres.Margin = New System.Windows.Forms.Padding(4)
        Me.bttnPostres.Name = "bttnPostres"
        Me.bttnPostres.Size = New System.Drawing.Size(103, 90)
        Me.bttnPostres.TabIndex = 2
        Me.bttnPostres.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.bttnComida, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.bttnPostres, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.bttnBebidas, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(336, 31)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(335, 98)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'dgvMenu
        '
        Me.dgvMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMenu.Location = New System.Drawing.Point(16, 241)
        Me.dgvMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvMenu.Name = "dgvMenu"
        Me.dgvMenu.RowHeadersWidth = 51
        Me.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMenu.Size = New System.Drawing.Size(983, 313)
        Me.dgvMenu.TabIndex = 4
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNuevo, Me.tsbGuardar, Me.tsbEliminar, Me.tsbCancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1015, 27)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbNuevo
        '
        Me.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbNuevo.Image = CType(resources.GetObject("tsbNuevo.Image"), System.Drawing.Image)
        Me.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNuevo.Name = "tsbNuevo"
        Me.tsbNuevo.Size = New System.Drawing.Size(29, 24)
        Me.tsbNuevo.Text = "Nuevo"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbGuardar.Image = CType(resources.GetObject("tsbGuardar.Image"), System.Drawing.Image)
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(29, 24)
        Me.tsbGuardar.Text = "Guardar"
        '
        'tsbEliminar
        '
        Me.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEliminar.Image = CType(resources.GetObject("tsbEliminar.Image"), System.Drawing.Image)
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(29, 24)
        Me.tsbEliminar.Text = "Eliminar"
        '
        'tsbCancelar
        '
        Me.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCancelar.Image = CType(resources.GetObject("tsbCancelar.Image"), System.Drawing.Image)
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(29, 24)
        Me.tsbCancelar.Text = "Cancelar"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22223!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22223!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtId, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblId, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblDetalle, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtDetalle, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtNombre, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtPrecio, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblNombre, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblPrecio, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(49, 154)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.40741!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.59259!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(925, 62)
        Me.TableLayoutPanel2.TabIndex = 6
        '
        'txtId
        '
        Me.txtId.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(4, 24)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(197, 22)
        Me.txtId.TabIndex = 7
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblId.Location = New System.Drawing.Point(4, 0)
        Me.lblId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(197, 20)
        Me.lblId.TabIndex = 7
        Me.lblId.Text = "Id"
        Me.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDetalle
        '
        Me.lblDetalle.AutoSize = True
        Me.lblDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDetalle.Location = New System.Drawing.Point(619, 0)
        Me.lblDetalle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(302, 20)
        Me.lblDetalle.TabIndex = 1
        Me.lblDetalle.Text = "Detalle"
        Me.lblDetalle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtDetalle
        '
        Me.txtDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDetalle.Location = New System.Drawing.Point(619, 24)
        Me.txtDetalle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(302, 22)
        Me.txtDetalle.TabIndex = 7
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(414, 24)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(196, 22)
        Me.txtNombre.TabIndex = 4
        '
        'txtPrecio
        '
        Me.txtPrecio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPrecio.Location = New System.Drawing.Point(209, 24)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(197, 22)
        Me.txtPrecio.TabIndex = 5
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNombre.Location = New System.Drawing.Point(414, 0)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(197, 20)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPrecio.Location = New System.Drawing.Point(209, 0)
        Me.lblPrecio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(197, 20)
        Me.lblPrecio.TabIndex = 2
        Me.lblPrecio.Text = "Precio"
        Me.lblPrecio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(847, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 16)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Regresar"
        '
        'bttnRegresar
        '
        Me.bttnRegresar.Image = CType(resources.GetObject("bttnRegresar.Image"), System.Drawing.Image)
        Me.bttnRegresar.Location = New System.Drawing.Point(827, 30)
        Me.bttnRegresar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bttnRegresar.Name = "bttnRegresar"
        Me.bttnRegresar.Size = New System.Drawing.Size(109, 96)
        Me.bttnRegresar.TabIndex = 24
        Me.bttnRegresar.UseVisualStyleBackColor = True
        '
        'frmAdminMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 554)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.bttnRegresar)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgvMenu)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAdminMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambios en Menú"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttnComida As Button
    Friend WithEvents bttnBebidas As Button
    Friend WithEvents bttnPostres As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dgvMenu As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbNuevo As ToolStripButton
    Friend WithEvents tsbGuardar As ToolStripButton
    Friend WithEvents tsbEliminar As ToolStripButton
    Friend WithEvents tsbCancelar As ToolStripButton
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblDetalle As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtDetalle As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents bttnRegresar As Button
End Class
