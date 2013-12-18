Public Class Formulario

    Private ordenes As New Hashtable()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Funciones.conectarMySQL(txtServidorMysql.Text, txtUsuarioMysql.Text, txtContrasenaMysql.Text)
        Dim queryDif As String = "SELECT s.entity_id, s.status, s.shipping_description, s.total_paid, s.customer_firstname, s.customer_lastname,  (SELECT fn.`value` FROM customer_entity_varchar fn WHERE s.customer_id = fn.entity_id AND fn.attribute_id = 176) AS document, s.shipping_amount, onestepcheckout_customercomment, increment_id FROM sales_flat_order s WHERE (s.status= 'para_orden_de_pedido')"
        Dim ordersDataSet As DataSet = Funciones.MySQLSelect(queryDif)
        leerProductos(ordersDataSet)
        dgvPedidos.DataSource = ordersDataSet.Tables(0)

        Dim queryProd As String = "select s.order_id, status, created_at ,  (SELECT fn.`value` FROM customer_entity_varchar fn 	WHERE s.customer_id = fn.entity_id AND fn.attribute_id = 176 ) AS documento, sku, valor_pedido,discount_amount,discount_percent,`name`, cantidad from pre_bridge AS s WHERE (s.status= 'para_orden_de_pedido')"
        Dim dataSet As DataSet = MySQLSelectDif(queryProd)
        For Each row As DataRow In dataSet.Tables(0).Rows
            Dim orderId As String = row("order_id")
            Dim o As Orden = ordenes(orderId)
            Dim producto As New Producto(row("created_at"), row("sku"), row("valor_pedido"), row("discount_amount"),
                                         row("discount_percent"), row("name"), row("cantidad"))
            o.agregarProducto(producto)
        Next
        dgvProductos.DataSource = dataSet.Tables(0)



    End Sub

    Private Sub show()
        For Each de As DictionaryEntry In ordenes
            Dim o As Orden = de.Value
            Dim final As String = ""
            final += o.orderId & " " & o.productos(0).sku
            MsgBox(final)
        Next
    End Sub

    Private Sub leerProductos(ByRef ordersDataSet As DataSet)
        Dim rows As DataRowCollection = ordersDataSet.Tables(0).Rows
        Dim quantity As Integer = rows.Count

        For i As Integer = 0 To quantity - 1
            Dim row As DataRow = rows.Item(i)
            Dim totPaid As Object = row("total_paid")
            Dim document As Object = row("document")
            Dim comm As Object = row("onestepcheckout_customercomment")
            If (IsDBNull(totPaid)) Then
                totPaid = ""
            End If
            If (IsDBNull(document)) Then
                document = ""
            End If
            If (IsDBNull(comm)) Then
                comm = ""
            End If
            Dim orden As New Orden(row("entity_id"), row("status"), row("shipping_description"), totPaid,
                               row("customer_firstname"), row("customer_lastname"), document, row("shipping_amount"),
                               comm, row("increment_id"))
            'MsgBox(orden.orderId)
            ordenes.Add(orden.orderId, orden)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        show()
    End Sub
End Class
