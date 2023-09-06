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
        btnPintar = New Button()
        nudMañana = New NumericUpDown()
        rtbResumen = New RichTextBox()
        nudTarde = New NumericUpDown()
        nudNoche = New NumericUpDown()
        nudAl100 = New NumericUpDown()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        GroupBox1 = New GroupBox()
        rdbFranco = New RadioButton()
        rdbNoche = New RadioButton()
        rdbTarde = New RadioButton()
        rdbMañana = New RadioButton()
        btnCargar = New Button()
        btnFinalizar = New Button()
        NumericUpDown1 = New NumericUpDown()
        Label6 = New Label()
        chbAl100 = New CheckBox()
        chbFeriado = New CheckBox()
        nudFranco = New NumericUpDown()
        Label7 = New Label()
        btnCargarFyE = New Button()
        CType(nudD100, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudMañana, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudTarde, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudNoche, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudAl100, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudFranco, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btncalculo
        ' 
        btncalculo.Location = New Point(225, 231)
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
        txtDferiado.Location = New Point(433, 74)
        txtDferiado.Name = "txtDferiado"
        txtDferiado.Size = New Size(161, 23)
        txtDferiado.TabIndex = 1
        ' 
        ' lblHferiado
        ' 
        lblHferiado.AutoSize = True
        lblHferiado.Location = New Point(347, 80)
        lblHferiado.Name = "lblHferiado"
        lblHferiado.Size = New Size(80, 15)
        lblHferiado.TabIndex = 2
        lblHferiado.Text = "Horas Feriado"
        ' 
        ' lblDal100
        ' 
        lblDal100.AutoSize = True
        lblDal100.Location = New Point(347, 128)
        lblDal100.Name = "lblDal100"
        lblDal100.Size = New Size(62, 15)
        lblDal100.TabIndex = 2
        lblDal100.Text = "Dias al 100"
        ' 
        ' nudD100
        ' 
        nudD100.Location = New Point(433, 125)
        nudD100.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        nudD100.Name = "nudD100"
        nudD100.Size = New Size(120, 23)
        nudD100.TabIndex = 3
        ' 
        ' cldMes
        ' 
        cldMes.BackColor = SystemColors.ControlLightLight
        cldMes.Location = New Point(646, 53)
        cldMes.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        cldMes.MaxSelectionCount = 31
        cldMes.MinDate = New Date(2023, 1, 1, 0, 0, 0, 0)
        cldMes.Name = "cldMes"
        cldMes.TabIndex = 4
        cldMes.TitleBackColor = SystemColors.ActiveBorder
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
        ' btnPintar
        ' 
        btnPintar.Enabled = False
        btnPintar.Location = New Point(12, 436)
        btnPintar.Name = "btnPintar"
        btnPintar.Size = New Size(75, 23)
        btnPintar.TabIndex = 6
        btnPintar.Text = "Pintar"
        btnPintar.UseVisualStyleBackColor = True
        ' 
        ' nudMañana
        ' 
        nudMañana.Location = New Point(929, 246)
        nudMañana.Name = "nudMañana"
        nudMañana.Size = New Size(120, 23)
        nudMañana.TabIndex = 7
        ' 
        ' rtbResumen
        ' 
        rtbResumen.Location = New Point(646, 245)
        rtbResumen.Name = "rtbResumen"
        rtbResumen.Size = New Size(248, 148)
        rtbResumen.TabIndex = 8
        rtbResumen.Text = ""
        ' 
        ' nudTarde
        ' 
        nudTarde.Location = New Point(929, 286)
        nudTarde.Name = "nudTarde"
        nudTarde.Size = New Size(120, 23)
        nudTarde.TabIndex = 7
        ' 
        ' nudNoche
        ' 
        nudNoche.Location = New Point(929, 327)
        nudNoche.Name = "nudNoche"
        nudNoche.Size = New Size(120, 23)
        nudNoche.TabIndex = 7
        ' 
        ' nudAl100
        ' 
        nudAl100.Location = New Point(1068, 286)
        nudAl100.Name = "nudAl100"
        nudAl100.Size = New Size(120, 23)
        nudAl100.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(929, 228)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 15)
        Label1.TabIndex = 9
        Label1.Text = "mañana"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(929, 272)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 15)
        Label2.TabIndex = 9
        Label2.Text = "tarde"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(929, 312)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 15)
        Label3.TabIndex = 9
        Label3.Text = "noche"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(1068, 272)
        Label5.Name = "Label5"
        Label5.Size = New Size(39, 15)
        Label5.TabIndex = 9
        Label5.Text = "Al 100"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rdbFranco)
        GroupBox1.Controls.Add(rdbNoche)
        GroupBox1.Controls.Add(rdbTarde)
        GroupBox1.Controls.Add(rdbMañana)
        GroupBox1.Location = New Point(929, 53)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(78, 162)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        ' 
        ' rdbFranco
        ' 
        rdbFranco.AutoSize = True
        rdbFranco.Location = New Point(6, 100)
        rdbFranco.Name = "rdbFranco"
        rdbFranco.Size = New Size(61, 19)
        rdbFranco.TabIndex = 11
        rdbFranco.TabStop = True
        rdbFranco.Text = "Franco"
        rdbFranco.UseVisualStyleBackColor = True
        ' 
        ' rdbNoche
        ' 
        rdbNoche.AutoSize = True
        rdbNoche.Location = New Point(6, 75)
        rdbNoche.Name = "rdbNoche"
        rdbNoche.Size = New Size(58, 19)
        rdbNoche.TabIndex = 11
        rdbNoche.TabStop = True
        rdbNoche.Text = "noche"
        rdbNoche.UseVisualStyleBackColor = True
        ' 
        ' rdbTarde
        ' 
        rdbTarde.AutoSize = True
        rdbTarde.Location = New Point(6, 52)
        rdbTarde.Name = "rdbTarde"
        rdbTarde.Size = New Size(52, 19)
        rdbTarde.TabIndex = 11
        rdbTarde.TabStop = True
        rdbTarde.Text = "tarde"
        rdbTarde.UseVisualStyleBackColor = True
        ' 
        ' rdbMañana
        ' 
        rdbMañana.AutoSize = True
        rdbMañana.Location = New Point(6, 27)
        rdbMañana.Name = "rdbMañana"
        rdbMañana.Size = New Size(68, 19)
        rdbMañana.TabIndex = 11
        rdbMañana.TabStop = True
        rdbMañana.Text = "mañana"
        rdbMañana.UseVisualStyleBackColor = True
        ' 
        ' btnCargar
        ' 
        btnCargar.Location = New Point(732, 216)
        btnCargar.Name = "btnCargar"
        btnCargar.Size = New Size(75, 23)
        btnCargar.TabIndex = 11
        btnCargar.Text = "Cargar"
        btnCargar.UseVisualStyleBackColor = True
        ' 
        ' btnFinalizar
        ' 
        btnFinalizar.Location = New Point(732, 399)
        btnFinalizar.Name = "btnFinalizar"
        btnFinalizar.Size = New Size(75, 23)
        btnFinalizar.TabIndex = 11
        btnFinalizar.Text = "Finalizar"
        btnFinalizar.UseVisualStyleBackColor = True
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(1068, 246)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(120, 23)
        NumericUpDown1.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(1068, 228)
        Label6.Name = "Label6"
        Label6.Size = New Size(46, 15)
        Label6.TabIndex = 9
        Label6.Text = "Feriado"
        ' 
        ' chbAl100
        ' 
        chbAl100.AutoSize = True
        chbAl100.Location = New Point(1039, 105)
        chbAl100.Name = "chbAl100"
        chbAl100.Size = New Size(58, 19)
        chbAl100.TabIndex = 12
        chbAl100.Text = "Al 100"
        chbAl100.UseVisualStyleBackColor = True
        ' 
        ' chbFeriado
        ' 
        chbFeriado.AutoSize = True
        chbFeriado.Location = New Point(1039, 130)
        chbFeriado.Name = "chbFeriado"
        chbFeriado.Size = New Size(65, 19)
        chbFeriado.TabIndex = 12
        chbFeriado.Text = "Feriado"
        chbFeriado.UseVisualStyleBackColor = True
        ' 
        ' nudFranco
        ' 
        nudFranco.Location = New Point(929, 370)
        nudFranco.Name = "nudFranco"
        nudFranco.Size = New Size(120, 23)
        nudFranco.TabIndex = 7
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(929, 353)
        Label7.Name = "Label7"
        Label7.Size = New Size(41, 15)
        Label7.TabIndex = 9
        Label7.Text = "franco"
        ' 
        ' btnCargarFyE
        ' 
        btnCargarFyE.Location = New Point(1039, 155)
        btnCargarFyE.Name = "btnCargarFyE"
        btnCargarFyE.Size = New Size(75, 23)
        btnCargarFyE.TabIndex = 11
        btnCargarFyE.Text = "Cargar"
        btnCargarFyE.UseVisualStyleBackColor = True
        ' 
        ' wfmCalculosHT
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1299, 550)
        Controls.Add(chbFeriado)
        Controls.Add(chbAl100)
        Controls.Add(btnFinalizar)
        Controls.Add(btnCargarFyE)
        Controls.Add(btnCargar)
        Controls.Add(GroupBox1)
        Controls.Add(Label5)
        Controls.Add(Label7)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label6)
        Controls.Add(Label1)
        Controls.Add(rtbResumen)
        Controls.Add(nudAl100)
        Controls.Add(nudFranco)
        Controls.Add(nudNoche)
        Controls.Add(NumericUpDown1)
        Controls.Add(nudTarde)
        Controls.Add(nudMañana)
        Controls.Add(btnPintar)
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
        CType(nudMañana, ComponentModel.ISupportInitialize).EndInit()
        CType(nudTarde, ComponentModel.ISupportInitialize).EndInit()
        CType(nudNoche, ComponentModel.ISupportInitialize).EndInit()
        CType(nudAl100, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(nudFranco, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnPintar As Button
    Friend WithEvents nudMañana As NumericUpDown
    Friend WithEvents rtbResumen As RichTextBox
    Friend WithEvents nudTarde As NumericUpDown
    Friend WithEvents nudNoche As NumericUpDown
    Friend WithEvents nudAl100 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbFranco As RadioButton
    Friend WithEvents rdbNoche As RadioButton
    Friend WithEvents rdbTarde As RadioButton
    Friend WithEvents rdbMañana As RadioButton
    Friend WithEvents btnCargar As Button
    Friend WithEvents btnFinalizar As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents chbAl100 As CheckBox
    Friend WithEvents chbFeriado As CheckBox
    Friend WithEvents nudFranco As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCargarFyE As Button
End Class
