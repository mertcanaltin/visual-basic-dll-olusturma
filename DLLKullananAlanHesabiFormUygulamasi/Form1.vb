Imports alanHesabi ' Add reference İle eklediğim dll dosyamı import ettim
Public Class Form1
    Private Sub KareAlanHesaplaButton_Click(sender As Object, e As EventArgs) Handles KareAlanHesaplaButton.Click
        Dim Alan_Hesap As New alanlar 'dll dosyasındaki class isminden yeni bir tanımlama yaptık 
        Dim Kenar As Decimal = KareKenarTextBox.Text
        Dim Sonuc As Decimal = Alan_Hesap.KareAlan(Kenar) 'tanımladığımız değşkeni kullanarak dll içindeki fonksiyona ulaştık
        KareAlanTextBox.Text = Sonuc
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ucgen_hesap As New alanlar
        Dim taban As Decimal = TextBox1.Text
        Dim yuksek As Decimal = TextBox2.Text
        Dim sonuc As Decimal = ucgen_hesap.UcgenAlan(taban, yuksek)
        TextBox3.Text = sonuc
    End Sub
End Class
