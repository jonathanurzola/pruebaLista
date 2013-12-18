Public Class Orden

    Public orderId As String
    Public status As String
    Public shippingDescription As String
    Public totalPaid As String
    Public customerFirstName As String
    Public customerLastName As String
    Public document As String
    Public shippingAmount As String
    Public comment As String
    Public incrementId As String
    Public productos() As Producto
    Private productosCont As Integer

    Sub New(ByVal oId As String, ByVal sts As String, ByVal sDescription As String, ByVal totPaid As String,
            ByVal firstName As String, ByVal lastName As String, ByVal doc As String, ByVal sAmount As String,
            ByVal comm As String, ByVal incId As String)
        orderId = oId
        status = sts
        shippingDescription = sDescription
        totalPaid = totPaid
        customerFirstName = firstName
        customerLastName = lastName
        document = doc
        shippingAmount = sAmount
        comment = comm
        incrementId = incId
        productosCont = 0
    End Sub

    Public Sub agregarProducto(p As Producto)
        ReDim Preserve productos(0 To productosCont + 1)
        productos(productosCont) = p
        productosCont += 1
    End Sub

End Class
