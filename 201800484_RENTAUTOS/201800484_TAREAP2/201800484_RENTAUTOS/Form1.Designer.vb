<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNit = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lstMarca = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.lstPagoFinal = New System.Windows.Forms.ListBox()
        Me.lstPagoParcial = New System.Windows.Forms.ListBox()
        Me.lstDias = New System.Windows.Forms.ListBox()
        Me.lstPlacas = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPlaca = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxMarca = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.button4 = New System.Windows.Forms.Button()
        Me.btnBodega = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.txtTarjeta = New System.Windows.Forms.TextBox()
        Me.txtEfectivo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDias = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(697, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 17)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Nit"
        '
        'txtNit
        '
        Me.txtNit.Location = New System.Drawing.Point(697, 91)
        Me.txtNit.Name = "txtNit"
        Me.txtNit.Size = New System.Drawing.Size(149, 22)
        Me.txtNit.TabIndex = 71
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Pink
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lstMarca)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Nombre)
        Me.GroupBox2.Controls.Add(Me.lstPagoFinal)
        Me.GroupBox2.Controls.Add(Me.lstPagoParcial)
        Me.GroupBox2.Controls.Add(Me.lstDias)
        Me.GroupBox2.Controls.Add(Me.lstPlacas)
        Me.GroupBox2.Location = New System.Drawing.Point(182, 150)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(606, 323)
        Me.GroupBox2.TabIndex = 70
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(119, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Marca"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(467, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 17)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Pago Final"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(350, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 17)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Pago Parcial"
        '
        'lstMarca
        '
        Me.lstMarca.FormattingEnabled = True
        Me.lstMarca.ItemHeight = 16
        Me.lstMarca.Location = New System.Drawing.Point(120, 52)
        Me.lstMarca.Name = "lstMarca"
        Me.lstMarca.Size = New System.Drawing.Size(96, 260)
        Me.lstMarca.TabIndex = 57
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(234, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 17)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Dias"
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Location = New System.Drawing.Point(6, 32)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(50, 17)
        Me.Nombre.TabIndex = 53
        Me.Nombre.Text = "Placas"
        '
        'lstPagoFinal
        '
        Me.lstPagoFinal.FormattingEnabled = True
        Me.lstPagoFinal.ItemHeight = 16
        Me.lstPagoFinal.Location = New System.Drawing.Point(468, 52)
        Me.lstPagoFinal.Name = "lstPagoFinal"
        Me.lstPagoFinal.Size = New System.Drawing.Size(96, 260)
        Me.lstPagoFinal.TabIndex = 3
        '
        'lstPagoParcial
        '
        Me.lstPagoParcial.FormattingEnabled = True
        Me.lstPagoParcial.ItemHeight = 16
        Me.lstPagoParcial.Location = New System.Drawing.Point(353, 52)
        Me.lstPagoParcial.Name = "lstPagoParcial"
        Me.lstPagoParcial.Size = New System.Drawing.Size(96, 260)
        Me.lstPagoParcial.TabIndex = 2
        '
        'lstDias
        '
        Me.lstDias.FormattingEnabled = True
        Me.lstDias.ItemHeight = 16
        Me.lstDias.Location = New System.Drawing.Point(237, 52)
        Me.lstDias.Name = "lstDias"
        Me.lstDias.Size = New System.Drawing.Size(96, 260)
        Me.lstDias.TabIndex = 1
        '
        'lstPlacas
        '
        Me.lstPlacas.FormattingEnabled = True
        Me.lstPlacas.ItemHeight = 16
        Me.lstPlacas.Location = New System.Drawing.Point(7, 52)
        Me.lstPlacas.Name = "lstPlacas"
        Me.lstPlacas.Size = New System.Drawing.Size(96, 260)
        Me.lstPlacas.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(877, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Placa"
        '
        'txtPlaca
        '
        Me.txtPlaca.Location = New System.Drawing.Point(877, 91)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(149, 22)
        Me.txtPlaca.TabIndex = 68
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Linen
        Me.GroupBox1.Controls.Add(Me.cbxMarca)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 40)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.GroupBox1.Size = New System.Drawing.Size(168, 99)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Marca"
        '
        'cbxMarca
        '
        Me.cbxMarca.FormattingEnabled = True
        Me.cbxMarca.Items.AddRange(New Object() {"Honda", "Mercedes Benz", "Toyota", "Mazda"})
        Me.cbxMarca.Location = New System.Drawing.Point(10, 41)
        Me.cbxMarca.Name = "cbxMarca"
        Me.cbxMarca.Size = New System.Drawing.Size(121, 24)
        Me.cbxMarca.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.button4)
        Me.Panel1.Controls.Add(Me.btnBodega)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(35, 500)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1096, 120)
        Me.Panel1.TabIndex = 66
        '
        'button4
        '
        Me.button4.Dock = System.Windows.Forms.DockStyle.Left
        Me.button4.FlatAppearance.BorderSize = 0
        Me.button4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace
        Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button4.Font = New System.Drawing.Font("MV Boli", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button4.Image = Global._201800484_RENTAUTOS.My.Resources.Resources._exit
        Me.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button4.Location = New System.Drawing.Point(734, 0)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(367, 120)
        Me.button4.TabIndex = 9
        Me.button4.Text = "Salir"
        Me.button4.UseVisualStyleBackColor = True
        '
        'btnBodega
        '
        Me.btnBodega.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnBodega.FlatAppearance.BorderSize = 0
        Me.btnBodega.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnBodega.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBodega.Font = New System.Drawing.Font("MV Boli", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBodega.Image = Global._201800484_RENTAUTOS.My.Resources.Resources.clean
        Me.btnBodega.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBodega.Location = New System.Drawing.Point(367, 0)
        Me.btnBodega.Name = "btnBodega"
        Me.btnBodega.Size = New System.Drawing.Size(367, 120)
        Me.btnBodega.TabIndex = 8
        Me.btnBodega.Text = "Limpiar"
        Me.btnBodega.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("MV Boli", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global._201800484_RENTAUTOS.My.Resources.Resources.calculadora__1_
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(367, 120)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Calcular"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Linen
        Me.GroupBox4.Controls.Add(Me.txtEfectivo)
        Me.GroupBox4.Controls.Add(Me.txtTarjeta)
        Me.GroupBox4.Controls.Add(Me.CheckBox2)
        Me.GroupBox4.Controls.Add(Me.CheckBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(269, 40)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.GroupBox4.Size = New System.Drawing.Size(246, 99)
        Me.GroupBox4.TabIndex = 74
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipo de pago"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(10, 27)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(75, 21)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Tarjeta"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(9, 54)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(80, 21)
        Me.CheckBox2.TabIndex = 75
        Me.CheckBox2.Text = "Efectivo"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'txtTarjeta
        '
        Me.txtTarjeta.Location = New System.Drawing.Point(91, 26)
        Me.txtTarjeta.Name = "txtTarjeta"
        Me.txtTarjeta.Size = New System.Drawing.Size(149, 22)
        Me.txtTarjeta.TabIndex = 75
        Me.txtTarjeta.Visible = False
        '
        'txtEfectivo
        '
        Me.txtEfectivo.Location = New System.Drawing.Point(91, 54)
        Me.txtEfectivo.Name = "txtEfectivo"
        Me.txtEfectivo.Size = New System.Drawing.Size(149, 22)
        Me.txtEfectivo.TabIndex = 76
        Me.txtEfectivo.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(532, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 17)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Dias"
        '
        'txtDias
        '
        Me.txtDias.Location = New System.Drawing.Point(532, 91)
        Me.txtDias.Name = "txtDias"
        Me.txtDias.Size = New System.Drawing.Size(149, 22)
        Me.txtDias.TabIndex = 75
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1166, 661)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDias)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPlaca)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtNit As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lstMarca As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Nombre As Label
    Friend WithEvents lstPagoFinal As ListBox
    Friend WithEvents lstPagoParcial As ListBox
    Friend WithEvents lstDias As ListBox
    Friend WithEvents lstPlacas As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPlaca As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbxMarca As ComboBox
    Friend WithEvents Panel1 As Panel
    Private WithEvents button4 As Button
    Private WithEvents btnBodega As Button
    Private WithEvents Button2 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtEfectivo As TextBox
    Friend WithEvents txtTarjeta As TextBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDias As TextBox
End Class
