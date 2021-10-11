Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        If MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "salir") = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim placa As String = txtPlaca.Text
        Dim marca As String = cbxMarca.Text
        Dim tarjeta As Double = 0
        Dim ejectivo As Double = 0
        Dim diasAl As Double = 0
        Dim pagoParcial As Double = 0
        Dim pagoFinal As Double = 0

        If (CheckBox1.Checked) Or (CheckBox2.Checked) Then
            If CheckBox1.Checked Then
                If (IsNumeric(txtTarjeta.Text)) Then
                    tarjeta = Val(txtTarjeta.Text)
                End If
            End If

            If CheckBox2.Checked Then
                If (IsNumeric(txtEfectivo.Text)) Then
                    ejectivo = Val(txtEfectivo.Text)
                End If
            End If

            If (tarjeta + ejectivo) <> 100 Then
                MsgBox("Los percentajes no esta bien para la forma de pago")
                Return
            End If
        Else
            MsgBox("Seleccione tipo de pago")
        End If

        If (IsNumeric(txtDias.Text)) Then
            diasAl = Val(txtDias.Text)
        Else
            MsgBox("Ingrese un valor valido para los dias de alquiler")
        End If

        Select Case cbxMarca.Text
            Case "Honda"
                pagoParcial = diasAl * 250
            Case "Mercedes Benz"
                pagoParcial = diasAl * 450
            Case "Toyota"
                pagoParcial = diasAl * 325
            Case "Mazda"
                pagoParcial = diasAl * 300
            Case Else

        End Select

        Placas(FILA) = placa
        Marcas(FILA) = cbxMarca.Text
        Dias(FILA) = diasAl
        pagosParciales(FILA) = pagoParcial

        If tarjeta = 0 Then
            pagoFinal = pagoParcial * 0.95
        End If
        If ejectivo = 0 Then
            pagoFinal = pagoParcial * 1.025
        End If
        FILA = FILA + 1
        PagosTotales(FILA) = pagoFinal
        printList()
    End Sub

    Sub printList()
        Dim X As Byte
        lstDias.Items.Clear()
        lstMarca.Items.Clear()
        lstPagoFinal.Items.Clear()
        lstPagoParcial.Items.Clear()
        lstPlacas.Items.Clear()

        For X = 0 To 6
            If Placas(X) <> Nothing Then
                lstMarca.Items.Add((Marcas(X)))
                lstDias.Items.Add((Dias(X)))
                lstPagoFinal.Items.Add((PagosTotales(X)))
                lstPagoParcial.Items.Add((pagosParciales(X)))
                lstPlacas.Items.Add((Placas(X)))
            Else
                Exit For
            End If
        Next X

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            txtTarjeta.Visible = True
            txtTarjeta.Focus()
        Else
            txtTarjeta.Clear()
            txtTarjeta.Visible = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked) Then
            txtEfectivo.Visible = True
            txtEfectivo.Focus()
        Else
            txtEfectivo.Clear()
            txtEfectivo.Visible = False
        End If
    End Sub

    Private Sub btnBodega_Click(sender As Object, e As EventArgs) Handles btnBodega.Click
        Dim J As Byte
        FILA = 0
        For J = 0 To 6
            Placas(J) = Nothing
            Marcas(J) = Nothing
            Dias(J) = Nothing
            pagosParciales(J) = Nothing
            pagosParciales(J) = Nothing
        Next J

        lstDias.Items.Clear()
        lstMarca.Items.Clear()
        lstPagoFinal.Items.Clear()
        lstPagoParcial.Items.Clear()
        lstPlacas.Items.Clear()
        txtDias.Text = ""
        txtEfectivo.Text = ""
        txtNit.Text = ""
        txtPlaca.Text = ""
        txtTarjeta.Text = ""
    End Sub
End Class
