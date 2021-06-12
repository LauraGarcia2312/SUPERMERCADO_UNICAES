<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CLIENTES
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
        Me.clientelistview = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.eliminarclientebtm = New System.Windows.Forms.Button()
        Me.actualizarclientebtm = New System.Windows.Forms.Button()
        Me.registrarclientebtm = New System.Windows.Forms.Button()
        Me.apellidoclientetxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nombreclientetxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Idclienteclientestxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.buscarclientebtm = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MENU = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'clientelistview
        '
        Me.clientelistview.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.clientelistview.FullRowSelect = True
        Me.clientelistview.GridLines = True
        Me.clientelistview.HideSelection = False
        Me.clientelistview.Location = New System.Drawing.Point(57, 181)
        Me.clientelistview.Name = "clientelistview"
        Me.clientelistview.Size = New System.Drawing.Size(738, 277)
        Me.clientelistview.TabIndex = 35
        Me.clientelistview.UseCompatibleStateImageBehavior = False
        Me.clientelistview.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id cliente"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Apellido"
        Me.ColumnHeader3.Width = 150
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(310, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 25)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "REGISTRO DE CLIENTES"
        '
        'eliminarclientebtm
        '
        Me.eliminarclientebtm.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.eliminarclientebtm.Location = New System.Drawing.Point(630, 127)
        Me.eliminarclientebtm.Name = "eliminarclientebtm"
        Me.eliminarclientebtm.Size = New System.Drawing.Size(96, 23)
        Me.eliminarclientebtm.TabIndex = 33
        Me.eliminarclientebtm.Text = "ELIMINAR"
        Me.eliminarclientebtm.UseVisualStyleBackColor = True
        '
        'actualizarclientebtm
        '
        Me.actualizarclientebtm.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.actualizarclientebtm.Location = New System.Drawing.Point(489, 127)
        Me.actualizarclientebtm.Name = "actualizarclientebtm"
        Me.actualizarclientebtm.Size = New System.Drawing.Size(106, 23)
        Me.actualizarclientebtm.TabIndex = 32
        Me.actualizarclientebtm.Text = "ACTUALIZAR"
        Me.actualizarclientebtm.UseVisualStyleBackColor = True
        '
        'registrarclientebtm
        '
        Me.registrarclientebtm.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.registrarclientebtm.Location = New System.Drawing.Point(366, 127)
        Me.registrarclientebtm.Name = "registrarclientebtm"
        Me.registrarclientebtm.Size = New System.Drawing.Size(96, 23)
        Me.registrarclientebtm.TabIndex = 31
        Me.registrarclientebtm.Text = "REGISTRAR"
        Me.registrarclientebtm.UseVisualStyleBackColor = True
        '
        'apellidoclientetxt
        '
        Me.apellidoclientetxt.Location = New System.Drawing.Point(521, 88)
        Me.apellidoclientetxt.Name = "apellidoclientetxt"
        Me.apellidoclientetxt.Size = New System.Drawing.Size(297, 23)
        Me.apellidoclientetxt.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(450, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 21)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Apellido:"
        '
        'nombreclientetxt
        '
        Me.nombreclientetxt.Location = New System.Drawing.Point(143, 88)
        Me.nombreclientetxt.Name = "nombreclientetxt"
        Me.nombreclientetxt.Size = New System.Drawing.Size(283, 23)
        Me.nombreclientetxt.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(57, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 21)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Nombre:"
        '
        'Idclienteclientestxt
        '
        Me.Idclienteclientestxt.Location = New System.Drawing.Point(143, 48)
        Me.Idclienteclientestxt.Name = "Idclienteclientestxt"
        Me.Idclienteclientestxt.Size = New System.Drawing.Size(117, 23)
        Me.Idclienteclientestxt.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(57, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 21)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "ID Cliente:"
        '
        'buscarclientebtm
        '
        Me.buscarclientebtm.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.buscarclientebtm.Location = New System.Drawing.Point(281, 48)
        Me.buscarclientebtm.Name = "buscarclientebtm"
        Me.buscarclientebtm.Size = New System.Drawing.Size(75, 23)
        Me.buscarclientebtm.TabIndex = 24
        Me.buscarclientebtm.Text = "BUSCAR"
        Me.buscarclientebtm.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(57, 152)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(242, 23)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "CARGAR CLIENTES / REFRESCAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MENU
        '
        Me.MENU.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MENU.Location = New System.Drawing.Point(668, 9)
        Me.MENU.Name = "MENU"
        Me.MENU.Size = New System.Drawing.Size(150, 35)
        Me.MENU.TabIndex = 37
        Me.MENU.Text = "VOLVER AL MENU"
        Me.MENU.UseVisualStyleBackColor = True
        '
        'CLIENTES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(864, 491)
        Me.Controls.Add(Me.MENU)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.clientelistview)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.eliminarclientebtm)
        Me.Controls.Add(Me.actualizarclientebtm)
        Me.Controls.Add(Me.registrarclientebtm)
        Me.Controls.Add(Me.apellidoclientetxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nombreclientetxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Idclienteclientestxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.buscarclientebtm)
        Me.Name = "CLIENTES"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents clientelistview As ListView
    Friend WithEvents Label4 As Label
    Friend WithEvents eliminarclientebtm As Button
    Friend WithEvents actualizarclientebtm As Button
    Friend WithEvents registrarclientebtm As Button
    Friend WithEvents apellidoclientetxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents nombreclientetxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Idclienteclientestxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents buscarclientebtm As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents MENU As Button
End Class
