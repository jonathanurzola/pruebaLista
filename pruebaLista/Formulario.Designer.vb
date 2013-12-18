<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnUtimoMssql = New System.Windows.Forms.Button()
        Me.lblServidorMssql = New System.Windows.Forms.Label()
        Me.txtServidorMssql = New System.Windows.Forms.TextBox()
        Me.txtUsuarioMssql = New System.Windows.Forms.TextBox()
        Me.lblUsuarioMssql = New System.Windows.Forms.Label()
        Me.lblContrasenaMssql = New System.Windows.Forms.Label()
        Me.txtContrasenaMssql = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnUltimoMysql = New System.Windows.Forms.Button()
        Me.lblServidorMysql = New System.Windows.Forms.Label()
        Me.txtContrasenaMysql = New System.Windows.Forms.TextBox()
        Me.lblContrasenaMysql = New System.Windows.Forms.Label()
        Me.txtServidorMysql = New System.Windows.Forms.TextBox()
        Me.lblUusuarioMysql = New System.Windows.Forms.Label()
        Me.txtUsuarioMysql = New System.Windows.Forms.TextBox()
        Me.dgvPedidos = New System.Windows.Forms.DataGridView()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Controls.Add(Me.btnUtimoMssql)
        Me.GroupBox3.Controls.Add(Me.lblServidorMssql)
        Me.GroupBox3.Controls.Add(Me.txtServidorMssql)
        Me.GroupBox3.Controls.Add(Me.txtUsuarioMssql)
        Me.GroupBox3.Controls.Add(Me.lblUsuarioMssql)
        Me.GroupBox3.Controls.Add(Me.lblContrasenaMssql)
        Me.GroupBox3.Controls.Add(Me.txtContrasenaMssql)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox3.Location = New System.Drawing.Point(12, 173)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(271, 145)
        Me.GroupBox3.TabIndex = 46
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de conexión a MSSQL"
        '
        'btnUtimoMssql
        '
        Me.btnUtimoMssql.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnUtimoMssql.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUtimoMssql.Location = New System.Drawing.Point(145, 107)
        Me.btnUtimoMssql.Name = "btnUtimoMssql"
        Me.btnUtimoMssql.Size = New System.Drawing.Size(100, 23)
        Me.btnUtimoMssql.TabIndex = 6
        Me.btnUtimoMssql.Text = "Último registro"
        Me.btnUtimoMssql.UseVisualStyleBackColor = True
        '
        'lblServidorMssql
        '
        Me.lblServidorMssql.AutoSize = True
        Me.lblServidorMssql.Location = New System.Drawing.Point(8, 25)
        Me.lblServidorMssql.Name = "lblServidorMssql"
        Me.lblServidorMssql.Size = New System.Drawing.Size(54, 13)
        Me.lblServidorMssql.TabIndex = 0
        Me.lblServidorMssql.Text = "Servidor"
        '
        'txtServidorMssql
        '
        Me.txtServidorMssql.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServidorMssql.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtServidorMssql.Location = New System.Drawing.Point(80, 24)
        Me.txtServidorMssql.Name = "txtServidorMssql"
        Me.txtServidorMssql.Size = New System.Drawing.Size(179, 20)
        Me.txtServidorMssql.TabIndex = 1
        Me.txtServidorMssql.Text = "192.168.50.133"
        '
        'txtUsuarioMssql
        '
        Me.txtUsuarioMssql.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuarioMssql.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtUsuarioMssql.Location = New System.Drawing.Point(80, 52)
        Me.txtUsuarioMssql.Name = "txtUsuarioMssql"
        Me.txtUsuarioMssql.Size = New System.Drawing.Size(179, 20)
        Me.txtUsuarioMssql.TabIndex = 2
        Me.txtUsuarioMssql.Text = "sa"
        '
        'lblUsuarioMssql
        '
        Me.lblUsuarioMssql.AutoSize = True
        Me.lblUsuarioMssql.Location = New System.Drawing.Point(8, 52)
        Me.lblUsuarioMssql.Name = "lblUsuarioMssql"
        Me.lblUsuarioMssql.Size = New System.Drawing.Size(50, 13)
        Me.lblUsuarioMssql.TabIndex = 2
        Me.lblUsuarioMssql.Text = "Usuario"
        '
        'lblContrasenaMssql
        '
        Me.lblContrasenaMssql.AutoSize = True
        Me.lblContrasenaMssql.Location = New System.Drawing.Point(8, 81)
        Me.lblContrasenaMssql.Name = "lblContrasenaMssql"
        Me.lblContrasenaMssql.Size = New System.Drawing.Size(71, 13)
        Me.lblContrasenaMssql.TabIndex = 1
        Me.lblContrasenaMssql.Text = "Contraseña"
        '
        'txtContrasenaMssql
        '
        Me.txtContrasenaMssql.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasenaMssql.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtContrasenaMssql.Location = New System.Drawing.Point(80, 81)
        Me.txtContrasenaMssql.Name = "txtContrasenaMssql"
        Me.txtContrasenaMssql.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasenaMssql.Size = New System.Drawing.Size(179, 20)
        Me.txtContrasenaMssql.TabIndex = 3
        Me.txtContrasenaMssql.Text = "Optimusprime1984"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnUltimoMysql)
        Me.GroupBox2.Controls.Add(Me.lblServidorMysql)
        Me.GroupBox2.Controls.Add(Me.txtContrasenaMysql)
        Me.GroupBox2.Controls.Add(Me.lblContrasenaMysql)
        Me.GroupBox2.Controls.Add(Me.txtServidorMysql)
        Me.GroupBox2.Controls.Add(Me.lblUusuarioMysql)
        Me.GroupBox2.Controls.Add(Me.txtUsuarioMysql)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(271, 144)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de conexión a MySQL"
        '
        'btnUltimoMysql
        '
        Me.btnUltimoMysql.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnUltimoMysql.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnUltimoMysql.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoMysql.Location = New System.Drawing.Point(145, 107)
        Me.btnUltimoMysql.Name = "btnUltimoMysql"
        Me.btnUltimoMysql.Size = New System.Drawing.Size(100, 23)
        Me.btnUltimoMysql.TabIndex = 6
        Me.btnUltimoMysql.Text = "Último registro"
        Me.btnUltimoMysql.UseVisualStyleBackColor = False
        '
        'lblServidorMysql
        '
        Me.lblServidorMysql.AutoSize = True
        Me.lblServidorMysql.Location = New System.Drawing.Point(8, 31)
        Me.lblServidorMysql.Name = "lblServidorMysql"
        Me.lblServidorMysql.Size = New System.Drawing.Size(54, 13)
        Me.lblServidorMysql.TabIndex = 0
        Me.lblServidorMysql.Text = "Servidor"
        '
        'txtContrasenaMysql
        '
        Me.txtContrasenaMysql.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasenaMysql.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtContrasenaMysql.Location = New System.Drawing.Point(80, 78)
        Me.txtContrasenaMysql.Name = "txtContrasenaMysql"
        Me.txtContrasenaMysql.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasenaMysql.Size = New System.Drawing.Size(179, 20)
        Me.txtContrasenaMysql.TabIndex = 3
        Me.txtContrasenaMysql.Text = "1234abcd."
        '
        'lblContrasenaMysql
        '
        Me.lblContrasenaMysql.AutoSize = True
        Me.lblContrasenaMysql.Location = New System.Drawing.Point(8, 81)
        Me.lblContrasenaMysql.Name = "lblContrasenaMysql"
        Me.lblContrasenaMysql.Size = New System.Drawing.Size(71, 13)
        Me.lblContrasenaMysql.TabIndex = 1
        Me.lblContrasenaMysql.Text = "Contraseña"
        '
        'txtServidorMysql
        '
        Me.txtServidorMysql.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServidorMysql.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtServidorMysql.Location = New System.Drawing.Point(80, 24)
        Me.txtServidorMysql.Name = "txtServidorMysql"
        Me.txtServidorMysql.Size = New System.Drawing.Size(179, 20)
        Me.txtServidorMysql.TabIndex = 1
        Me.txtServidorMysql.Text = "aspireplus-s6.aspirationhosting.com"
        '
        'lblUusuarioMysql
        '
        Me.lblUusuarioMysql.AutoSize = True
        Me.lblUusuarioMysql.Location = New System.Drawing.Point(8, 55)
        Me.lblUusuarioMysql.Name = "lblUusuarioMysql"
        Me.lblUusuarioMysql.Size = New System.Drawing.Size(50, 13)
        Me.lblUusuarioMysql.TabIndex = 2
        Me.lblUusuarioMysql.Text = "Usuario"
        '
        'txtUsuarioMysql
        '
        Me.txtUsuarioMysql.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuarioMysql.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtUsuarioMysql.Location = New System.Drawing.Point(80, 52)
        Me.txtUsuarioMysql.Name = "txtUsuarioMysql"
        Me.txtUsuarioMysql.Size = New System.Drawing.Size(179, 20)
        Me.txtUsuarioMysql.TabIndex = 2
        Me.txtUsuarioMysql.Text = "ciudadde_jum"
        '
        'dgvPedidos
        '
        Me.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedidos.Location = New System.Drawing.Point(290, 13)
        Me.dgvPedidos.Name = "dgvPedidos"
        Me.dgvPedidos.Size = New System.Drawing.Size(541, 143)
        Me.dgvPedidos.TabIndex = 47
        '
        'dgvProductos
        '
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(290, 175)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(541, 143)
        Me.dgvProductos.TabIndex = 48
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(208, 325)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Formulario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 365)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.dgvPedidos)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Formulario"
        Me.Text = "Form1"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnUtimoMssql As System.Windows.Forms.Button
    Friend WithEvents lblServidorMssql As System.Windows.Forms.Label
    Friend WithEvents txtServidorMssql As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuarioMssql As System.Windows.Forms.TextBox
    Friend WithEvents lblUsuarioMssql As System.Windows.Forms.Label
    Friend WithEvents lblContrasenaMssql As System.Windows.Forms.Label
    Friend WithEvents txtContrasenaMssql As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnUltimoMysql As System.Windows.Forms.Button
    Friend WithEvents lblServidorMysql As System.Windows.Forms.Label
    Friend WithEvents txtContrasenaMysql As System.Windows.Forms.TextBox
    Friend WithEvents lblContrasenaMysql As System.Windows.Forms.Label
    Friend WithEvents txtServidorMysql As System.Windows.Forms.TextBox
    Friend WithEvents lblUusuarioMysql As System.Windows.Forms.Label
    Friend WithEvents txtUsuarioMysql As System.Windows.Forms.TextBox
    Friend WithEvents dgvPedidos As System.Windows.Forms.DataGridView
    Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
