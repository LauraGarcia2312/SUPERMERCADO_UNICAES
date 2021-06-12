Imports System.Data.SqlClient

Public Class VENTAS
    Dim arr(3) As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        arr(0) = Me.txtid.Text
        arr(1) = Me.txtPUnitario.Text
        arr(2) = Me.txtCantidad.Text

        Dim items As ListViewItem
        items = New ListViewItem(arr)
        Me.lvVentas.Items.Add(items)


    End Sub

    Private Sub buscarprodcventabtm_Click(sender As Object, e As EventArgs) Handles buscarprodcventabtm.Click

        Dim conexion As String
        conexion = "Data Source=PC-VP120;Initial Catalog=Supermercado_UNICAES;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlDataAdapter("select p.Nombre, i.stock_actual from Productos p, inventario i where i.id_producto = p.ID_producto and p.ID_producto = " & txtid.Text & "", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")

        If ds.Tables("datos").Rows.Count > 0 Then
            Me.resNombre.Text = ds.Tables("datos").Rows(0).Item(0).ToString
            Me.resStock.Text = ds.Tables("datos").Rows(0).Item(1).ToString

        Else
            MessageBox.Show("PRODUCTO NO EXISTE")
        End If

    End Sub

    Private Sub agregarventabtm_Click(sender As Object, e As EventArgs) Handles agregarventabtm.Click
        If Me.lvVentas.Items.Count = 0 Then
            MessageBox.Show("debe agregar al menos un producto")
        Else
            Dim conexion As String
            conexion = "Data Source=PC-VP120;Initial Catalog=Supermercado_UNICAES;Integrated Security=True"
            Dim cn As New SqlConnection
            cn.ConnectionString = conexion

            Dim adaptador As New SqlCommand("Insert into venta(ID_cliente, Fecha) values (" & Me.txtIdCliente.Text & ",getdate()) select scope_identity()", cn)
            cn.Open()

            Dim id = adaptador.ExecuteScalar()

            cn.Close()

            For i = 0 To Me.lvVentas.Items.Count - 1
                Dim sql As String
                sql = "insert into detalle_venta(ID_producto,ID_venta, num_factura,cantidad) values (" & Me.lvVentas.Items(i).SubItems(0).Text & "," & id & "," & id & "," & Me.lvVentas.Items(i).SubItems(2).Text & ")"

                cn.Open()
                Dim adap As New SqlCommand(sql, cn)
                adap.ExecuteNonQuery()
                cn.Close()
            Next
        End If
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Dim conexion As String
        conexion = "Data Source=PC-VP120;Initial Catalog=Supermercado_UNICAES;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlDataAdapter("select Nombre, Apellido from cliente where ID_cliente = " & Me.txtIdCliente.Text & "", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")

        If ds.Tables("datos").Rows.Count > 0 Then
            Me.resCliente.Text = ds.Tables("datos").Rows(0).Item(0).ToString & " " & ds.Tables("datos").Rows(0).Item(1).ToString

        Else
            MessageBox.Show("CLIENTE NO EXISTE")
        End If
    End Sub

    Private Sub MENU_Click(sender As Object, e As EventArgs) Handles MENU.Click

        Dim prod As Principal
        prod = New Principal()
        prod.Show()
        prod = Nothing

    End Sub
End Class