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

    Private Sub wfmCalculosHT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        cldMes.SelectionRange.Start = txt2.Text
        cldMes.SelectionRange.End = txt2.Text
        cldMes.TodayDate = txt2.Text

        txt3.Text = cldMes.TodayDate.ToString
    End Sub
End Class
