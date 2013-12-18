Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Imports System.Net.Mail
Module Funciones
#Region "Variables de SIMA"
    'Variables MySQL
    Public MySQLcon As New MySqlConnection
    Public servidorMySQL As String
    Public usuarioMySQL As String
    Public contrasenaMySQL As String
    Public rutaSIIGO As String
    'Variables MSSQL
    Public MSSQLcon As New SqlConnection
    Public servidorMSSQL As String
    Public usuarioMSSQL As String
    Public contrasenaMSSQL As String
#End Region
#Region "Funciones SIMA"
    '--------------------------------------------
    'Funcion para conectar a MySQL
    '--------------------------------------------
    Public Function conectarMySQL(s As String, u As String, c As String)
        servidorMySQL = s
        usuarioMySQL = u
        contrasenaMySQL = c

        Try
            MySQLcon.Close()
            MySQLcon.ConnectionString = "server=" & servidorMySQL & ";" & _
                    "user=" & usuarioMySQL & ";password=" & contrasenaMySQL & ";database=ciudadde_mascot"
            MySQLcon.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    '-------------------------------------------------
    'Funcion para ejecutar sentencias en MySQL
    '-------------------------------------------------
    Public Function MySQLSelect(ByRef MySqlSen As String) As DataSet
        Dim adaptador As New MySqlDataAdapter(MySqlSen, MySQLcon)
        Dim rsDatos As New DataSet
        adaptador.Fill(rsDatos, "DATOS")
        Return rsDatos
        MySQLcon.Close()
    End Function
    '-------------------------------------------------
    'Funcion para ejecutar sentencias diferentes en MySQL
    '------------------------------------------------
    Public Function MySQLSelectDif(ByRef MySqlSen1 As String) As DataSet
        Dim adaptador1 As New MySqlDataAdapter(MySqlSen1, MySQLcon)
        Dim rsDatos1 As New DataSet
        adaptador1.Fill(rsDatos1, "DATOS")
        Return rsDatos1
        MySQLcon.Close()
    End Function
    '---------------------------------------------
    'Función poara conectar a MSSQL
    '---------------------------------------------
    Public Function conectarMSSQL(s As String, u As String, c As String)
        servidorMSSQL = s
        usuarioMSSQL = u
        contrasenaMSSQL = c

        Try
            MSSQLcon.Close()
            MSSQLcon.ConnectionString = "Data Source = " &
                servidorMSSQL & "; Initial Catalog = bridge; User ID = " & _
                usuarioMSSQL & "; Password = " & contrasenaMSSQL & ";"
            Return MSSQLcon
        Catch ex2 As Exception
            MsgBox(ex2.Message)
        End Try

    End Function
    '----------------------------------------------------------------------
    'Funcion para realizar consultas al servidor de MSSQL
    '----------------------------------------------------------------------
    Public Function MSSQLSelect(ByRef MSSqlSen As String) As DataSet
        Dim da As New SqlDataAdapter(MSSqlSen, MSSQLcon)
        Dim ds As New DataSet
        da.Fill(ds)
        Return ds
        MSSQLcon.Close()
    End Function
    '----------------------------------------------------------------------
    ' Funcion para insertar datos en el servidor de MSSQL
    '--------------------------------------------------------------------
    Public Sub insertarMSSQL(ByRef MSSqlSenInsert As String)
        MSSQLcon.Open()
        Dim insertar As New SqlClient.SqlCommand()
        insertar.CommandType = System.Data.CommandType.Text
        insertar.CommandText = MSSqlSenInsert

        insertar.Connection = MSSQLcon
        Try
            If ((insertar.ExecuteNonQuery() <> 0)) Then
                MSSQLcon.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub EnviarCorreo(ByVal mensaje As String, ByVal asunto As String)
        Dim message As New MailMessage
        Dim smtp As New SmtpClient
        message.From = New MailAddress("jurzola@mncol.com")
        message.To.Add("notificacionessima@gmail.com")
        message.Body = mensaje
        message.Subject = asunto
        message.Priority = MailPriority.Normal
        smtp.EnableSsl = True
        smtp.Port = "587"
        smtp.Host = "smtp.gmail.com"
        smtp.Credentials = New Net.NetworkCredential("jurzola@mncol.com", "optimusprime1984")
        smtp.Send(message)
    End Sub

#End Region
End Module
