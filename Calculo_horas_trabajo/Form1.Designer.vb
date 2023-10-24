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
        components = New ComponentModel.Container()
        cldMes = New MonthCalendar()
        nudMañana = New NumericUpDown()
        nudTarde = New NumericUpDown()
        nudNoche = New NumericUpDown()
        nudAl100 = New NumericUpDown()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        GroupBox1 = New GroupBox()
        btnCargarDias = New Button()
        rdbFranco = New RadioButton()
        rdbNoche = New RadioButton()
        rdbTarde = New RadioButton()
        rdbMañana = New RadioButton()
        btnFinalizar = New Button()
        nudFeriado = New NumericUpDown()
        Label6 = New Label()
        nudFranco = New NumericUpDown()
        Label7 = New Label()
        dgvTrabajados = New DataGridView()
        clm_fecha = New DataGridViewTextBoxColumn()
        clm_turno = New DataGridViewTextBoxColumn()
        clm_feriado = New DataGridViewCheckBoxColumn()
        clm_al100 = New DataGridViewCheckBoxColumn()
        btnLimpiar = New Button()
        btnBorrar = New Button()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        CType(nudMañana, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudTarde, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudNoche, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudAl100, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(nudFeriado, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudFranco, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvTrabajados, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cldMes
        ' 
        cldMes.BackColor = SystemColors.ControlLightLight
        cldMes.Location = New Point(34, 35)
        cldMes.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        cldMes.MaxSelectionCount = 31
        cldMes.MinDate = New Date(2023, 1, 1, 0, 0, 0, 0)
        cldMes.Name = "cldMes"
        cldMes.TabIndex = 4
        cldMes.TitleBackColor = SystemColors.ActiveBorder
        ' 
        ' nudMañana
        ' 
        nudMañana.Enabled = False
        nudMañana.Location = New Point(463, 269)
        nudMañana.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        nudMañana.Name = "nudMañana"
        nudMañana.Size = New Size(120, 23)
        nudMañana.TabIndex = 7
        ' 
        ' nudTarde
        ' 
        nudTarde.Enabled = False
        nudTarde.Location = New Point(463, 309)
        nudTarde.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        nudTarde.Name = "nudTarde"
        nudTarde.Size = New Size(120, 23)
        nudTarde.TabIndex = 7
        ' 
        ' nudNoche
        ' 
        nudNoche.Enabled = False
        nudNoche.Location = New Point(463, 350)
        nudNoche.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        nudNoche.Name = "nudNoche"
        nudNoche.Size = New Size(120, 23)
        nudNoche.TabIndex = 7
        ' 
        ' nudAl100
        ' 
        nudAl100.Enabled = False
        nudAl100.Location = New Point(602, 309)
        nudAl100.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        nudAl100.Name = "nudAl100"
        nudAl100.Size = New Size(120, 23)
        nudAl100.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(463, 251)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 15)
        Label1.TabIndex = 9
        Label1.Text = "mañana"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(463, 295)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 15)
        Label2.TabIndex = 9
        Label2.Text = "tarde"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(463, 335)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 15)
        Label3.TabIndex = 9
        Label3.Text = "noche"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(602, 295)
        Label5.Name = "Label5"
        Label5.Size = New Size(39, 15)
        Label5.TabIndex = 9
        Label5.Text = "Al 100"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnCargarDias)
        GroupBox1.Controls.Add(rdbFranco)
        GroupBox1.Controls.Add(rdbNoche)
        GroupBox1.Controls.Add(rdbTarde)
        GroupBox1.Controls.Add(rdbMañana)
        GroupBox1.Location = New Point(319, 35)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(138, 162)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        ' 
        ' btnCargarDias
        ' 
        btnCargarDias.Location = New Point(6, 133)
        btnCargarDias.Name = "btnCargarDias"
        btnCargarDias.Size = New Size(120, 23)
        btnCargarDias.TabIndex = 15
        btnCargarDias.Text = "CARGAR DIAS"
        btnCargarDias.UseVisualStyleBackColor = True
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
        ' btnFinalizar
        ' 
        btnFinalizar.Location = New Point(463, 220)
        btnFinalizar.Name = "btnFinalizar"
        btnFinalizar.Size = New Size(75, 23)
        btnFinalizar.TabIndex = 11
        btnFinalizar.Text = "Finalizar"
        btnFinalizar.UseVisualStyleBackColor = True
        ' 
        ' nudFeriado
        ' 
        nudFeriado.Enabled = False
        nudFeriado.Location = New Point(602, 269)
        nudFeriado.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        nudFeriado.Name = "nudFeriado"
        nudFeriado.Size = New Size(120, 23)
        nudFeriado.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(602, 251)
        Label6.Name = "Label6"
        Label6.Size = New Size(46, 15)
        Label6.TabIndex = 9
        Label6.Text = "Feriado"
        ' 
        ' nudFranco
        ' 
        nudFranco.Enabled = False
        nudFranco.Location = New Point(602, 350)
        nudFranco.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        nudFranco.Name = "nudFranco"
        nudFranco.Size = New Size(120, 23)
        nudFranco.TabIndex = 7
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(602, 335)
        Label7.Name = "Label7"
        Label7.Size = New Size(41, 15)
        Label7.TabIndex = 9
        Label7.Text = "franco"
        ' 
        ' dgvTrabajados
        ' 
        dgvTrabajados.AllowUserToAddRows = False
        dgvTrabajados.AllowUserToDeleteRows = False
        dgvTrabajados.AllowUserToResizeColumns = False
        dgvTrabajados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTrabajados.Columns.AddRange(New DataGridViewColumn() {clm_fecha, clm_turno, clm_feriado, clm_al100})
        dgvTrabajados.Location = New Point(34, 203)
        dgvTrabajados.Name = "dgvTrabajados"
        dgvTrabajados.RowTemplate.Height = 25
        dgvTrabajados.Size = New Size(423, 317)
        dgvTrabajados.TabIndex = 13
        ' 
        ' clm_fecha
        ' 
        clm_fecha.HeaderText = "FECHA"
        clm_fecha.Name = "clm_fecha"
        clm_fecha.ReadOnly = True
        clm_fecha.Width = 150
        ' 
        ' clm_turno
        ' 
        clm_turno.HeaderText = "TURNO"
        clm_turno.Name = "clm_turno"
        clm_turno.ReadOnly = True
        ' 
        ' clm_feriado
        ' 
        clm_feriado.HeaderText = "FERIADO"
        clm_feriado.Name = "clm_feriado"
        clm_feriado.Width = 65
        ' 
        ' clm_al100
        ' 
        clm_al100.HeaderText = "Dias Al 100"
        clm_al100.Name = "clm_al100"
        clm_al100.Width = 65
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(463, 497)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(120, 23)
        btnLimpiar.TabIndex = 14
        btnLimpiar.Text = "LIMPIAR"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnBorrar
        ' 
        btnBorrar.Location = New Point(463, 409)
        btnBorrar.Name = "btnBorrar"
        btnBorrar.Size = New Size(120, 23)
        btnBorrar.TabIndex = 15
        btnBorrar.Text = "Borrar Elemento"
        btnBorrar.UseVisualStyleBackColor = True
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' wfmCalculosHT
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(740, 538)
        Controls.Add(btnBorrar)
        Controls.Add(btnLimpiar)
        Controls.Add(dgvTrabajados)
        Controls.Add(btnFinalizar)
        Controls.Add(GroupBox1)
        Controls.Add(Label5)
        Controls.Add(Label7)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label6)
        Controls.Add(Label1)
        Controls.Add(nudAl100)
        Controls.Add(nudFranco)
        Controls.Add(nudNoche)
        Controls.Add(nudFeriado)
        Controls.Add(nudTarde)
        Controls.Add(nudMañana)
        Controls.Add(cldMes)
        Name = "wfmCalculosHT"
        Text = "Calculadora de Horas Trabajadas V3.0"
        CType(nudMañana, ComponentModel.ISupportInitialize).EndInit()
        CType(nudTarde, ComponentModel.ISupportInitialize).EndInit()
        CType(nudNoche, ComponentModel.ISupportInitialize).EndInit()
        CType(nudAl100, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(nudFeriado, ComponentModel.ISupportInitialize).EndInit()
        CType(nudFranco, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvTrabajados, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents cldMes As MonthCalendar
    Friend WithEvents nudMañana As NumericUpDown
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
    Friend WithEvents btnFinalizar As Button
    Friend WithEvents nudFeriado As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents nudFranco As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvTrabajados As DataGridView
    Friend WithEvents btnCargarDias As Button
    Friend WithEvents clm_fecha As DataGridViewTextBoxColumn
    Friend WithEvents clm_turno As DataGridViewTextBoxColumn
    Friend WithEvents clm_feriado As DataGridViewCheckBoxColumn
    Friend WithEvents clm_al100 As DataGridViewCheckBoxColumn
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class
