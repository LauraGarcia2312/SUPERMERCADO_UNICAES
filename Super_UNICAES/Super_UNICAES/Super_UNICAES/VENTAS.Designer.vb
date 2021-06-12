<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VENTAS
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
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPUnitario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lvVentas = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.agregarventabtm = New System.Windows.Forms.Button()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.buscarprodcventabtm = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.resStock = New System.Windows.Forms.Label()
        Me.resNombre = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.resCliente = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.MENU = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(142, 273)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(147, 23)
        Me.txtCantidad.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(49, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 24)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Cantidad:"
        '
        'txtPUnitario
        '
        Me.txtPUnitario.Location = New System.Drawing.Point(142, 230)
        Me.txtPUnitario.Name = "txtPUnitario"
        Me.txtPUnitario.Size = New System.Drawing.Size(147, 23)
        Me.txtPUnitario.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(49, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 24)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Precio:"
        '
        'lvVentas
        '
        Me.lvVentas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvVentas.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lvVentas.FullRowSelect = True
        Me.lvVentas.GridLines = True
        Me.lvVentas.HideSelection = False
        Me.lvVentas.Location = New System.Drawing.Point(375, 91)
        Me.lvVentas.Name = "lvVentas"
        Me.lvVentas.Size = New System.Drawing.Size(409, 376)
        Me.lvVentas.TabIndex = 39
        Me.lvVentas.UseCompatibleStateImageBehavior = False
        Me.lvVentas.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID producto"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Precio venta Unitario"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 170
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Cantidad"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 80
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(375, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 25)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "VENTAS"
        '
        'agregarventabtm
        '
        Me.agregarventabtm.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.agregarventabtm.Location = New System.Drawing.Point(491, 62)
        Me.agregarventabtm.Name = "agregarventabtm"
        Me.agregarventabtm.Size = New System.Drawing.Size(184, 23)
        Me.agregarventabtm.TabIndex = 37
        Me.agregarventabtm.Text = "COMPLETAR VENTA"
        Me.agregarventabtm.UseVisualStyleBackColor = True
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(142, 133)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(110, 23)
        Me.txtid.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(47, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 24)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "ID Producto:"
        '
        'buscarprodcventabtm
        '
        Me.buscarprodcventabtm.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.buscarprodcventabtm.Location = New System.Drawing.Point(275, 132)
        Me.buscarprodcventabtm.Name = "buscarprodcventabtm"
        Me.buscarprodcventabtm.Size = New System.Drawing.Size(75, 23)
        Me.buscarprodcventabtm.TabIndex = 34
        Me.buscarprodcventabtm.Text = "BUSCAR"
        Me.buscarprodcventabtm.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(140, 321)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 23)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "AGREGAR A LA LISTA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'resStock
        '
        Me.resStock.AutoSize = True
        Me.resStock.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.resStock.Location = New System.Drawing.Point(140, 190)
        Me.resStock.Name = "resStock"
        Me.resStock.Size = New System.Drawing.Size(45, 19)
        Me.resStock.TabIndex = 48
        Me.resStock.Text = "stock"
        '
        'resNombre
        '
        Me.resNombre.AutoSize = True
        Me.resNombre.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.resNombre.Location = New System.Drawing.Point(140, 162)
        Me.resNombre.Name = "resNombre"
        Me.resNombre.Size = New System.Drawing.Size(73, 19)
        Me.resNombre.TabIndex = 47
        Me.resNombre.Text = "producto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(47, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 24)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Stock:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(47, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 24)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Nombre:"
        '
        'resCliente
        '
        Me.resCliente.AutoSize = True
        Me.resCliente.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.resCliente.Location = New System.Drawing.Point(142, 70)
        Me.resCliente.Name = "resCliente"
        Me.resCliente.Size = New System.Drawing.Size(54, 19)
        Me.resCliente.TabIndex = 53
        Me.resCliente.Text = "cliente"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(49, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 24)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Nombre:"
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(144, 41)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(110, 23)
        Me.txtIdCliente.TabIndex = 51
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(49, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 24)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "ID Cliente:"
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBuscarCliente.Location = New System.Drawing.Point(277, 40)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarCliente.TabIndex = 49
        Me.btnBuscarCliente.Text = "BUSCAR"
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'MENU
        '
        Me.MENU.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MENU.Location = New System.Drawing.Point(634, 9)
        Me.MENU.Name = "MENU"
        Me.MENU.Size = New System.Drawing.Size(150, 35)
        Me.MENU.TabIndex = 54
        Me.MENU.Text = "VOLVER AL MENU"
        Me.MENU.UseVisualStyleBackColor = True
        '
        'VENTAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(864, 491)
        Me.Controls.Add(Me.MENU)
        Me.Controls.Add(Me.resCliente)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.resStock)
        Me.Controls.Add(Me.resNombre)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPUnitario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lvVentas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.agregarventabtm)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.buscarprodcventabtm)
        Me.Name = "VENTAS"
        Me.Text = "VENTAS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPUnitario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lvVentas As ListView
    Friend WithEvents Label4 As Label
    Friend WithEvents agregarventabtm As Button
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents buscarprodcventabtm As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Button1 As Button
    Friend WithEvents resStock As Label
    Friend WithEvents resNombre As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents resCliente As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents MENU As Button
End Class
