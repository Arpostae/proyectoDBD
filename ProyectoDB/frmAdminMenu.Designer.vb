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
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bttnComida
        '
        Me.bttnComida.Image = CType(resources.GetObject("bttnComida.Image"), System.Drawing.Image)
        Me.bttnComida.Location = New System.Drawing.Point(3, 3)
        Me.bttnComida.Name = "bttnComida"
        Me.bttnComida.Size = New System.Drawing.Size(76, 75)
        Me.bttnComida.TabIndex = 0
        Me.bttnComida.UseVisualStyleBackColor = True
        '
        'bttnBebidas
        '
        Me.bttnBebidas.Image = CType(resources.GetObject("bttnBebidas.Image"), System.Drawing.Image)
        Me.bttnBebidas.Location = New System.Drawing.Point(85, 3)
        Me.bttnBebidas.Name = "bttnBebidas"
        Me.bttnBebidas.Size = New System.Drawing.Size(76, 75)
        Me.bttnBebidas.TabIndex = 1
        Me.bttnBebidas.UseVisualStyleBackColor = True
        '
        'bttnPostres
        '
        Me.bttnPostres.Image = CType(resources.GetObject("bttnPostres.Image"), System.Drawing.Image)
        Me.bttnPostres.Location = New System.Drawing.Point(167, 3)
        Me.bttnPostres.Name = "bttnPostres"
        Me.bttnPostres.Size = New System.Drawing.Size(77, 75)
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(248, 83)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'frmAdminMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmAdminMenu"
        Me.Text = "frmAdminMenu"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bttnComida As Button
    Friend WithEvents bttnBebidas As Button
    Friend WithEvents bttnPostres As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
