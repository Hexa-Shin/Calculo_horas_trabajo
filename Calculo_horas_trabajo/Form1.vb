Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports iText.Kernel.Pdf
Imports iText.Layout
Imports iText.Layout.Element
Imports iText.Layout.Properties
Imports iTextSharp.tool.xml.html.table


Module variables_globales
    Public t_comienzo, t_dias_trabajados, t_horas_nocturnas, t_adicionales_100, t_adicionales_feriado As String

End Module


Public Class wfmCalculosHT
    Private Sub btnCargarDias_Click(sender As Object, e As EventArgs) Handles btnCargarDias.Click
        Dim fecha As String = "dd,MM,yyyy"
        Dim fechaExistente As Boolean = False
        Dim difdias, cantelementos As Integer

        cantelementos = dgvTrabajados.RowCount
        difdias = DateDiff(DateInterval.Day, cldMes.SelectionStart, cldMes.SelectionEnd)

        If (difdias + 1 + cantelementos) <= 31 Then


            Select Case True
                Case rdbMañana.Checked
                    For i As Integer = 0 To difdias

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

            dgvTrabajados.Sort(dgvTrabajados.Columns("clm_fecha"), System.ComponentModel.ListSortDirection.Ascending)

        Else
            MsgBox("El DataGrid puede tener hasta 31 elementos, asegurese de haber seleccionado los dias correctamente")
        End If


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

            Select Case turno
                Case "Mañana"
                    nudMañana.Value = nudMañana.Value + 1

                Case "Tarde"
                    nudTarde.Value = nudTarde.Value + 1

                Case "Noche"
                    nudNoche.Value = nudNoche.Value + 1

                    'verifica si el dia siguiente hay un feriado, porque pasando las 23:59 ya cuenta las horas de feriado del dia siguiente
                    If (i + 1) <= dgvTrabajados.Rows.Count - 1 Then 'verifica que exista una fila siguiente a la actualmente selecionada
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

        t_comienzo = "el recibo de sueldo debe decir: "
        t_dias_trabajados = "Dias Trabajado: 30"
        t_horas_nocturnas = "Horas Nocturnas: " & Hnocturnas
        t_adicionales_100 = "Adicional Horas al 100: " & Hal100
        t_adicionales_feriado = "Adicional Horas Feriado: " & Hferiado

        'MsgBox(Info_de_trabajo)
        crear_pdf()



    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        rdbMañana.Checked = False
        rdbTarde.Checked = False
        rdbNoche.Checked = False
        rdbFranco.Checked = False

        nudMañana.Value = 0
        nudTarde.Value = 0
        nudNoche.Value = 0
        nudFeriado.Value = 0
        nudAl100.Value = 0
        nudFranco.Value = 0

        dgvTrabajados.Rows.Clear()

        cldMes.SelectionStart = DateTime.Now

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If dgvTrabajados.SelectedRows.Count > 0 Then
            ' Elimina las filas seleccionadas del DataGridView
            For Each fila As DataGridViewRow In dgvTrabajados.SelectedRows
                dgvTrabajados.Rows.Remove(fila)
            Next
        Else
            MessageBox.Show("No hay filas seleccionadas para eliminar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        crear_pdf()


    End Sub

    Sub crear_pdf()

        'vamos a encontrar la ruta donde guardar el PDF
        'Muestro el SaveFileDialog y guardo el contenido del PDF
        Dim SaveFileDialog As New SaveFileDialog
        Dim ruta As String
        With SaveFileDialog
            .Title = "Guardar"
            'Selecciono la ruta de generacion por defecto
            'En todo los demás casos uso la ruta por defecto
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            .Filter = "Arcivos pdf (*.pdf)|*.pdf"
            .FileName = "Calculo_Horarios"
            .OverwritePrompt = True
            .CheckPathExists = True
        End With

        If SaveFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ruta = SaveFileDialog.FileName
        Else
            ruta = String.Empty
            Exit Sub
        End If

        'Vamos a generar el PDF
        Try
            'Creamos un documento
            Dim document As New iTextSharp.text.Document()

            'ahora configuramos la hoja
            document.PageSize.Rotate()

            'ahora algunas propiedades
            document.AddAuthor("Shin")
            document.AddTitle("crear pdf")

            'Dim writer As PdfWriter = PdfWriter.GetInstance(document, New System.IO.FileStream(ruta, System.IO.FileMode.Create))
            Using writer As pdf.PdfWriter = iText.Kernel.Pdf.PdfWriter.GetInstance(document, New FileStream(ruta, FileMode.Create))

                'abrimos el documento para empezar a escribir
                document.Open()

                agregar_contenido(document)

                'y lo cerramos
                document.Close()

                MsgBox("PDF generado")

            End Using
        Catch ex As Exception
            MessageBox.Show("Error en la generacion del PDF", "Error", MessageBoxButtons.OK)
        End Try

    End Sub

    Sub agregar_contenido(document As iTextSharp.text.Document)

        'crear contenido
        Dim contenido As String = t_comienzo & vbCrLf & vbCrLf &
                                  t_dias_trabajados & vbCrLf &
                                  t_horas_nocturnas & vbCrLf &
                                  t_adicionales_100 & vbCrLf &
                                  t_adicionales_feriado


        Dim tabla As iText.Layout.Element.Table = New iText.Layout.Element.Table(UnitValue.CreatePercentArray(3)).UseAllAvailableWidth()

        ' Añadir celdas a la tabla
        tabla.AddHeaderCell(New Cell().Add(New iText.Layout.Element.Paragraph("Encabezado 1")))
        tabla.AddHeaderCell(New Cell().Add(New iText.Layout.Element.Paragraph("Encabezado 2")))
        tabla.AddHeaderCell(New Cell().Add(New iText.Layout.Element.Paragraph("Encabezado 3")))

        tabla.AddCell(New Cell().Add(New iText.Layout.Element.Paragraph("Celda 1")))
        tabla.AddCell(New Cell().Add(New iText.Layout.Element.Paragraph("Celda 2")))
        tabla.AddCell(New Cell().Add(New iText.Layout.Element.Paragraph("Celda 3")))

        tabla.AddCell(New Cell().Add(New iText.Layout.Element.Paragraph("Celda 4")))
        tabla.AddCell(New Cell().Add(New iText.Layout.Element.Paragraph("Celda 5")))
        tabla.AddCell(New Cell().Add(New iText.Layout.Element.Paragraph("Celda 6")))

        ' Añadir tabla al documento
        PdfDocument.Add(tabla)

        'configurar el tipo de fuente y tamaño
        Dim font As Font = New Font(Font.FontFamily.HELVETICA, 12)

        'crear parrafo
        Dim parrafo As New iTextSharp.text.Paragraph(contenido, font)
        document.Add(parrafo)

    End Sub

End Class
