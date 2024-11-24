<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPedidos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPedidos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPostres = New System.Windows.Forms.Button()
        Me.btnBebidas = New System.Windows.Forms.Button()
        Me.btnPlatillos = New System.Windows.Forms.Button()
        Me.btnEntradas = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvPedidos = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblTrabajar = New System.Windows.Forms.Label()
        Me.dgvMostrarComida = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrecioTotal = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Agregar = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvMostrarComida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agregar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnPostres)
        Me.Panel1.Controls.Add(Me.btnBebidas)
        Me.Panel1.Controls.Add(Me.btnPlatillos)
        Me.Panel1.Controls.Add(Me.btnEntradas)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(4, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(271, 542)
        Me.Panel1.TabIndex = 0
        '
        'btnPostres
        '
        Me.btnPostres.Location = New System.Drawing.Point(17, 429)
        Me.btnPostres.Name = "btnPostres"
        Me.btnPostres.Size = New System.Drawing.Size(237, 77)
        Me.btnPostres.TabIndex = 5
        Me.btnPostres.Text = "Postres"
        Me.btnPostres.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPostres.UseVisualStyleBackColor = True
        '
        'btnBebidas
        '
        Me.btnBebidas.Location = New System.Drawing.Point(17, 332)
        Me.btnBebidas.Name = "btnBebidas"
        Me.btnBebidas.Size = New System.Drawing.Size(237, 77)
        Me.btnBebidas.TabIndex = 4
        Me.btnBebidas.Text = "Bebidas"
        Me.btnBebidas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBebidas.UseVisualStyleBackColor = True
        '
        'btnPlatillos
        '
        Me.btnPlatillos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlatillos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPlatillos.Location = New System.Drawing.Point(17, 233)
        Me.btnPlatillos.Name = "btnPlatillos"
        Me.btnPlatillos.Size = New System.Drawing.Size(237, 77)
        Me.btnPlatillos.TabIndex = 3
        Me.btnPlatillos.Text = "Platillos"
        Me.btnPlatillos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPlatillos.UseVisualStyleBackColor = True
        '
        'btnEntradas
        '
        Me.btnEntradas.Location = New System.Drawing.Point(20, 137)
        Me.btnEntradas.Name = "btnEntradas"
        Me.btnEntradas.Size = New System.Drawing.Size(237, 77)
        Me.btnEntradas.TabIndex = 2
        Me.btnEntradas.Text = "Entradas"
        Me.btnEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEntradas.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Wheat
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(93, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 50)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FOOD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Wheat
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "THAI "
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtPrecioTotal)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.dgvPedidos)
        Me.Panel3.Location = New System.Drawing.Point(984, 28)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(509, 489)
        Me.Panel3.TabIndex = 1
        '
        'dgvPedidos
        '
        Me.dgvPedidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedidos.Location = New System.Drawing.Point(3, 37)
        Me.dgvPedidos.Name = "dgvPedidos"
        Me.dgvPedidos.RowHeadersWidth = 51
        Me.dgvPedidos.RowTemplate.Height = 24
        Me.dgvPedidos.Size = New System.Drawing.Size(503, 377)
        Me.dgvPedidos.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(235, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Pedido"
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.Location = New System.Drawing.Point(831, 205)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(177, 23)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFinalizar.Location = New System.Drawing.Point(831, 259)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(177, 23)
        Me.btnFinalizar.TabIndex = 4
        Me.btnFinalizar.Text = "Finalizar Compra"
        Me.btnFinalizar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Agregar)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.lblTrabajar)
        Me.Panel2.Controls.Add(Me.dgvMostrarComida)
        Me.Panel2.Location = New System.Drawing.Point(344, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(509, 489)
        Me.Panel2.TabIndex = 5
        '
        'lblTrabajar
        '
        Me.lblTrabajar.AutoSize = True
        Me.lblTrabajar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrabajar.Location = New System.Drawing.Point(23, 14)
        Me.lblTrabajar.Name = "lblTrabajar"
        Me.lblTrabajar.Size = New System.Drawing.Size(109, 16)
        Me.lblTrabajar.TabIndex = 1
        Me.lblTrabajar.Text = "TURIKITAKATI"
        '
        'dgvMostrarComida
        '
        Me.dgvMostrarComida.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMostrarComida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMostrarComida.Location = New System.Drawing.Point(3, 100)
        Me.dgvMostrarComida.Name = "dgvMostrarComida"
        Me.dgvMostrarComida.RowHeadersWidth = 51
        Me.dgvMostrarComida.RowTemplate.Height = 24
        Me.dgvMostrarComida.Size = New System.Drawing.Size(503, 377)
        Me.dgvMostrarComida.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(158, 442)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Total: "
        '
        'txtPrecioTotal
        '
        Me.txtPrecioTotal.Location = New System.Drawing.Point(208, 439)
        Me.txtPrecioTotal.Name = "txtPrecioTotal"
        Me.txtPrecioTotal.Size = New System.Drawing.Size(184, 22)
        Me.txtPrecioTotal.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(159, 51)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(173, 22)
        Me.TextBox1.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Buscar patillo:"
        '
        'Agregar
        '
        Me.Agregar.Image = CType(resources.GetObject("Agregar.Image"), System.Drawing.Image)
        Me.Agregar.Location = New System.Drawing.Point(363, 37)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(53, 50)
        Me.Agregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Agregar.TabIndex = 6
        Me.Agregar.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(437, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'FrmPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1505, 529)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmPedidos"
        Me.Text = "FrmPedidos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvMostrarComida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agregar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnEntradas As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPostres As Button
    Friend WithEvents btnBebidas As Button
    Friend WithEvents btnPlatillos As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgvPedidos As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents btnFinalizar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents txtPrecioTotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTrabajar As Label
    Friend WithEvents dgvMostrarComida As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Agregar As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
