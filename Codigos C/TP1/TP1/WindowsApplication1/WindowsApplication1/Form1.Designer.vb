<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MetodoSeleccion
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
        Me.lblVectorA = New System.Windows.Forms.Label()
        Me.lblVectorOrdenado = New System.Windows.Forms.Label()
        Me.dgVector = New System.Windows.Forms.DataGridView()
        Me.dgVectorOrdenado = New System.Windows.Forms.DataGridView()
        Me.btnOrdenar = New System.Windows.Forms.Button()
        CType(Me.dgVector, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgVectorOrdenado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(59, 40)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(108, 13)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Método de Selección"
        '
        'lblVectorA
        '
        Me.lblVectorA.AutoSize = True
        Me.lblVectorA.Location = New System.Drawing.Point(44, 85)
        Me.lblVectorA.Name = "lblVectorA"
        Me.lblVectorA.Size = New System.Drawing.Size(51, 13)
        Me.lblVectorA.TabIndex = 1
        Me.lblVectorA.Text = "Vector A:"
        '
        'lblVectorOrdenado
        '
        Me.lblVectorOrdenado.AutoSize = True
        Me.lblVectorOrdenado.Location = New System.Drawing.Point(44, 230)
        Me.lblVectorOrdenado.Name = "lblVectorOrdenado"
        Me.lblVectorOrdenado.Size = New System.Drawing.Size(101, 13)
        Me.lblVectorOrdenado.TabIndex = 2
        Me.lblVectorOrdenado.Text = "Vector A Ordenado:"
        '
        'dgVector
        '
        Me.dgVector.AllowUserToAddRows = False
        Me.dgVector.AllowUserToDeleteRows = False
        Me.dgVector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVector.ColumnHeadersVisible = False
        Me.dgVector.Location = New System.Drawing.Point(47, 111)
        Me.dgVector.Name = "dgVector"
        Me.dgVector.ReadOnly = True
        Me.dgVector.RowHeadersVisible = False
        Me.dgVector.Size = New System.Drawing.Size(323, 25)
        Me.dgVector.TabIndex = 3
        '
        'dgVectorOrdenado
        '
        Me.dgVectorOrdenado.AllowUserToAddRows = False
        Me.dgVectorOrdenado.AllowUserToDeleteRows = False
        Me.dgVectorOrdenado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVectorOrdenado.ColumnHeadersVisible = False
        Me.dgVectorOrdenado.Location = New System.Drawing.Point(47, 261)
        Me.dgVectorOrdenado.Name = "dgVectorOrdenado"
        Me.dgVectorOrdenado.ReadOnly = True
        Me.dgVectorOrdenado.RowHeadersVisible = False
        Me.dgVectorOrdenado.Size = New System.Drawing.Size(323, 25)
        Me.dgVectorOrdenado.TabIndex = 4
        '
        'btnOrdenar
        '
        Me.btnOrdenar.Location = New System.Drawing.Point(167, 179)
        Me.btnOrdenar.Name = "btnOrdenar"
        Me.btnOrdenar.Size = New System.Drawing.Size(75, 23)
        Me.btnOrdenar.TabIndex = 5
        Me.btnOrdenar.Text = "Ordenar"
        Me.btnOrdenar.UseVisualStyleBackColor = True
        '
        'MetodoSeleccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 358)
        Me.Controls.Add(Me.btnOrdenar)
        Me.Controls.Add(Me.dgVectorOrdenado)
        Me.Controls.Add(Me.dgVector)
        Me.Controls.Add(Me.lblVectorOrdenado)
        Me.Controls.Add(Me.lblVectorA)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "MetodoSeleccion"
        Me.Text = "Método de Selección"
        CType(Me.dgVector, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgVectorOrdenado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblVectorA As System.Windows.Forms.Label
    Friend WithEvents lblVectorOrdenado As System.Windows.Forms.Label
    Friend WithEvents dgVector As System.Windows.Forms.DataGridView
    Friend WithEvents dgVectorOrdenado As System.Windows.Forms.DataGridView
    Friend WithEvents btnOrdenar As System.Windows.Forms.Button

End Class
