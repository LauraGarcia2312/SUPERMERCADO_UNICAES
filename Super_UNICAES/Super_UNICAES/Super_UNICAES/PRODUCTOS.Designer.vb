<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRODUCTOS
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
        Me.precioventaprodtxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.productoslistview = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.eliminarprodbtm = New System.Windows.Forms.Button()
        Me.actualizarprodbtm = New System.Windows.Forms.Button()
        Me.registrarprodbtm = New System.Windows.Forms.Button()
        Me.Categoriaprodtxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nombreprodtxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Idproductoprodtxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.buscarprodbtm = New System.Windows.Forms.Button()
        Me.refrescarbtm = New System.Windows.Forms.Button()
        Me.MENU = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'precioventaprodtxt
        '
        Me.precioventaprodtxt.Location = New System.Drawing.Point(482, 101)
        Me.precioventaprodtxt.Name = "precioventaprodtxt"
        Me.precioventaprodtxt.Size = New System.Drawing.Size(283, 23)
        Me.precioventaprodtxt.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(385, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 21)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Precio Venta:"
        '
        'productoslistview
        '
        Me.productoslistview.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader3})
        Me.productoslistview.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.productoslistview.FullRowSelect = True
        Me.productoslistview.GridLines = True
        Me.productoslistview.HideSelection = False
        Me.productoslistview.Location = New System.Drawing.Point(57, 193)
        Me.productoslistview.Name = "productoslistview"
        Me.productoslistview.Size = New System.Drawing.Size(738, 277)
        Me.productoslistview.TabIndex = 37
        Me.productoslistview.UseCompatibleStateImageBehavior = False
        Me.productoslistview.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Id Producto"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.DisplayIndex = 3
        Me.ColumnHeader4.Text = "Categoria"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.DisplayIndex = 2
        Me.ColumnHeader3.Text = "Precio"
        Me.ColumnHeader3.Width = 90
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(360, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 25)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "PRODUCTOS"
        '
        'eliminarprodbtm
        '
        Me.eliminarprodbtm.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.eliminarprodbtm.Location = New System.Drawing.Point(649, 143)
        Me.eliminarprodbtm.Name = "eliminarprodbtm"
        Me.eliminarprodbtm.Size = New System.Drawing.Size(116, 28)
        Me.eliminarprodbtm.TabIndex = 35
        Me.eliminarprodbtm.Text = "ELIMINAR"
        Me.eliminarprodbtm.UseVisualStyleBackColor = True
        '
        'actualizarprodbtm
        '
        Me.actualizarprodbtm.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.actualizarprodbtm.Location = New System.Drawing.Point(515, 143)
        Me.actualizarprodbtm.Name = "actualizarprodbtm"
        Me.actualizarprodbtm.Size = New System.Drawing.Size(114, 28)
        Me.actualizarprodbtm.TabIndex = 34
        Me.actualizarprodbtm.Text = "ACTUALIZAR"
        Me.actualizarprodbtm.UseVisualStyleBackColor = True
        '
        'registrarprodbtm
        '
        Me.registrarprodbtm.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.registrarprodbtm.Location = New System.Drawing.Point(385, 143)
        Me.registrarprodbtm.Name = "registrarprodbtm"
        Me.registrarprodbtm.Size = New System.Drawing.Size(116, 28)
        Me.registrarprodbtm.TabIndex = 33
        Me.registrarprodbtm.Text = "REGISTRAR"
        Me.registrarprodbtm.UseVisualStyleBackColor = True
        '
        'Categoriaprodtxt
        '
        Me.Categoriaprodtxt.Location = New System.Drawing.Point(150, 99)
        Me.Categoriaprodtxt.Name = "Categoriaprodtxt"
        Me.Categoriaprodtxt.Size = New System.Drawing.Size(216, 23)
        Me.Categoriaprodtxt.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(69, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 21)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Categoria:"
        '
        'nombreprodtxt
        '
        Me.nombreprodtxt.Location = New System.Drawing.Point(482, 60)
        Me.nombreprodtxt.Name = "nombreprodtxt"
        Me.nombreprodtxt.Size = New System.Drawing.Size(283, 23)
        Me.nombreprodtxt.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(414, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 21)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Nombre:"
        '
        'Idproductoprodtxt
        '
        Me.Idproductoprodtxt.Location = New System.Drawing.Point(150, 60)
        Me.Idproductoprodtxt.Name = "Idproductoprodtxt"
        Me.Idproductoprodtxt.Size = New System.Drawing.Size(110, 23)
        Me.Idproductoprodtxt.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(57, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 21)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "ID Producto:"
        '
        'buscarprodbtm
        '
        Me.buscarprodbtm.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.buscarprodbtm.Location = New System.Drawing.Point(281, 53)
        Me.buscarprodbtm.Name = "buscarprodbtm"
        Me.buscarprodbtm.Size = New System.Drawing.Size(75, 30)
        Me.buscarprodbtm.TabIndex = 26
        Me.buscarprodbtm.Text = "BUSCAR"
        Me.buscarprodbtm.UseVisualStyleBackColor = True
        '
        'refrescarbtm
        '
        Me.refrescarbtm.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.refrescarbtm.Location = New System.Drawing.Point(57, 164)
        Me.refrescarbtm.Name = "refrescarbtm"
        Me.refrescarbtm.Size = New System.Drawing.Size(228, 23)
        Me.refrescarbtm.TabIndex = 40
        Me.refrescarbtm.Text = "CARGAR PRODUCTOS / REFRESCAR"
        Me.refrescarbtm.UseVisualStyleBackColor = True
        '
        'MENU
        '
        Me.MENU.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MENU.Location = New System.Drawing.Point(645, 6)
        Me.MENU.Name = "MENU"
        Me.MENU.Size = New System.Drawing.Size(150, 35)
        Me.MENU.TabIndex = 41
        Me.MENU.Text = "VOLVER AL MENU"
        Me.MENU.UseVisualStyleBackColor = True
        '
        'PRODUCTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(864, 491)
        Me.Controls.Add(Me.MENU)
        Me.Controls.Add(Me.refrescarbtm)
        Me.Controls.Add(Me.precioventaprodtxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.productoslistview)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.eliminarprodbtm)
        Me.Controls.Add(Me.actualizarprodbtm)
        Me.Controls.Add(Me.registrarprodbtm)
        Me.Controls.Add(Me.Categoriaprodtxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nombreprodtxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Idproductoprodtxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.buscarprodbtm)
        Me.Name = "PRODUCTOS"
        Me.Text = "PRODUCTOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents precioventaprodtxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents productoslistview As ListView
    Friend WithEvents Label4 As Label
    Friend WithEvents eliminarprodbtm As Button
    Friend WithEvents actualizarprodbtm As Button
    Friend WithEvents registrarprodbtm As Button
    Friend WithEvents Categoriaprodtxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents nombreprodtxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Idproductoprodtxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents buscarprodbtm As Button
    Friend WithEvents refrescarbtm As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents MENU As Button
End Class
