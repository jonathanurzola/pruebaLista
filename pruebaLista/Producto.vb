Public Class Producto
    'select s.order_id, status, created_at , documento, sku, valor_pedido,discount_amount,discount_percent,`name`, cantidad
    Sub New(ByVal dateStr As String, ByVal skuStr As String, ByVal vPedido As String, ByVal dAmount As String,
            ByVal dPercent As String, ByVal name As String, ByVal quantity As String)
        createdAt = dateStr
        sku = skuStr
        valorPedido = vPedido
        discoutAmount = dAmount
        discountPercent = dPercent
        productName = name
        cantidad = quantity
    End Sub

    Public createdAt As String
    Public sku As String
    Public valorPedido As String
    Public discoutAmount As String
    Public discountPercent As String
    Public productName As String
    Public cantidad As String

End Class
