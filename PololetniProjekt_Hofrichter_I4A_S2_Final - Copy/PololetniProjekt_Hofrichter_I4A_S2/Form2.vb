Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dospely As Double 'deklarace proměnných
        Dim dite As Double
        Dim vyscena As Double
        Dim cenapred As Double

        Try
            dite = TextBox2.Text 'naplnění proměnných
            dospely = TextBox1.Text
            If dite > -1 And dospely > -1 Then 'kontrola pro negované hodnoty
                If dite > 0 And dite < 4 And dospely = 2 Then 'podmínka pro rodinnou slevu
                    CheckBox1.Checked = False
                    vyscena = dospely * 200 + dite * 100 'výpočet ceny před zlevněním
                    vyscena = vyscena * 0.5 'výpočet ceny se slevou
                    cenapred = (dospely * 200 + dite * 100) - vyscena 'výpočet slevové částky
                    MessageBox.Show("Počet vstupenek je: " & dospely + dite & ". Dětí je " & dite & ", dospělých je " & dospely & ". Rodinná sleva: -50%, v korunách: " & cenapred & "Kč" & ". Celková cena je: " & vyscena & "Kč")
                ElseIf dospely + dite > 9 And dospely + dite < 21 Then 'sleva pro 10-20 lidí
                    If CheckBox1.Checked Then
                        vyscena = dospely * 200 + dite * 100
                        vyscena = vyscena * 0.8
                        cenapred = (dospely * 200 + dite * 100) - vyscena
                        MessageBox.Show("Počet vstupenek je: " & dospely + dite & ". Dětí je " & dite & ", dospělých je " & dospely & ". Studentská sleva: -20%, v korunách: " & cenapred & "Kč" & ". Celková cena je: " & vyscena & "Kč")
                    Else
                        vyscena = dospely * 200 + dite * 100
                        vyscena = vyscena * 0.9
                        cenapred = (dospely * 200 + dite * 100) - vyscena
                        MessageBox.Show("Počet vstupenek je: " & dospely + dite & ". Dětí je " & dite & ", dospělých je " & dospely & ". Skupina mezi 10-20 lidmi sleva: -10%, v korunách: " & cenapred & "Kč" & ". Celková cena je: " & vyscena & "Kč")
                    End If
                ElseIf dospely + dite > 20 Then 'sleva pro 20+ lidí
                        If CheckBox1.Checked Then
                            vyscena = dospely * 200 + dite * 100
                            vyscena = vyscena * 0.8
                            cenapred = (dospely * 200 + dite * 100) - vyscena
                            MessageBox.Show("Počet vstupenek je: " & dospely + dite & ". Dětí je " & dite & ", dospělých je " & dospely & ". Studentská sleva: -20%, v korunách: " & cenapred & "Kč" & ". Celková cena je: " & vyscena & "Kč")
                        Else
                            vyscena = dospely * 200 + dite * 100
                            vyscena = vyscena * 0.85
                            cenapred = (dospely * 200 + dite * 100) - vyscena
                            MessageBox.Show("Počet vstupenek je: " & dospely + dite & ". Dětí je " & dite & ", dospělých je " & dospely & ". Skupina nad 20 lidí sleva: -15%, v korunách: " & cenapred & "Kč" & ". Celková cena je: " & vyscena & "Kč")
                        End If
                    ElseIf CheckBox1.Checked Then 'sleva pro studenta
                        vyscena = dospely * 200 + dite * 100
                        vyscena = vyscena * 0.8
                        cenapred = (dospely * 200 + dite * 100) - vyscena
                        MessageBox.Show("Počet vstupenek je: " & dospely + dite & ". Dětí je " & dite & ", dospělých je " & dospely & ". Studentská sleva: -20%, v korunách: " & cenapred & "Kč" & ". Celková cena je: " & vyscena & "Kč")
                    Else
                        vyscena = dospely * 200 + dite * 100 'bez slevy
                    MessageBox.Show("Počet vstupenek je: " & dospely + dite & ". Dětí je " & dite & ", dospělých je " & dospely & ". Bez slevy. Celková cena je: " & vyscena & "Kč")
                End If
            Else
                MessageBox.Show("Musí příjít alespoň jeden zákazník.")
            End If
        Catch ex As Exception
            MessageBox.Show("Chyba!") 'pro vychytání chyb
        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = (Now.Day & "." & Now.Month & "." & Now.Year) 'aktualní datum
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit() 'vypnutí aplikace
    End Sub
End Class