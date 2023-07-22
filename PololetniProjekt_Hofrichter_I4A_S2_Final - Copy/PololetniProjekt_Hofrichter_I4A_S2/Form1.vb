Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pjmeno As String 'deklarace proměnných
        Dim heslo As String
        Dim zadanepj As String
        Dim zadaneh As String

        heslo = "h" 'naplnění proměnných - správné přihlašovací údaje
        pjmeno = "U"
        zadanepj = TextBox1.Text
        zadaneh = TextBox2.Text

        If zadaneh = heslo And zadanepj = pjmeno Then 'kontrola správných přihlašovacích údajů a případně propuštění do druhého formu
            MsgBox("Vítejte!")
            Me.Visible = False
            Form2.Visible = True
        Else
            MsgBox("Špátné přihlašovací údaje!")
        End If
    End Sub
End Class
