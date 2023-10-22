Public Class wfmCalculosHT
    Private Sub btncalculo_Click(sender As Object, e As EventArgs) Handles btncalculo.Click

        Dim Hnocturnas, Hal100, Tmañana, Ttarde, Tnoche, Hferiado, Dal100 As Integer

        Tmañana = txtTmañana.Text
        Ttarde = TxtTtarde.Text
        Tnoche = txtTnoche.Text
        Hferiado = txtDferiado.Text
        Dal100 = nudD100.Value


        Hnocturnas = (Ttarde * 2) + (Tnoche * 8)

        Hal100 = Dal100 * 8

        MsgBox("el recibo de sueldo debe decir: " & vbCrLf &
               "Dias Trabajado: 30" & vbCrLf &
               "Adicional Horas Nocturnas: " & Hnocturnas & vbCrLf &
               "Adicional Horas al 100: " & Hal100)

    End Sub

    Private Sub cldMes_DateChanged(sender As Object, e As DateRangeEventArgs) Handles cldMes.DateChanged
        'txt1.Text = cldMes.ToString
        txt1.Text = cldMes.SelectionRange.ToString


    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        cldMes.SelectionRange.Start = txt2.Text
        cldMes.SelectionRange.End = txt2.Text
        cldMes.TodayDate = txt2.Text

        txt3.Text = cldMes.TodayDate.ToString
    End Sub

    '  Private Sub btnPintar_Click(sender As Object, e As EventArgs) Handles btnPintar.Click
    '      cldMes.ForeColor = System.Drawing.Color.Red
    '     cldMes.BackColor = System.Drawing.Color.Green
    '    cldMes.TrailingForeColor = System.Drawing.Color.Yellow
    '   btnPintar.BackColor = Color.Green


    'End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click

        'MsgBox("el dia siguente es: " & cldMes.SelectionRange.Start.AddDays(1))
        Select Case True

            Case rdbMañana.Checked
                'MsgBox("mañana")
                For i As Integer = 0 To DateDiff(DateInterval.Day, cldMes.SelectionStart, cldMes.SelectionEnd)
                    rtbResumen.Text = rtbResumen.Text & cldMes.SelectionStart.AddDays(i) & "; Mañana" & vbCrLf
                Next

                nudMañana.Value = nudMañana.Value + DateDiff(DateInterval.Day, cldMes.SelectionStart, cldMes.SelectionEnd) + 1


            Case rdbTarde.Checked
                For i As Integer = 0 To DateDiff(DateInterval.Day, cldMes.SelectionStart, cldMes.SelectionEnd)
                    rtbResumen.Text = rtbResumen.Text & cldMes.SelectionStart.AddDays(i) & "; Tarde" & vbCrLf
                Next

                nudTarde.Value = nudTarde.Value + DateDiff(DateInterval.Day, cldMes.SelectionStart, cldMes.SelectionEnd) + 1


            Case rdbNoche.Checked
                For i As Integer = 0 To DateDiff(DateInterval.Day, cldMes.SelectionStart, cldMes.SelectionEnd)
                    rtbResumen.Text = rtbResumen.Text & cldMes.SelectionStart.AddDays(i) & "; Noche" & vbCrLf
                Next

                nudNoche.Value = nudNoche.Value + DateDiff(DateInterval.Day, cldMes.SelectionStart, cldMes.SelectionEnd) + 1


            Case rdbFranco.Checked
                For i As Integer = 0 To DateDiff(DateInterval.Day, cldMes.SelectionStart, cldMes.SelectionEnd)
                    rtbResumen.Text = rtbResumen.Text & cldMes.SelectionStart.AddDays(i) & "; Franco" & vbCrLf
                Next

                nudFranco.Value = nudFranco.Value + DateDiff(DateInterval.Day, cldMes.SelectionStart, cldMes.SelectionEnd) + 1

            Case Else
                MsgBox("nothing")

                'For i As Integer = 0 To DateDiff(DateInterval.Day, cldMes.SelectionStart, cldMes.SelectionEnd)
                'MsgBox(cldMes.SelectionStart.AddDays(i))
                'Next

        End Select

    End Sub

    Private Sub btnCargarFyE_Click(sender As Object, e As EventArgs) Handles btnCargarFyE.Click


        If chbFeriado.Checked Then
            rtbResumen.Text = rtbResumen.Text & vbCrLf & vbCrLf & cldMes.SelectionStart.ToString("dd/MM/yyyy") & ": Feriado"
            If chbAl100.Checked Then
                rtbResumen.Text = rtbResumen.Text & vbCrLf & cldMes.SelectionStart.ToString("dd/MM/yyyy") & ": Al 100"
            End If
        End If

        If chbAl100.Checked And chbFeriado.Checked Then
            rtbResumen.Text = rtbResumen.Text & vbCrLf & vbCrLf & cldMes.SelectionStart.ToString("dd/MM/yyyy") & ": Al 100"
        End If
    End Sub

    Private Sub btnCargarDias_Click(sender As Object, e As EventArgs) Handles btnCargarDias.Click
        Dim fecha As String = "dd,MM,yyyy"
        Dim fechaExistente As Boolean = False


        Select Case True
            Case rdbMañana.Checked
                For i As Integer = 0 To DateDiff(DateInterval.Day, cldMes.SelectionStart, cldMes.SelectionEnd)



                    fecha = cldMes.SelectionStart.AddDays(i)

                    ' Verifica si la fecha ya existe en el DataGridView
                    For Each fila As DataGridViewRow In dgvTrabajados.Rows
                        If Not fila.IsNewRow Then
                            Dim fechaCelda As Date
                            If Date.TryParse(fila.Cells("clm_fecha").Value.ToString(), fechaCelda) Then
                                If fechaCelda = fecha Then
                                    fechaExistente = True
                                    Exit For ' La fecha ya existe, no es necesario seguir buscando
                                End If
                            End If
                        End If
                    Next

                    ' Si la fecha no existe, agrégala al DataGridView
                    If Not fechaExistente Then
                        dgvTrabajados.Rows.Add(fecha, "Mañana")
                    Else
                        MessageBox.Show("La fecha ya existe en el DataGridView.", "Fecha Duplicada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit For
                    End If
                Next

            Case rdbTarde.Checked
                For i As Integer = 0 To DateDiff(DateInterval.Day, cldMes.SelectionStart, cldMes.SelectionEnd)
                    fecha = cldMes.SelectionStart.AddDays(i)

                    ' Verifica si la fecha ya existe en el DataGridView
                    For Each fila As DataGridViewRow In dgvTrabajados.Rows
                        If Not fila.IsNewRow Then
                            Dim fechaCelda As Date
                            If Date.TryParse(fila.Cells("clm_fecha").Value.ToString(), fechaCelda) Then
                                If fechaCelda = fecha Then
                                    fechaExistente = True
                                    Exit For ' La fecha ya existe, no es necesario seguir buscando
                                End If
                            End If
                        End If
                    Next

                    ' Si la fecha no existe, agrégala al DataGridView
                    If Not fechaExistente Then
                        dgvTrabajados.Rows.Add(fecha, "Tarde")
                    Else
                        MessageBox.Show("La fecha ya existe en el DataGridView.", "Fecha Duplicada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit For
                    End If
                Next

            Case rdbNoche.Checked
                For i As Integer = 0 To DateDiff(DateInterval.Day, cldMes.SelectionStart, cldMes.SelectionEnd)
                    fecha = cldMes.SelectionStart.AddDays(i)

                    ' Verifica si la fecha ya existe en el DataGridView
                    For Each fila As DataGridViewRow In dgvTrabajados.Rows
                        If Not fila.IsNewRow Then
                            Dim fechaCelda As Date
                            If Date.TryParse(fila.Cells("clm_fecha").Value.ToString(), fechaCelda) Then
                                If fechaCelda = fecha Then
                                    fechaExistente = True
                                    Exit For ' La fecha ya existe, no es necesario seguir buscando
                                End If
                            End If
                        End If
                    Next

                    ' Si la fecha no existe, agrégala al DataGridView
                    If Not fechaExistente Then
                        dgvTrabajados.Rows.Add(fecha, "Noche")
                    Else
                        MessageBox.Show("La fecha ya existe en el DataGridView.", "Fecha Duplicada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit For
                    End If
                Next

            Case rdbFranco.Checked
                For i As Integer = 0 To DateDiff(DateInterval.Day, cldMes.SelectionStart, cldMes.SelectionEnd)
                    fecha = cldMes.SelectionStart.AddDays(i)

                    ' Verifica si la fecha ya existe en el DataGridView

                    For Each fila As DataGridViewRow In dgvTrabajados.Rows
                        If Not fila.IsNewRow Then
                            Dim fechaCelda As Date
                            If Date.TryParse(fila.Cells("clm_fecha").Value.ToString(), fechaCelda) Then
                                If fechaCelda = fecha Then
                                    fechaExistente = True
                                    Exit For ' La fecha ya existe, no es necesario seguir buscando
                                End If
                            End If
                        End If
                    Next

                    ' Si la fecha no existe, agrégala al DataGridView
                    If Not fechaExistente Then
                        dgvTrabajados.Rows.Add(fecha, "Franco")
                    Else
                        MessageBox.Show("La fecha ya existe en el DataGridView.", "Fecha Duplicada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit For
                    End If
                Next

            Case Else
                MsgBox("Seleccione un turno")
        End Select

    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click

        '*************  AVERIGUAR COMO LIMPIAR UNA SELECCION PARA QUE NO SE REPITAN LA SELECCION********
        Dim cant_elementos As Integer = dgvTrabajados.RowCount
        Dim turno As String
        Dim feriado, al100, sigferiado As Boolean
        Dim Hnocturnas, Hal100, Tmañana, Ttarde, Tnoche, Hferiado, Dal100 As Integer

        Hferiado = 0
        nudAl100.Value = 0
        nudFeriado.Value = 0
        nudFranco.Value = 0
        nudMañana.Value = 0
        nudTarde.Value = 0
        nudNoche.Value = 0


        'Dim indiceFilaSeleccionada As Integer = dgvTrabajados.SelectedRows(0).Index
        'MsgBox(indiceFilaSeleccionada)

        For i As Integer = 0 To cant_elementos - 1
            ' Selecciona la fila completa
            If (i - 1) >= 0 Then
                dgvTrabajados.Rows(i - 1).Selected = False 'deselecciona la fila anterior, para que no se repitan los datos
            End If
            dgvTrabajados.Rows(i).Selected = True

            ' Variables para almacenar los datos de las tres celdas de la fila seleccionada
            turno = dgvTrabajados.Rows(i).Cells(1).Value
            feriado = dgvTrabajados.Rows(i).Cells(2).Value
            al100 = dgvTrabajados.Rows(i).Cells(3).Value

            ' Puedes usar las variables según tus necesidades

            Select Case turno
                Case "Mañana"
                    nudMañana.Value = nudMañana.Value + 1

                Case "Tarde"
                    nudTarde.Value = nudTarde.Value + 1

                Case "Noche"
                    nudNoche.Value = nudNoche.Value + 1

                    'verifica si el dia siguiente hay un feriado, porque pasando las 23:59 ya cuenta las horas de feriado del dia siguiente
                    If (i + 1) <= dgvTrabajados.Rows.Count - 1 Then 'verifica que exista una fila siguiente a la actualmente selecionada
                        MsgBox("hay fila siguiente")
                        dgvTrabajados.Rows(i + 1).Selected = True 'selecciona el siguiente dia
                        sigferiado = dgvTrabajados.Rows(i + 1).Cells(2).Value
                        If sigferiado Then 'verifica si el siguiente dia es dia feriado
                            Hferiado = Hferiado + 6
                        End If
                        dgvTrabajados.Rows(i + 1).Selected = False 'deselecciona el siguiente dia para que no haya problemas en el codigo.
                        'aqui termina de verificar si al siguiente dia hay un feriado para sumarlas.
                    End If


                Case Else
                    nudFranco.Value = nudFranco.Value + 1
            End Select

            If feriado And turno <> "Franco" Then
                nudFeriado.Value = nudFeriado.Value + 1

                Select Case turno
                    Case "Mañana"
                        Hferiado = Hferiado + 8

                    Case "Tarde"
                        Hferiado = Hferiado + 8

                    Case "Noche"
                        Hferiado = Hferiado + 2

                End Select

            End If

            If al100 And turno <> "Franco" Then
                nudAl100.Value = nudAl100.Value + 1
            End If

        Next

        'calculo de horas


        Tmañana = nudMañana.Value
        Ttarde = nudTarde.Value
        Tnoche = nudNoche.Value
        'Hferiado = nudFeriado.Value
        Dal100 = nudAl100.Value


        Hnocturnas = (Ttarde * 2) + (Tnoche * 8)

        Hal100 = Dal100 * 8

        MsgBox("el recibo de sueldo debe decir: " & vbCrLf & vbCrLf &
               "Dias Trabajado: 30" & vbCrLf &
               "Horas Nocturnas: " & Hnocturnas & vbCrLf &
               "Adicional Horas al 100: " & Hal100 & vbCrLf &
               "Adicional Horas Feriado: " & Hferiado)






    End Sub
End Class
