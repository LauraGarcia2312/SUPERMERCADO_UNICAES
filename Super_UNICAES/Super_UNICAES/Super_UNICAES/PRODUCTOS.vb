Imports System.Data.SqlClient
Public Class PRODUCTOS

    Private Sub registrarprodbtm_Click(sender As Object, e As EventArgs) Handles registrarprodbtm.Click

        Dim conexion As String
        conexion = "Data Source=PC-VP120;Initial Catalog=Supermercado_UNICAES;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlCommand("Insert into productos values('" & nombreprodtxt.Text & "', '" & Categoriaprodtxt.Text & "', '" & precioventaprodtxt.Text & "')", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        MessageBox.Show("se registro correctamente")


        Idproductoprodtxt.Text = ""
        nombreprodtxt.Text = ""
        Categoriaprodtxt.Text = ""
        precioventaprodtxt.Text = ""

        cn.Close()

    End Sub

    Private Sub buscarprodbtm_Click(sender As Object, e As EventArgs) Handles buscarprodbtm.Click
        Dim conexion As String
        conexion = "Data Source=PC-VP120;Initial Catalog=Supermercado_UNICAES;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlDataAdapter("select * from productos where id_producto=" & Idproductoprodtxt.Text & "", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")

        If ds.Tables("datos").Rows.Count > 0 Then
            nombreprodtxt.Text = ds.Tables("datos").Rows(0).Item(1).ToString
            Categoriaprodtxt.Text = ds.Tables("datos").Rows(0).Item(2).ToString
            precioventaprodtxt.Text = ds.Tables("datos").Rows(0).Item(3).ToString

        Else
            MessageBox.Show("producto no existe")
        End If

    End Sub


    Private Sub precioventaprodtxt_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles precioventaprodtxt.KeyPress

        Dim Solonumero As TextBox = CType(sender, TextBox)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
            MessageBox.Show("Solo números positivos")
        ElseIf e.KeyChar = "."c AndAlso (Solonumero.SelectionStart = 0 Or Solonumero.Text.IndexOf("."c) >= 0) Then
            e.Handled = True
        End If

    End Sub

    Private Sub actualizarprodbtm_Click(sender As Object, e As EventArgs) Handles actualizarprodbtm.Click

        Dim conexion As String
        conexion = "Data Source=PC-VP120;Initial Catalog=Supermercado_UNICAES;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlCommand("update PRODUCTOS set Nombre = '" & nombreprodtxt.Text & "', categoria = '" & Categoriaprodtxt.Text & "', precio_venta = '" & precioventaprodtxt.Text & "' where id_producto = " & Idproductoprodtxt.Text & " ", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        MessageBox.Show("datos actualizados")

        Idproductoprodtxt.Text = ""
        nombreprodtxt.Text = ""
        Categoriaprodtxt.Text = ""
        precioventaprodtxt.Text = ""

        cn.Close()

    End Sub

    Private Sub eliminarprodbtm_Click(sender As Object, e As EventArgs) Handles eliminarprodbtm.Click

        Dim conexion As String
        conexion = "Data Source=PC-VP120;Initial Catalog=Supermercado_UNICAES;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        cn.Open()

        Dim comando As New SqlCommand("delete from productos where id_producto =" & Idproductoprodtxt.Text & " ", cn)
        comando.ExecuteNonQuery()
        MessageBox.Show("se elimino correctamente")

        Idproductoprodtxt.Text = ""
        nombreprodtxt.Text = ""
        Categoriaprodtxt.Text = ""
        precioventaprodtxt.Text = ""

        cn.Close()

    End Sub

    Private Sub refrescarbtm_Click(sender As Object, e As EventArgs) Handles refrescarbtm.Click

        Me.productoslistview.Items.Clear()

        Dim conexion As String
        conexion = "Data Source=PC-VP120;Initial Catalog=Supermercado_UNICAES;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlDataAdapter("select * from Productos ", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")

        If ds.Tables("datos").Rows.Count > 0 Then
            Dim conteo = ds.Tables("datos").Rows.Count
            For i = 0 To conteo - 1
                Dim arr(3) As String
                arr(0) = ds.Tables("datos").Rows(i).Item(0).ToString
                arr(1) = ds.Tables("datos").Rows(i).Item(1).ToString
                arr(2) = ds.Tables("datos").Rows(i).Item(2).ToString
                arr(3) = ds.Tables("datos").Rows(i).Item(3).ToString

                Dim items As ListViewItem
                items = New ListViewItem(arr)
                Me.productoslistview.Items.Add(items)
            Next

        Else
            MessageBox.Show("producto no existe")
        End If

    End Sub

    Private Sub MENU_Click(sender As Object, e As EventArgs) Handles MENU.Click

        Dim prod As Principal
        prod = New Principal()
        prod.Show()
        prod = Nothing

    End Sub
End Class