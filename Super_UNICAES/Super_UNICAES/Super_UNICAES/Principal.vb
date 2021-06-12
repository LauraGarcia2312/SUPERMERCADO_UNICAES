Public Class Principal
    Private Sub productosMENUbtm_Click(sender As Object, e As EventArgs) Handles productosMENUbtm.Click
        Dim prod As PRODUCTOS
        prod = New PRODUCTOS()
        prod.Show()
        prod = Nothing
    End Sub

    Private Sub clientesMENUbtm_Click(sender As Object, e As EventArgs) Handles clientesMENUbtm.Click

        Dim prod As CLIENTES
        prod = New CLIENTES()
        prod.Show()
        prod = Nothing

    End Sub

    Private Sub VentasMENUbtm_Click(sender As Object, e As EventArgs) Handles VentasMENUbtm.Click

        Dim prod As VENTAS
        prod = New VENTAS()
        prod.Show()
        prod = Nothing

    End Sub

    Private Sub comprasMENUbtm_Click(sender As Object, e As EventArgs) Handles comprasMENUbtm.Click

        Dim prod As COMPRAS
        prod = New COMPRAS()
        prod.Show()
        prod = Nothing

    End Sub
End Class