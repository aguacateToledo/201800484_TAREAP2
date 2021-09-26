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
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lstSueldosBrutos = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.lstSueldosNetos = New System.Windows.Forms.ListBox()
        Me.lstIsr = New System.Windows.Forms.ListBox()
        Me.lstIgss = New System.Windows.Forms.ListBox()
        Me.lstNombres = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxFunciones = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.button4 = New System.Windows.Forms.Button()
        Me.btnBodega = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(292, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(292, 58)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(149, 22)
        Me.txtNombre.TabIndex = 71
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Pink
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lstSueldosBrutos)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Nombre)
        Me.GroupBox2.Controls.Add(Me.lstSueldosNetos)
        Me.GroupBox2.Controls.Add(Me.lstIsr)
        Me.GroupBox2.Controls.Add(Me.lstIgss)
        Me.GroupBox2.Controls.Add(Me.lstNombres)
        Me.GroupBox2.Location = New System.Drawing.Point(159, 134)
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
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Sueldo Neto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(467, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 17)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Sueldo Neto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(350, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 17)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "ISR"
        '
        'lstSueldosBrutos
        '
        Me.lstSueldosBrutos.FormattingEnabled = True
        Me.lstSueldosBrutos.ItemHeight = 16
        Me.lstSueldosBrutos.Location = New System.Drawing.Point(120, 52)
        Me.lstSueldosBrutos.Name = "lstSueldosBrutos"
        Me.lstSueldosBrutos.Size = New System.Drawing.Size(96, 260)
        Me.lstSueldosBrutos.TabIndex = 57
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(234, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 17)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "IGSS"
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Location = New System.Drawing.Point(6, 32)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(65, 17)
        Me.Nombre.TabIndex = 53
        Me.Nombre.Text = "Nombres"
        '
        'lstSueldosNetos
        '
        Me.lstSueldosNetos.FormattingEnabled = True
        Me.lstSueldosNetos.ItemHeight = 16
        Me.lstSueldosNetos.Location = New System.Drawing.Point(468, 52)
        Me.lstSueldosNetos.Name = "lstSueldosNetos"
        Me.lstSueldosNetos.Size = New System.Drawing.Size(96, 260)
        Me.lstSueldosNetos.TabIndex = 3
        '
        'lstIsr
        '
        Me.lstIsr.FormattingEnabled = True
        Me.lstIsr.ItemHeight = 16
        Me.lstIsr.Location = New System.Drawing.Point(353, 52)
        Me.lstIsr.Name = "lstIsr"
        Me.lstIsr.Size = New System.Drawing.Size(96, 260)
        Me.lstIsr.TabIndex = 2
        '
        'lstIgss
        '
        Me.lstIgss.FormattingEnabled = True
        Me.lstIgss.ItemHeight = 16
        Me.lstIgss.Location = New System.Drawing.Point(237, 52)
        Me.lstIgss.Name = "lstIgss"
        Me.lstIgss.Size = New System.Drawing.Size(96, 260)
        Me.lstIgss.TabIndex = 1
        '
        'lstNombres
        '
        Me.lstNombres.FormattingEnabled = True
        Me.lstNombres.ItemHeight = 16
        Me.lstNombres.Location = New System.Drawing.Point(7, 52)
        Me.lstNombres.Name = "lstNombres"
        Me.lstNombres.Size = New System.Drawing.Size(96, 260)
        Me.lstNombres.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(472, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 17)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Sueldo Bruto"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(472, 58)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(149, 22)
        Me.txtCantidad.TabIndex = 68
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Linen
        Me.GroupBox1.Controls.Add(Me.cbxFunciones)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.GroupBox1.Size = New System.Drawing.Size(274, 99)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Descuentos"
        '
        'cbxFunciones
        '
        Me.cbxFunciones.FormattingEnabled = True
        Me.cbxFunciones.Items.AddRange(New Object() {"IGSS", "ISR"})
        Me.cbxFunciones.Location = New System.Drawing.Point(10, 41)
        Me.cbxFunciones.Name = "cbxFunciones"
        Me.cbxFunciones.Size = New System.Drawing.Size(121, 24)
        Me.cbxFunciones.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.button4)
        Me.Panel1.Controls.Add(Me.btnBodega)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(-11, 475)
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
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(367, 120)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Calcular"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1074, 610)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lstSueldosBrutos As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Nombre As Label
    Friend WithEvents lstSueldosNetos As ListBox
    Friend WithEvents lstIsr As ListBox
    Friend WithEvents lstIgss As ListBox
    Friend WithEvents lstNombres As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbxFunciones As ComboBox
    Friend WithEvents Panel1 As Panel
    Private WithEvents button4 As Button
    Private WithEvents btnBodega As Button
    Private WithEvents Button2 As Button
End Class
