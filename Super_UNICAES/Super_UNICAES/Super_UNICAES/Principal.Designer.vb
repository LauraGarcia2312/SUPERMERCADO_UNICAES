<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.productosMENUbtm = New System.Windows.Forms.Button()
        Me.clientesMENUbtm = New System.Windows.Forms.Button()
        Me.VentasMENUbtm = New System.Windows.Forms.Button()
        Me.comprasMENUbtm = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'productosMENUbtm
        '
        Me.productosMENUbtm.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.productosMENUbtm.Image = CType(resources.GetObject("productosMENUbtm.Image"), System.Drawing.Image)
        Me.productosMENUbtm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.productosMENUbtm.Location = New System.Drawing.Point(153, 107)
        Me.productosMENUbtm.Name = "productosMENUbtm"
        Me.productosMENUbtm.Size = New System.Drawing.Size(239, 107)
        Me.productosMENUbtm.TabIndex = 0
        Me.productosMENUbtm.Text = "PRODUCTOS"
        Me.productosMENUbtm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.productosMENUbtm.UseVisualStyleBackColor = True
        '
        'clientesMENUbtm
        '
        Me.clientesMENUbtm.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.clientesMENUbtm.Image = CType(resources.GetObject("clientesMENUbtm.Image"), System.Drawing.Image)
        Me.clientesMENUbtm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.clientesMENUbtm.Location = New System.Drawing.Point(153, 254)
        Me.clientesMENUbtm.Name = "clientesMENUbtm"
        Me.clientesMENUbtm.Size = New System.Drawing.Size(239, 107)
        Me.clientesMENUbtm.TabIndex = 1
        Me.clientesMENUbtm.Text = "CLIENTES"
        Me.clientesMENUbtm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.clientesMENUbtm.UseVisualStyleBackColor = True
        '
        'VentasMENUbtm
        '
        Me.VentasMENUbtm.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.VentasMENUbtm.ForeColor = System.Drawing.Color.Black
        Me.VentasMENUbtm.Image = CType(resources.GetObject("VentasMENUbtm.Image"), System.Drawing.Image)
        Me.VentasMENUbtm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.VentasMENUbtm.Location = New System.Drawing.Point(483, 107)
        Me.VentasMENUbtm.Name = "VentasMENUbtm"
        Me.VentasMENUbtm.Size = New System.Drawing.Size(239, 107)
        Me.VentasMENUbtm.TabIndex = 2
        Me.VentasMENUbtm.Text = "VENTAS"
        Me.VentasMENUbtm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.VentasMENUbtm.UseVisualStyleBackColor = True
        '
        'comprasMENUbtm
        '
        Me.comprasMENUbtm.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.comprasMENUbtm.Image = CType(resources.GetObject("comprasMENUbtm.Image"), System.Drawing.Image)
        Me.comprasMENUbtm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.comprasMENUbtm.Location = New System.Drawing.Point(483, 254)
        Me.comprasMENUbtm.Name = "comprasMENUbtm"
        Me.comprasMENUbtm.Size = New System.Drawing.Size(239, 107)
        Me.comprasMENUbtm.TabIndex = 3
        Me.comprasMENUbtm.Text = "COMPRAS"
        Me.comprasMENUbtm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.comprasMENUbtm.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(390, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 45)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "MENU"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(864, 491)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comprasMENUbtm)
        Me.Controls.Add(Me.VentasMENUbtm)
        Me.Controls.Add(Me.clientesMENUbtm)
        Me.Controls.Add(Me.productosMENUbtm)
        Me.Name = "Principal"
        Me.Text = "Principal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents productosMENUbtm As Button
    Friend WithEvents clientesMENUbtm As Button
    Friend WithEvents VentasMENUbtm As Button
    Friend WithEvents comprasMENUbtm As Button
    Friend WithEvents Label1 As Label
End Class
