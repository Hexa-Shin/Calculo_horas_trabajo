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
End Class
