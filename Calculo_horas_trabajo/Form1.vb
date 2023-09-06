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
                If rtbResumen.Text <> "" Then
                    rtbResumen.Text = rtbResumen.Text & vbCrLf & cldMes.SelectionStart.ToString("dd/MM/yyyy") & " - " & cldMes.SelectionEnd.ToString("dd/MM/yyyy") & "; Mañana"
                Else
                    rtbResumen.Text = cldMes.SelectionStart.ToString("dd/MM/yyyy") & " - " & cldMes.SelectionEnd.ToString("dd/MM/yyyy") & "; Mañana"
                End If
                nudMañana.Value = nudMañana.Value + DateDiff(DateInterval.Day, cldMes.SelectionStart, cldMes.SelectionEnd) + 1


            Case rdbTarde.Checked
                'MsgBox("tarde")
                If rtbResumen.Text <> "" Then
                    rtbResumen.Text = rtbResumen.Text & vbCrLf & cldMes.SelectionStart.ToString("dd/MM/yyyy") & " - " & cldMes.SelectionEnd.ToString("dd/MM/yyyy") & "; Tarde"
                Else
                    rtbResumen.Text = cldMes.SelectionStart.ToString("dd/MM/yyyy") & " - " & cldMes.SelectionEnd.ToString("dd/MM/yyyy") & "; Tarde"
                End If

                nudTarde.Value = nudTarde.Value + DateDiff(DateInterval.Day, cldMes.SelectionStart, cldMes.SelectionEnd) + 1


            Case rdbNoche.Checked
                ' MsgBox("noche")
                If rtbResumen.Text <> "" Then
                    rtbResumen.Text = rtbResumen.Text & vbCrLf & cldMes.SelectionStart.ToString("dd/MM/yyyy") & " - " & cldMes.SelectionEnd.ToString("dd/MM/yyyy") & "; Noche"
                Else
                    rtbResumen.Text = cldMes.SelectionStart.ToString("dd/MM/yyyy") & " - " & cldMes.SelectionEnd.ToString("dd/MM/yyyy") & "; Noche"
                End If
                nudNoche.Value = nudNoche.Value + DateDiff(DateInterval.Day, cldMes.SelectionStart, cldMes.SelectionEnd) + 1


            Case rdbFranco.Checked
                'MsgBox("franco")
                If rtbResumen.Text <> "" Then
                    rtbResumen.Text = rtbResumen.Text & vbCrLf & cldMes.SelectionStart.ToString("dd/MM/yyyy") & " - " & cldMes.SelectionEnd.ToString("dd/MM/yyyy") & "; Franco"
                Else
                    rtbResumen.Text = cldMes.SelectionStart.ToString("dd/MM/yyyy") & " - " & cldMes.SelectionEnd.ToString("dd/MM/yyyy") & "; Franco"
                End If
                nudFranco.Value = nudFranco.Value + DateDiff(DateInterval.Day, cldMes.SelectionStart, cldMes.SelectionEnd) + 1


            Case Else
                MsgBox("nothing")
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
End Class
