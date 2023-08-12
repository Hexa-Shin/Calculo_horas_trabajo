<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class wfmCalculosHT
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btncalculo = New Button()
        txtTmañana = New TextBox()
        TxtTtarde = New TextBox()
        txtTnoche = New TextBox()
        txt1 = New TextBox()
        lblTmañana = New Label()
        lblTtarde = New Label()
        lblTnoche = New Label()
        Label4 = New Label()
        txtDferiado = New TextBox()
        lblHferiado = New Label()
        lblDal100 = New Label()
        nudD100 = New NumericUpDown()
        cldMes = New MonthCalendar()
        txt2 = New TextBox()
        btn1 = New Button()
        txt3 = New TextBox()
        CType(nudD100, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btncalculo
        ' 
        btncalculo.Location = New Point(273, 250)
        btncalculo.Name = "btncalculo"
        btncalculo.Size = New Size(184, 53)
        btncalculo.TabIndex = 0
        btncalculo.Text = "Calucular"
        btncalculo.UseVisualStyleBackColor = True
        ' 
        ' txtTmañana
        ' 
        txtTmañana.Location = New Point(167, 74)
        txtTmañana.Name = "txtTmañana"
        txtTmañana.Size = New Size(161, 23)
        txtTmañana.TabIndex = 1
        ' 
        ' TxtTtarde
        ' 
        TxtTtarde.Location = New Point(167, 125)
        TxtTtarde.Name = "TxtTtarde"
        TxtTtarde.Size = New Size(161, 23)
        TxtTtarde.TabIndex = 1
        ' 
        ' txtTnoche
        ' 
        txtTnoche.Location = New Point(167, 180)
        txtTnoche.Name = "txtTnoche"
        txtTnoche.Size = New Size(161, 23)
        txtTnoche.TabIndex = 1
        ' 
        ' txt1
        ' 
        txt1.Location = New Point(214, 428)
        txt1.Name = "txt1"
        txt1.Size = New Size(689, 23)
        txt1.TabIndex = 1
        ' 
        ' lblTmañana
        ' 
        lblTmañana.AutoSize = True
        lblTmañana.Location = New Point(60, 77)
        lblTmañana.Name = "lblTmañana"
        lblTmañana.Size = New Size(84, 15)
        lblTmañana.TabIndex = 2
        lblTmañana.Text = "Turno Mañana"
        ' 
        ' lblTtarde
        ' 
        lblTtarde.AutoSize = True
        lblTtarde.Location = New Point(60, 133)
        lblTtarde.Name = "lblTtarde"
        lblTtarde.Size = New Size(69, 15)
        lblTtarde.TabIndex = 2
        lblTtarde.Text = "Turno Tarde"
        ' 
        ' lblTnoche
        ' 
        lblTnoche.AutoSize = True
        lblTnoche.Location = New Point(60, 188)
        lblTnoche.Name = "lblTnoche"
        lblTnoche.Size = New Size(76, 15)
        lblTnoche.TabIndex = 2
        lblTnoche.Text = "Turno Noche"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(167, 436)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 15)
        Label4.TabIndex = 2
        Label4.Text = "Label1"
        ' 
        ' txtDferiado
        ' 
        txtDferiado.Location = New Point(508, 77)
        txtDferiado.Name = "txtDferiado"
        txtDferiado.Size = New Size(161, 23)
        txtDferiado.TabIndex = 1
        ' 
        ' lblHferiado
        ' 
        lblHferiado.AutoSize = True
        lblHferiado.Location = New Point(401, 80)
        lblHferiado.Name = "lblHferiado"
        lblHferiado.Size = New Size(80, 15)
        lblHferiado.TabIndex = 2
        lblHferiado.Text = "Horas Feriado"
        ' 
        ' lblDal100
        ' 
        lblDal100.AutoSize = True
        lblDal100.Location = New Point(401, 158)
        lblDal100.Name = "lblDal100"
        lblDal100.Size = New Size(62, 15)
        lblDal100.TabIndex = 2
        lblDal100.Text = "Dias al 100"
        ' 
        ' nudD100
        ' 
        nudD100.Location = New Point(508, 158)
        nudD100.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        nudD100.Name = "nudD100"
        nudD100.Size = New Size(120, 23)
        nudD100.TabIndex = 3
        ' 
        ' cldMes
        ' 
        cldMes.Location = New Point(565, 214)
        cldMes.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        cldMes.MinDate = New Date(2023, 1, 1, 0, 0, 0, 0)
        cldMes.Name = "cldMes"
        cldMes.TabIndex = 4
        ' 
        ' txt2
        ' 
        txt2.Location = New Point(214, 485)
        txt2.Name = "txt2"
        txt2.Size = New Size(689, 23)
        txt2.TabIndex = 1
        ' 
        ' btn1
        ' 
        btn1.Location = New Point(115, 484)
        btn1.Name = "btn1"
        btn1.Size = New Size(75, 23)
        btn1.TabIndex = 5
        btn1.Text = "Button1"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' txt3
        ' 
        txt3.Location = New Point(214, 514)
        txt3.Name = "txt3"
        txt3.Size = New Size(689, 23)
        txt3.TabIndex = 1
        ' 
        ' wfmCalculosHT
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(915, 550)
        Controls.Add(btn1)
        Controls.Add(cldMes)
        Controls.Add(nudD100)
        Controls.Add(Label4)
        Controls.Add(lblTnoche)
        Controls.Add(lblTtarde)
        Controls.Add(lblDal100)
        Controls.Add(lblHferiado)
        Controls.Add(lblTmañana)
        Controls.Add(txt3)
        Controls.Add(txt2)
        Controls.Add(txt1)
        Controls.Add(txtTnoche)
        Controls.Add(TxtTtarde)
        Controls.Add(txtDferiado)
        Controls.Add(txtTmañana)
        Controls.Add(btncalculo)
        Name = "wfmCalculosHT"
        Text = "Calculadora de Horas Trabajadas V2.0"
        CType(nudD100, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btncalculo As Button
    Friend WithEvents txtTmañana As TextBox
    Friend WithEvents TxtTtarde As TextBox
    Friend WithEvents txtTnoche As TextBox
    Friend WithEvents txt1 As TextBox
    Friend WithEvents lblTmañana As Label
    Friend WithEvents lblTtarde As Label
    Friend WithEvents lblTnoche As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDferiado As TextBox
    Friend WithEvents lblHferiado As Label
    Friend WithEvents lblDal100 As Label
    Friend WithEvents nudD100 As NumericUpDown
    Friend WithEvents cldMes As MonthCalendar
    Friend WithEvents txt2 As TextBox
    Friend WithEvents btn1 As Button
    Friend WithEvents txt3 As TextBox
End Class
