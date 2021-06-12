Imports System.Data.SqlClient
Public Class CLIENTES
    Private Sub registrarclientebtm_Click(sender As Object, e As EventArgs) Handles registrarclientebtm.Click

        Dim conexion As String
        conexion = "Data Source=PC-VP120;Initial Catalog=Supermercado_UNICAES;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlCommand("Insert into cliente values('" & nombreclientetxt.Text & "', '" & apellidoclientetxt.Text & "')", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        MessageBox.Show("se registro correctamente")

        Idclienteclientestxt.Text = ""
        nombreclientetxt.Text = ""
        apellidoclientetxt.Text = ""

    End Sub

    Private Sub buscarclientebtm_Click(sender As Object, e As EventArgs) Handles buscarclientebtm.Click


        Dim conexion As String
        conexion = "Data Source=PC-VP120;Initial Catalog=Supermercado_UNICAES;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlDataAdapter("select*from cliente where id_cliente=" & Idclienteclientestxt.Text & "", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")

        If ds.Tables("datos").Rows.Count > 0 Then
            nombreclientetxt.Text = ds.Tables("datos").Rows(0).Item(1).ToString
            apellidoclientetxt.Text = ds.Tables("datos").Rows(0).Item(2).ToString

        Else
            MessageBox.Show("CLIENTE NO EXISTE")
        End If

    End Sub

    Private Sub actualizarclientebtm_Click(sender As Object, e As EventArgs) Handles actualizarclientebtm.Click
        Dim conexion As String
        conexion = "Data Source=PC-VP120;Initial Catalog=Supermercado_UNICAES;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlCommand("update cliente set Nombre = '" & nombreclientetxt.Text & "', apellido = '" & apellidoclientetxt.Text & "' where id_cliente = " & Idclienteclientestxt.Text & " ", cn)
        cn.Open()
        adaptador.ExecuteNonQuery()
        MessageBox.Show("datos actualizados")

        Idclienteclientestxt.Text = ""
        nombreclientetxt.Text = ""
        apellidoclientetxt.Text = ""

        cn.Close()
    End Sub

    Private Sub eliminarclientebtm_Click(sender As Object, e As EventArgs) Handles eliminarclientebtm.Click

        Dim conexion As String
        conexion = "Data Source=PC-VP120;Initial Catalog=Supermercado_UNICAES;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        cn.Open()

        Dim comando As New SqlCommand("delete from cliente where id_cliente =" & Idclienteclientestxt.Text & " ", cn)
        comando.ExecuteNonQuery()
        MessageBox.Show("se elimino correctamente")

        Idclienteclientestxt.Text = ""
        nombreclientetxt.Text = ""
        apellidoclientetxt.Text = ""

        cn.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.clientelistview.Items.Clear()

        Dim conexion As String
        conexion = "Data Source=PC-VP120;Initial Catalog=Supermercado_UNICAES;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlDataAdapter("select ID_cliente, Nombre, apellido from cliente ", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")

        If ds.Tables("datos").Rows.Count > 0 Then
            Dim conteo = ds.Tables("datos").Rows.Count
            For i = 0 To conteo - 1
                Dim arr(3) As String
                arr(0) = ds.Tables("datos").Rows(i).Item(0).ToString
                arr(1) = ds.Tables("datos").Rows(i).Item(1).ToString
                arr(2) = ds.Tables("datos").Rows(i).Item(2).ToString

                Dim items As ListViewItem
                items = New ListViewItem(arr)
                Me.clientelistview.Items.Add(items)
            Next

        Else
            MessageBox.Show("cliente no existe")
        End If

    End Sub

    Private Sub MENU_Click(sender As Object, e As EventArgs) Handles MENU.Click

        Dim prod As Principal
        prod = New Principal()
        prod.Show()
        prod = Nothing

    End Sub

End Class