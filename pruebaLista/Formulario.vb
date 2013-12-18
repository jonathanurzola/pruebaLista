Public Class Formulario

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Funciones.conectarMySQL(txtServidorMysql.Text, txtUsuarioMysql.Text, txtContrasenaMysql.Text)
        Dim queryDif As String = "SELECT s.entity_id, s.status, s.shipping_description, s.total_paid, s.customer_firstname, s.customer_lastname,  (SELECT fn.`value` FROM customer_entity_varchar fn WHERE s.customer_id = fn.entity_id AND fn.attribute_id = 176) AS documento, s.shipping_description, s.shipping_amount, onestepcheckout_customercomment, increment_id FROM sales_flat_order s WHERE (s.status= 'para_orden_de_pedido')"
        dgvPedidos.DataSource = Funciones.MySQLSelect(queryDif).Tables(0)

        Dim queryProd As String = "select s.order_id, status, created_at ,  (SELECT fn.`value` FROM customer_entity_varchar fn 	WHERE s.customer_id = fn.entity_id AND fn.attribute_id = 176 ) AS documento, sku, valor_pedido,discount_amount,discount_percent,`name`, cantidad from pre_bridge AS s WHERE (s.status= 'para_orden_de_pedido')"
        dgvProductos.DataSource = MySQLSelectDif(queryProd).Tables(0)
    End Sub
End Class
