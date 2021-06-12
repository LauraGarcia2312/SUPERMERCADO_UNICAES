<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class COMPRAS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.compraslistview = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.agregarcomprabtm = New System.Windows.Forms.Button()
        Me.Idproductocompratxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.buscarprodcomprabtm = New System.Windows.Forms.Button()
        Me.txtPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.resStock = New System.Windows.Forms.Label()
        Me.resNombre = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MENU = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'compraslistview
        '
        Me.compraslistview.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.compraslistview.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.compraslistview.FullRowSelect = True
        Me.compraslistview.GridLines = True
        Me.compraslistview.HideSelection = False
        Me.compraslistview.Location = New System.Drawing.Point(440, 121)
        Me.compraslistview.Name = "compraslistview"
        Me.compraslistview.Size = New System.Drawing.Size(322, 301)
        Me.compraslistview.TabIndex = 29
        Me.compraslistview.UseCompatibleStateImageBehavior = False
        Me.compraslistview.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID Producto"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Precio Unitario"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 125
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Cantidad"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 100
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(366, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 25)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "COMPRAS"
        '
        'agregarcomprabtm
        '
        Me.agregarcomprabtm.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.agregarcomprabtm.Location = New System.Drawing.Point(545, 78)
        Me.agregarcomprabtm.Name = "agregarcomprabtm"
        Me.agregarcomprabtm.Size = New System.Drawing.Size(116, 26)
        Me.agregarcomprabtm.TabIndex = 27
        Me.agregarcomprabtm.Text = "AGREGAR"
        Me.agregarcomprabtm.UseVisualStyleBackColor = True
        '
        'Idproductocompratxt
        '
        Me.Idproductocompratxt.Location = New System.Drawing.Point(195, 96)
        Me.Idproductocompratxt.Name = "Idproductocompratxt"
        Me.Idproductocompratxt.Size = New System.Drawing.Size(110, 23)
        Me.Idproductocompratxt.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(53, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 26)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "ID Producto:"
        '
        'buscarprodcomprabtm
        '
        Me.buscarprodcomprabtm.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.buscarprodcomprabtm.Location = New System.Drawing.Point(326, 98)
        Me.buscarprodcomprabtm.Name = "buscarprodcomprabtm"
        Me.buscarprodcomprabtm.Size = New System.Drawing.Size(91, 26)
        Me.buscarprodcomprabtm.TabIndex = 24
        Me.buscarprodcomprabtm.Text = "BUSCAR"
        Me.buscarprodcomprabtm.UseVisualStyleBackColor = True
        '
        'txtPrecioUnitario
        '
        Me.txtPrecioUnitario.Location = New System.Drawing.Point(195, 224)
        Me.txtPrecioUnitario.Name = "txtPrecioUnitario"
        Me.txtPrecioUnitario.Size = New System.Drawing.Size(132, 23)
        Me.txtPrecioUnitario.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(53, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 26)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Precio Unitario:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(195, 275)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(132, 23)
        Me.txtCantidad.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(53, 275)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 26)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Cantidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(53, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 26)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Nombre:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(53, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 26)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Stock:"
        '
        'resStock
        '
        Me.resStock.AutoSize = True
        Me.resStock.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.resStock.Location = New System.Drawing.Point(130, 166)
        Me.resStock.Name = "resStock"
        Me.resStock.Size = New System.Drawing.Size(52, 22)
        Me.resStock.TabIndex = 37
        Me.resStock.Text = "stock"
        '
        'resNombre
        '
        Me.resNombre.AutoSize = True
        Me.resNombre.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.resNombre.Location = New System.Drawing.Point(130, 138)
        Me.resNombre.Name = "resNombre"
        Me.resNombre.Size = New System.Drawing.Size(85, 22)
        Me.resNombre.TabIndex = 36
        Me.resNombre.Text = "producto"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(184, 316)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 30)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "AGREGAR A LA LISTA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MENU
        '
        Me.MENU.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MENU.Location = New System.Drawing.Point(612, 12)
        Me.MENU.Name = "MENU"
        Me.MENU.Size = New System.Drawing.Size(150, 35)
        Me.MENU.TabIndex = 39
        Me.MENU.Text = "VOLVER AL MENU"
        Me.MENU.UseVisualStyleBackColor = True
        '
        'COMPRAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(864, 491)
        Me.Controls.Add(Me.MENU)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.resStock)
        Me.Controls.Add(Me.resNombre)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPrecioUnitario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.compraslistview)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.agregarcomprabtm)
        Me.Controls.Add(Me.Idproductocompratxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.buscarprodcomprabtm)
        Me.Name = "COMPRAS"
        Me.Text = "t"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents compraslistview As ListView
    Friend WithEvents Label4 As Label
    Friend WithEvents agregarcomprabtm As Button
    Friend WithEvents Idproductocompratxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents buscarprodcomprabtm As Button
    Friend WithEvents txtPrecioUnitario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents resStock As Label
    Friend WithEvents resNombre As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents MENU As Button
End Class
