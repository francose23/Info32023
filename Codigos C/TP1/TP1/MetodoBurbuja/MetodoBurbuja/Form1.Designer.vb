<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MetodoBurbuja
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblVectorDesordenado = New System.Windows.Forms.Label()
        Me.dgVectorDesordenado = New System.Windows.Forms.DataGridView()
        Me.dgVectorOrdenado = New System.Windows.Forms.DataGridView()
        Me.lblVectorOrdenado = New System.Windows.Forms.Label()
        Me.btnOrdenar = New System.Windows.Forms.Button()
        CType(Me.dgVectorDesordenado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgVectorOrdenado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(79, 25)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(82, 13)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Método Burbuja"
        '
        'lblVectorDesordenado
        '
        Me.lblVectorDesordenado.AutoSize = True
        Me.lblVectorDesordenado.Location = New System.Drawing.Point(105, 69)
        Me.lblVectorDesordenado.Name = "lblVectorDesordenado"
        Me.lblVectorDesordenado.Size = New System.Drawing.Size(51, 13)
        Me.lblVectorDesordenado.TabIndex = 1
        Me.lblVectorDesordenado.Text = "Vector A:"
        '
        'dgVectorDesordenado
        '
        Me.dgVectorDesordenado.AllowUserToAddRows = False
        Me.dgVectorDesordenado.AllowUserToDeleteRows = False
        Me.dgVectorDesordenado.AllowUserToResizeColumns = False
        Me.dgVectorDesordenado.AllowUserToResizeRows = False
        Me.dgVectorDesordenado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgVectorDesordenado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVectorDesordenado.ColumnHeadersVisible = False
        Me.dgVectorDesordenado.Location = New System.Drawing.Point(82, 92)
        Me.dgVectorDesordenado.Name = "dgVectorDesordenado"
        Me.dgVectorDesordenado.ReadOnly = True
        Me.dgVectorDesordenado.RowHeadersVisible = False
        Me.dgVectorDesordenado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgVectorDesordenado.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgVectorDesordenado.ShowCellErrors = False
        Me.dgVectorDesordenado.ShowCellToolTips = False
        Me.dgVectorDesordenado.ShowEditingIcon = False
        Me.dgVectorDesordenado.ShowRowErrors = False
        Me.dgVectorDesordenado.Size = New System.Drawing.Size(323, 25)
        Me.dgVectorDesordenado.TabIndex = 2
        '
        'dgVectorOrdenado
        '
        Me.dgVectorOrdenado.AllowUserToAddRows = False
        Me.dgVectorOrdenado.AllowUserToDeleteRows = False
        Me.dgVectorOrdenado.AllowUserToResizeColumns = False
        Me.dgVectorOrdenado.AllowUserToResizeRows = False
        Me.dgVectorOrdenado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgVectorOrdenado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVectorOrdenado.ColumnHeadersVisible = False
        Me.dgVectorOrdenado.Location = New System.Drawing.Point(82, 251)
        Me.dgVectorOrdenado.Name = "dgVectorOrdenado"
        Me.dgVectorOrdenado.ReadOnly = True
        Me.dgVectorOrdenado.RowHeadersVisible = False
        Me.dgVectorOrdenado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgVectorOrdenado.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgVectorOrdenado.ShowCellErrors = False
        Me.dgVectorOrdenado.ShowCellToolTips = False
        Me.dgVectorOrdenado.ShowEditingIcon = False
        Me.dgVectorOrdenado.ShowRowErrors = False
        Me.dgVectorOrdenado.Size = New System.Drawing.Size(323, 25)
        Me.dgVectorOrdenado.TabIndex = 3
        '
        'lblVectorOrdenado
        '
        Me.lblVectorOrdenado.AutoSize = True
        Me.lblVectorOrdenado.Location = New System.Drawing.Point(105, 226)
        Me.lblVectorOrdenado.Name = "lblVectorOrdenado"
        Me.lblVectorOrdenado.Size = New System.Drawing.Size(99, 13)
        Me.lblVectorOrdenado.TabIndex = 4
        Me.lblVectorOrdenado.Text = "Vector A ordenado:"
        '
        'btnOrdenar
        '
        Me.btnOrdenar.Location = New System.Drawing.Point(108, 159)
        Me.btnOrdenar.Name = "btnOrdenar"
        Me.btnOrdenar.Size = New System.Drawing.Size(75, 23)
        Me.btnOrdenar.TabIndex = 5
        Me.btnOrdenar.Text = "Ordenar"
        Me.btnOrdenar.UseVisualStyleBackColor = True
        '
        'MetodoBurbuja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 354)
        Me.Controls.Add(Me.btnOrdenar)
        Me.Controls.Add(Me.lblVectorOrdenado)
        Me.Controls.Add(Me.dgVectorOrdenado)
        Me.Controls.Add(Me.dgVectorDesordenado)
        Me.Controls.Add(Me.lblVectorDesordenado)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "MetodoBurbuja"
        Me.Text = "Form1"
        CType(Me.dgVectorDesordenado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgVectorOrdenado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblVectorDesordenado As System.Windows.Forms.Label
    Friend WithEvents dgVectorDesordenado As System.Windows.Forms.DataGridView
    Friend WithEvents dgVectorOrdenado As System.Windows.Forms.DataGridView
    Friend WithEvents lblVectorOrdenado As System.Windows.Forms.Label
    Friend WithEvents btnOrdenar As System.Windows.Forms.Button

End Class
